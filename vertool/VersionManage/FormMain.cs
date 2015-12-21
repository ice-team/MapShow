using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ice.MapShow.VersionManage
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Init_VerAndPath();
            Log(_ver.ToString());
            foreach(var v in _ver.groups)
                list_group.Items.Add(v.Key);
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            CheckVersion();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            GenerateVersion();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            list_console.Items.Clear();
        }

        private void btn_tolower_Click(object sender, EventArgs e)
        {
            FileToTower("./");
        }

        private void btn_addGroup_Click(object sender, EventArgs e)
        {
            string[] dirs = System.IO.Directory.GetDirectories("./");
            string addText = "";

            foreach (var d in dirs)
            {
                string path = d.Substring(2).ToLower();

                if (path.IndexOf("path") == 0)
                    continue;

                if (_ver.groups.ContainsKey(path) == false)
                {
                    //hash串随便写一个有效串即可，生成时会更新
                    addText += path + "|" + "LCgsAJHoiGnSKI7Sa6GyM532r7s=" + "|" + "1" + "\n";
                    Log("检测到并添加新组: " + path);
                }
            }

            StreamWriter writer = System.IO.File.AppendText("all.ver");
            writer.Write(addText, Encoding.UTF8);
            writer.Close();

            list_group.Items.Clear();
            list_files.Items.Clear();
            Init_VerAndPath();
            Log(_ver.ToString());
            foreach (var v in _ver.groups)
                list_group.Items.Add(v.Key);
            CheckVersion();
        }

        private void list_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ver.groups.ContainsKey(list_group.SelectedItem as string))
            {
                var group = _ver.groups[list_group.SelectedItem as string];
                list_files.Items.Clear();
                foreach (var f in group.fileHash)
                {
                    list_files.Items.Add(f.Key + "|" + f.Value);
                }
            }
        }

        private void Log(string msg)
        {
            list_console.Items.Add(msg);
        }

        private void AddGroup(string groupName)
        {
            list_group.Items.Add(groupName);
        }

        private VersionAll _ver = null;
        private VersionAll _vernew = null;
        /// <summary>初始化路径和版本</summary>
        private void Init_VerAndPath()
        {
            _ver = VersionAll.Read("./");

            if (_ver == null)
            {
                _ver = new VersionAll();

                string[] groups = System.IO.Directory.GetDirectories("./");
                foreach (var g in groups)
                {
                    string path = g.Substring(2).ToLower();
                    if (path.IndexOf("path") == 0)
                        continue;
                    _ver.groups[path] = new VersionInfo(path);
                }

                _ver.versionNum = 0;
            }
        }

        /// <summary>文件名小写，递归</summary>
        /// <param name="rootPath">根目录</param>
        void FileToTower(string rootPath) 
        {
            string[] sDirectories = System.IO.Directory.GetDirectories(rootPath);
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(rootPath);

            foreach (string path in sDirectories) 
                FileToTower(path);

            System.IO.FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Name == file.Name.ToLower())
                    continue;
                string newfilefull = file.Directory+"\\" + file.Name.ToLower();
                Log("修改了" + file.Name);
                File.Move(file.FullName, newfilefull);
            }
        }

        /// <summary>检查版本</summary>
        void CheckVersion()
        {
            _vernew = new VersionAll();

            string[] groups = System.IO.Directory.GetDirectories("./");

            foreach (var g in groups)
            {
                string path = g.Substring(2).ToLower();

                if (path.IndexOf("path") == 0)
                    continue;

                if (_ver.groups.ContainsKey(path) == false)
                    Log("目录未包含: " + path + " 如果需要增加，修改all.ver增加一行");
            }

            int delCount = 0;
            int updateCount = 0;
            int addCount = 0;

            foreach (var g in _ver.groups)
            {
                _vernew.groups[g.Key] = new VersionInfo(g.Key);
                _vernew.groups[g.Key].GenerateHash();

                foreach (var f in g.Value.fileHash)
                {
                    if (_vernew.groups[g.Key].fileHash.ContainsKey(f.Key) == false)
                    {
                        Log("文件被删除：" + g.Key + ":" + f.Key);
                        delCount++;
                    }
                    else
                    {
                        string hash = _vernew.groups[g.Key].fileHash[f.Key];
                        string oldhash = g.Value.fileHash[f.Key];
                        if (hash != oldhash)
                        {
                            Log("文件更新：" + g.Key + ":" + f.Key);
                            updateCount++;
                        }
                    }
                }

                foreach (var f in _vernew.groups[g.Key].fileHash)
                {
                    if (g.Value.fileHash.ContainsKey(f.Key) == false)
                    {
                        Log("文件增加：" + g.Key + ":" + f.Key);
                        addCount++;
                    }
                }
            }
           
            if (addCount == 0 && delCount == 0 && updateCount == 0)
            {
                _vernew.versionNum = _ver.versionNum;
                Log("无变化 ver=" + _vernew.versionNum);
            }
            else
            {
                _vernew.versionNum = _ver.versionNum + 1;
                Log("检查变化结果 add: " + addCount + " remove: " + delCount + " update: " + updateCount);
                Log("版本号变为: " + _vernew.versionNum);
            }
        }

        /// <summary>生成版本</summary>
        void GenerateVersion()
        {
            if (_vernew == null)
            {
                Log("先检查一下版本再生成");
                return;
            }
            else if (_vernew.versionNum == _ver.versionNum)
            {
                Log("版本无变化");
                //return;
            }

            _vernew.SaveToPath("./");

            Log("生成OK Ver:" + _vernew.versionNum);

            _ver = _vernew;

            list_group.Items.Clear();
            foreach (var v in _ver.groups)
                AddGroup(v.Key);
        }


    }
}
