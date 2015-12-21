using System;
using System.Collections.Generic;
using System.Text;

namespace Ice.MapShow.VersionManage
{
    /// <summary>版本信息</summary>
    public class VersionInfo
    {
        /// <summary>构造函数</summary>
        /// <param name="group">组别</param>
        public VersionInfo(string group)
        {
            this.group = group;
        }

        /// <summary>组别</summary>
        public string group
        {
            get;
            private set;
        }

        public int match = 0;

        /// <summary>文件Hash串</summary>
        public Dictionary<string, string> fileHash = new Dictionary<string, string>();

        static System.Security.Cryptography.SHA1CryptoServiceProvider osha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();

        public void GenerateHash()
        {
            string[] files = System.IO.Directory.GetFiles(this.group, "*.*", System.IO.SearchOption.AllDirectories);
            foreach (var f in files)
            {
                if (f.IndexOf(".crc.txt") >= 0 ||
                    f.IndexOf(".meta") >= 0 ||
                    f.IndexOf(".db") >= 0)
                {
                    continue;
                }
                GenHashOne(f);
            }
        }

        public void GenHashOne(string filename)
        {
            using (System.IO.Stream s = System.IO.File.OpenRead(filename))
            {
                var hash = osha1.ComputeHash(s);
                var shash = Convert.ToBase64String(hash) + "@" + s.Length;
                filename = filename.Substring(group.Length + 1);

                filename = filename.Replace('\\', '/');
                fileHash[filename] = shash;
            }
        }

        public string SaveToPath(int ver, string path)
        {
            string outstr = "Ver:" + ver + "|FC:" + this.fileHash.Count + "\n";
            foreach (var f in fileHash)
            {
                outstr += f.Key + "|" + f.Value + "\n";
            }
            string g = this.group.Replace('/', '_');
            string outfile = System.IO.Path.Combine(path, g + ".ver");
            System.IO.File.WriteAllText(outfile, outstr, Encoding.UTF8);
            using (System.IO.Stream s = System.IO.File.OpenRead(outfile))
            {
                var hash = osha1.ComputeHash(s);
                var shash = Convert.ToBase64String(hash);
                return shash;
            }
        }

        public bool Read(int ver, string hash, int filecount, string path)
        {
            string g = this.group.Replace('/', '_');
            string file = System.IO.Path.Combine(path, g + ".ver");
            if (System.IO.File.Exists(file) == false) return false;
            using (System.IO.Stream s = System.IO.File.OpenRead(file))
            {
                var rhash = osha1.ComputeHash(s);
                var shash = Convert.ToBase64String(rhash);
                if (shash != hash) return false;//Hash 不匹配
            }
            string txt = System.IO.File.ReadAllText(file, Encoding.UTF8);
            string[] lines = txt.Split(new string[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var l in lines)
            {
                if (l.IndexOf("Ver:") == 0)
                {
                    var sp = l.Split(new string[] { "Ver:", "|FC:" }, StringSplitOptions.RemoveEmptyEntries);
                    int mver = int.Parse(sp[0]);
                    int mcount = int.Parse(sp[1]);
                    if (ver != mver) return false;
                    if (mcount != filecount) return false;
                }
                else
                {
                    var sp = l.Split('|');
                    fileHash[sp[0]] = sp[1];
                }
            }
            return true;
        }
    }

    /// <summary>
    /// 每个版本系统放在一个路径下，下有all.ver文件管理整个路径下的所有文件，一个版本系统下设多个组别，每个组别即一个文件夹，下可有子文件夹
    /// ----------------------------------------------------------------
    /// all.ver
    /// Ver:7(当前版本号)
    /// info(组名)|mjrPJfud9U6rDmkm1ditSK3mux8=(hash串)|1(文件个数)
    /// data|iXd3ZDOUOmpE3+Ev9lqU15P4u8c=|3
    /// -----------------------------------------------------------------
    /// </summary>
    public class VersionAll
    {
        /// <summary>版本号</summary>
        public int versionNum;

        public Dictionary<string, VersionInfo> groups = new Dictionary<string, VersionInfo>();

        public override string ToString()
        {
            int useful = 0;
            int filecount = 0;
            int filematch = 0;

            foreach (var i in groups)
            {
                if (i.Value.match > 0) useful++;
                filematch += i.Value.match;
                filecount += i.Value.fileHash.Count;
            }

            return "ver=" + versionNum + " group=(" + useful + "/" + groups.Count + ") file=(" + filematch + "/" + filecount + ")";
        }

        /// <summary>读取版本描述文件all.ver</summary>
        /// <param name="path">all.ver的所在路径</param>
        public static VersionAll Read(string path)
        {
            if (System.IO.File.Exists(System.IO.Path.Combine(path, "all.ver")) == false)
            {
                return null;
            }

            string txt = System.IO.File.ReadAllText(System.IO.Path.Combine(path, "all.ver"), Encoding.UTF8);
            string[] lines = txt.Split(new string[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            VersionAll ver = new VersionAll();

            foreach (var l in lines)
            {
                if (l.IndexOf("Ver:") == 0)
                {
                    ver.versionNum = int.Parse(l.Substring(4));
                }
                else
                {
                    var sp = l.Split('|');
                    ver.groups[sp[0]] = new VersionInfo(sp[0]);
                    ver.groups[sp[0]].Read(ver.versionNum, sp[1], int.Parse(sp[2]), path);
                }
            }
            return ver;
        }

        /// <summary>保存版本描述文件all.ver</summary>
        public void SaveToPath(string path)
        {
            Dictionary<string, string> grouphash = new Dictionary<string, string>();

            foreach (var i in groups.Values)
            {
                grouphash[i.group] = i.SaveToPath(this.versionNum, path);
            }

            string outstr = "Ver:" + this.versionNum + "\n";

            foreach (var g in grouphash)
            {
                outstr += g.Key + "|" + g.Value + "|" + groups[g.Key].fileHash.Count + "\n";
            }

            System.IO.File.WriteAllText(System.IO.Path.Combine(path, "all.ver"), outstr, Encoding.UTF8);
        }
    }

}