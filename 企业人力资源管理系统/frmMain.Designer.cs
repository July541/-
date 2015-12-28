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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("销售经理信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("技术总监信息");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("经理信息", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("销售人员信息");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("技术人员信息");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("员工信息总览", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("销售经理工资");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("技术总监工资");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("经理工资", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("销售人员工资");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("技术人员工资");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("员工工资总览", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("员工信息查询");
            this.panel1 = new System.Windows.Forms.Panel();
            this.trvMain = new System.Windows.Forms.TreeView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 102);
            this.panel1.TabIndex = 2;
            // 
            // trvMain
            // 
            this.trvMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvMain.Font = new System.Drawing.Font("宋体", 15F);
            this.trvMain.Location = new System.Drawing.Point(0, 102);
            this.trvMain.Name = "trvMain";
            treeNode1.Name = "节点3";
            treeNode1.Text = "销售经理信息";
            treeNode2.Name = "节点4";
            treeNode2.Text = "技术总监信息";
            treeNode3.Name = "节点0";
            treeNode3.Text = "经理信息";
            treeNode4.Name = "节点1";
            treeNode4.Text = "销售人员信息";
            treeNode5.Name = "节点2";
            treeNode5.Text = "技术人员信息";
            treeNode6.Name = "节点0";
            treeNode6.Text = "员工信息总览";
            treeNode7.Name = "节点12";
            treeNode7.Text = "销售经理工资";
            treeNode8.Name = "节点13";
            treeNode8.Text = "技术总监工资";
            treeNode9.Name = "节点7";
            treeNode9.Text = "经理工资";
            treeNode10.Name = "节点8";
            treeNode10.Text = "销售人员工资";
            treeNode11.Name = "节点9";
            treeNode11.Text = "技术人员工资";
            treeNode12.Name = "节点6";
            treeNode12.Text = "员工工资总览";
            treeNode13.Name = "节点5";
            treeNode13.Text = "员工信息查询";
            this.trvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12,
            treeNode13});
            this.trvMain.Size = new System.Drawing.Size(212, 561);
            this.trvMain.TabIndex = 5;
            this.trvMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMain_AfterSelect);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 22F);
            this.lblTitle.Location = new System.Drawing.Point(258, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(493, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "企业人力资源管理系统——工资管理";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(212, 102);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 561);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1016, 663);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.trvMain);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "企业人力资源管理系统——工资管理";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView trvMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Splitter splitter1;

    }
}

