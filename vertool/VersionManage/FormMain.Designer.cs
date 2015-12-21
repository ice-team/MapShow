namespace Ice.MapShow.VersionManage
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.list_group = new System.Windows.Forms.ListBox();
            this.list_files = new System.Windows.Forms.ListBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_gen = new System.Windows.Forms.Button();
            this.list_console = new System.Windows.Forms.ListBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.splitContainer_groupfile_btns = new System.Windows.Forms.SplitContainer();
            this.splitContainer_groups_files = new System.Windows.Forms.SplitContainer();
            this.groupBox_groups = new System.Windows.Forms.GroupBox();
            this.groupBox_files = new System.Windows.Forms.GroupBox();
            this.splitContainer_btns = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel_btns = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_console = new System.Windows.Forms.GroupBox();
            this.splitContainer_console = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel_clear = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_addGroup = new System.Windows.Forms.Button();
            this.splitContainer_groupfile_btns.Panel1.SuspendLayout();
            this.splitContainer_groupfile_btns.Panel2.SuspendLayout();
            this.splitContainer_groupfile_btns.SuspendLayout();
            this.splitContainer_groups_files.Panel1.SuspendLayout();
            this.splitContainer_groups_files.Panel2.SuspendLayout();
            this.splitContainer_groups_files.SuspendLayout();
            this.groupBox_groups.SuspendLayout();
            this.groupBox_files.SuspendLayout();
            this.splitContainer_btns.Panel1.SuspendLayout();
            this.splitContainer_btns.Panel2.SuspendLayout();
            this.splitContainer_btns.SuspendLayout();
            this.flowLayoutPanel_btns.SuspendLayout();
            this.groupBox_console.SuspendLayout();
            this.splitContainer_console.Panel1.SuspendLayout();
            this.splitContainer_console.Panel2.SuspendLayout();
            this.splitContainer_console.SuspendLayout();
            this.flowLayoutPanel_clear.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_group
            // 
            this.list_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_group.FormattingEnabled = true;
            this.list_group.ItemHeight = 15;
            this.list_group.Location = new System.Drawing.Point(4, 22);
            this.list_group.Margin = new System.Windows.Forms.Padding(4);
            this.list_group.Name = "list_group";
            this.list_group.Size = new System.Drawing.Size(325, 334);
            this.list_group.TabIndex = 0;
            this.list_group.SelectedIndexChanged += new System.EventHandler(this.list_group_SelectedIndexChanged);
            // 
            // list_files
            // 
            this.list_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_files.FormattingEnabled = true;
            this.list_files.ItemHeight = 15;
            this.list_files.Location = new System.Drawing.Point(4, 22);
            this.list_files.Margin = new System.Windows.Forms.Padding(4);
            this.list_files.Name = "list_files";
            this.list_files.Size = new System.Drawing.Size(660, 334);
            this.list_files.TabIndex = 1;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.SystemColors.Control;
            this.btn_check.Location = new System.Drawing.Point(4, 4);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(128, 32);
            this.btn_check.TabIndex = 2;
            this.btn_check.Text = "检查";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_gen
            // 
            this.btn_gen.BackColor = System.Drawing.SystemColors.Control;
            this.btn_gen.Location = new System.Drawing.Point(140, 4);
            this.btn_gen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(128, 32);
            this.btn_gen.TabIndex = 3;
            this.btn_gen.Text = "生成版本";
            this.btn_gen.UseVisualStyleBackColor = false;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // list_console
            // 
            this.list_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_console.FormattingEnabled = true;
            this.list_console.ItemHeight = 15;
            this.list_console.Location = new System.Drawing.Point(0, 0);
            this.list_console.Margin = new System.Windows.Forms.Padding(4);
            this.list_console.MinimumSize = new System.Drawing.Size(512, 256);
            this.list_console.Name = "list_console";
            this.list_console.Size = new System.Drawing.Size(865, 279);
            this.list_console.TabIndex = 4;
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSize = true;
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.Location = new System.Drawing.Point(4, 4);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.MinimumSize = new System.Drawing.Size(120, 0);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 25);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // splitContainer_groupfile_btns
            // 
            this.splitContainer_groupfile_btns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer_groupfile_btns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_groupfile_btns.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_groupfile_btns.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer_groupfile_btns.Name = "splitContainer_groupfile_btns";
            this.splitContainer_groupfile_btns.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_groupfile_btns.Panel1
            // 
            this.splitContainer_groupfile_btns.Panel1.Controls.Add(this.splitContainer_groups_files);
            // 
            // splitContainer_groupfile_btns.Panel2
            // 
            this.splitContainer_groupfile_btns.Panel2.Controls.Add(this.splitContainer_btns);
            this.splitContainer_groupfile_btns.Size = new System.Drawing.Size(1006, 721);
            this.splitContainer_groupfile_btns.SplitterDistance = 360;
            this.splitContainer_groupfile_btns.SplitterWidth = 5;
            this.splitContainer_groupfile_btns.TabIndex = 6;
            // 
            // splitContainer_groups_files
            // 
            this.splitContainer_groups_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_groups_files.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_groups_files.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer_groups_files.Name = "splitContainer_groups_files";
            // 
            // splitContainer_groups_files.Panel1
            // 
            this.splitContainer_groups_files.Panel1.Controls.Add(this.groupBox_groups);
            // 
            // splitContainer_groups_files.Panel2
            // 
            this.splitContainer_groups_files.Panel2.Controls.Add(this.groupBox_files);
            this.splitContainer_groups_files.Size = new System.Drawing.Size(1006, 360);
            this.splitContainer_groups_files.SplitterDistance = 333;
            this.splitContainer_groups_files.SplitterWidth = 5;
            this.splitContainer_groups_files.TabIndex = 0;
            // 
            // groupBox_groups
            // 
            this.groupBox_groups.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_groups.Controls.Add(this.list_group);
            this.groupBox_groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_groups.Location = new System.Drawing.Point(0, 0);
            this.groupBox_groups.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_groups.Name = "groupBox_groups";
            this.groupBox_groups.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_groups.Size = new System.Drawing.Size(333, 360);
            this.groupBox_groups.TabIndex = 0;
            this.groupBox_groups.TabStop = false;
            this.groupBox_groups.Text = "组";
            // 
            // groupBox_files
            // 
            this.groupBox_files.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_files.Controls.Add(this.list_files);
            this.groupBox_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_files.Location = new System.Drawing.Point(0, 0);
            this.groupBox_files.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_files.Name = "groupBox_files";
            this.groupBox_files.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_files.Size = new System.Drawing.Size(668, 360);
            this.groupBox_files.TabIndex = 1;
            this.groupBox_files.TabStop = false;
            this.groupBox_files.Text = "文件";
            // 
            // splitContainer_btns
            // 
            this.splitContainer_btns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_btns.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_btns.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer_btns.Name = "splitContainer_btns";
            this.splitContainer_btns.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_btns.Panel1
            // 
            this.splitContainer_btns.Panel1.Controls.Add(this.flowLayoutPanel_btns);
            // 
            // splitContainer_btns.Panel2
            // 
            this.splitContainer_btns.Panel2.Controls.Add(this.groupBox_console);
            this.splitContainer_btns.Size = new System.Drawing.Size(1006, 356);
            this.splitContainer_btns.SplitterDistance = 46;
            this.splitContainer_btns.SplitterWidth = 5;
            this.splitContainer_btns.TabIndex = 0;
            // 
            // flowLayoutPanel_btns
            // 
            this.flowLayoutPanel_btns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel_btns.Controls.Add(this.btn_check);
            this.flowLayoutPanel_btns.Controls.Add(this.btn_gen);
            this.flowLayoutPanel_btns.Controls.Add(this.btn_addGroup);
            this.flowLayoutPanel_btns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_btns.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_btns.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel_btns.Name = "flowLayoutPanel_btns";
            this.flowLayoutPanel_btns.Size = new System.Drawing.Size(1006, 46);
            this.flowLayoutPanel_btns.TabIndex = 4;
            // 
            // groupBox_console
            // 
            this.groupBox_console.BackColor = System.Drawing.Color.LightGray;
            this.groupBox_console.Controls.Add(this.splitContainer_console);
            this.groupBox_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_console.Location = new System.Drawing.Point(0, 0);
            this.groupBox_console.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_console.MinimumSize = new System.Drawing.Size(512, 256);
            this.groupBox_console.Name = "groupBox_console";
            this.groupBox_console.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_console.Size = new System.Drawing.Size(1006, 305);
            this.groupBox_console.TabIndex = 1;
            this.groupBox_console.TabStop = false;
            this.groupBox_console.Text = "日志";
            // 
            // splitContainer_console
            // 
            this.splitContainer_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_console.Location = new System.Drawing.Point(4, 22);
            this.splitContainer_console.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer_console.Name = "splitContainer_console";
            // 
            // splitContainer_console.Panel1
            // 
            this.splitContainer_console.Panel1.Controls.Add(this.list_console);
            this.splitContainer_console.Panel1MinSize = 256;
            // 
            // splitContainer_console.Panel2
            // 
            this.splitContainer_console.Panel2.Controls.Add(this.flowLayoutPanel_clear);
            this.splitContainer_console.Panel2MinSize = 128;
            this.splitContainer_console.Size = new System.Drawing.Size(998, 279);
            this.splitContainer_console.SplitterDistance = 865;
            this.splitContainer_console.SplitterWidth = 5;
            this.splitContainer_console.TabIndex = 0;
            // 
            // flowLayoutPanel_clear
            // 
            this.flowLayoutPanel_clear.AutoSize = true;
            this.flowLayoutPanel_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_clear.Controls.Add(this.btn_clear);
            this.flowLayoutPanel_clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel_clear.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel_clear.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_clear.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel_clear.MaximumSize = new System.Drawing.Size(128, 0);
            this.flowLayoutPanel_clear.MinimumSize = new System.Drawing.Size(128, 0);
            this.flowLayoutPanel_clear.Name = "flowLayoutPanel_clear";
            this.flowLayoutPanel_clear.Size = new System.Drawing.Size(128, 279);
            this.flowLayoutPanel_clear.TabIndex = 6;
            // 
            // btn_addGroup
            // 
            this.btn_addGroup.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addGroup.Location = new System.Drawing.Point(276, 4);
            this.btn_addGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addGroup.Name = "btn_addGroup";
            this.btn_addGroup.Size = new System.Drawing.Size(128, 32);
            this.btn_addGroup.TabIndex = 4;
            this.btn_addGroup.Text = "添加组";
            this.btn_addGroup.UseVisualStyleBackColor = false;
            this.btn_addGroup.Click += new System.EventHandler(this.btn_addGroup_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.splitContainer_groupfile_btns);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "版本生成工具";
            this.Load += new System.EventHandler(this.Form_Load);
            this.splitContainer_groupfile_btns.Panel1.ResumeLayout(false);
            this.splitContainer_groupfile_btns.Panel2.ResumeLayout(false);
            this.splitContainer_groupfile_btns.ResumeLayout(false);
            this.splitContainer_groups_files.Panel1.ResumeLayout(false);
            this.splitContainer_groups_files.Panel2.ResumeLayout(false);
            this.splitContainer_groups_files.ResumeLayout(false);
            this.groupBox_groups.ResumeLayout(false);
            this.groupBox_files.ResumeLayout(false);
            this.splitContainer_btns.Panel1.ResumeLayout(false);
            this.splitContainer_btns.Panel2.ResumeLayout(false);
            this.splitContainer_btns.ResumeLayout(false);
            this.flowLayoutPanel_btns.ResumeLayout(false);
            this.groupBox_console.ResumeLayout(false);
            this.splitContainer_console.Panel1.ResumeLayout(false);
            this.splitContainer_console.Panel2.ResumeLayout(false);
            this.splitContainer_console.Panel2.PerformLayout();
            this.splitContainer_console.ResumeLayout(false);
            this.flowLayoutPanel_clear.ResumeLayout(false);
            this.flowLayoutPanel_clear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_group;
        private System.Windows.Forms.ListBox list_files;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.ListBox list_console;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.SplitContainer splitContainer_groupfile_btns;
        private System.Windows.Forms.SplitContainer splitContainer_groups_files;
        private System.Windows.Forms.GroupBox groupBox_groups;
        private System.Windows.Forms.GroupBox groupBox_files;
        private System.Windows.Forms.SplitContainer splitContainer_btns;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_btns;
        private System.Windows.Forms.GroupBox groupBox_console;
        private System.Windows.Forms.SplitContainer splitContainer_console;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_clear;
        private System.Windows.Forms.Button btn_addGroup;
    }
}

