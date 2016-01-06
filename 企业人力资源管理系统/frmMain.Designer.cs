namespace 企业人力资源管理系统
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("销售经理信息");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("技术总监信息");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("经理信息", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("销售人员信息");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("技术人员信息");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("员工信息总览", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("销售经理工资");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("技术总监工资");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("经理工资", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("销售人员工资");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("技术人员工资");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("员工工资总览", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("员工信息查询");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.trvMain = new System.Windows.Forms.TreeView();
            this.imgLstTree = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1016, 102);
            this.panelMain.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTitle.Font = new System.Drawing.Font("隶书", 35F);
            this.lblTitle.Location = new System.Drawing.Point(111, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(788, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "企业人力资源管理系统——工资管理";
            // 
            // trvMain
            // 
            this.trvMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvMain.Font = new System.Drawing.Font("宋体", 15F);
            this.trvMain.ImageIndex = 0;
            this.trvMain.ImageList = this.imgLstTree;
            this.trvMain.Location = new System.Drawing.Point(0, 102);
            this.trvMain.Name = "trvMain";
            treeNode14.Name = "节点3";
            treeNode14.Text = "销售经理信息";
            treeNode15.Name = "节点4";
            treeNode15.Text = "技术总监信息";
            treeNode16.Name = "节点0";
            treeNode16.Text = "经理信息";
            treeNode17.Name = "节点1";
            treeNode17.Text = "销售人员信息";
            treeNode18.Name = "节点2";
            treeNode18.Text = "技术人员信息";
            treeNode19.Name = "节点0";
            treeNode19.Text = "员工信息总览";
            treeNode20.Name = "节点12";
            treeNode20.Text = "销售经理工资";
            treeNode21.Name = "节点13";
            treeNode21.Text = "技术总监工资";
            treeNode22.Name = "节点7";
            treeNode22.Text = "经理工资";
            treeNode23.Name = "节点8";
            treeNode23.Text = "销售人员工资";
            treeNode24.Name = "节点9";
            treeNode24.Text = "技术人员工资";
            treeNode25.Name = "节点6";
            treeNode25.Text = "员工工资总览";
            treeNode26.Name = "节点5";
            treeNode26.Text = "员工信息查询";
            this.trvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode25,
            treeNode26});
            this.trvMain.SelectedImageIndex = 1;
            this.trvMain.Size = new System.Drawing.Size(212, 561);
            this.trvMain.TabIndex = 5;
            this.trvMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMain_AfterSelect);
            // 
            // imgLstTree
            // 
            this.imgLstTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstTree.ImageStream")));
            this.imgLstTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstTree.Images.SetKeyName(0, "126-File.ico");
            this.imgLstTree.Images.SetKeyName(1, "78-Opened-Folder.ico");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(212, 102);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 561);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::企业人力资源管理系统.Properties.Resources._1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::企业人力资源管理系统.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 102);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1016, 663);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.trvMain);
            this.Controls.Add(this.panelMain);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "企业人力资源管理系统——工资管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TreeView trvMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ImageList imgLstTree;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

