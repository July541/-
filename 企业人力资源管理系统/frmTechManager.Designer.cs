namespace 企业人力资源管理系统
{
    partial class frmTechManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panBg = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.clmnF0101 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0102 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0108 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmnF0103 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0104 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0105 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmnF0106 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmnF0107 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panTop.SuspendLayout();
            this.panBg.SuspendLayout();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.lblTitle);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(851, 94);
            this.panTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 22F);
            this.lblTitle.Location = new System.Drawing.Point(321, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "技术总监信息总览";
            // 
            // panBg
            // 
            this.panBg.Controls.Add(this.panMain);
            this.panBg.Controls.Add(this.panTop);
            this.panBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBg.Location = new System.Drawing.Point(0, 0);
            this.panBg.Name = "panBg";
            this.panBg.Size = new System.Drawing.Size(851, 595);
            this.panBg.TabIndex = 3;
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.dgvMain);
            this.panMain.Controls.Add(this.panel1);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 94);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(851, 501);
            this.panMain.TabIndex = 1;
            // 
            // dgvMain
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnF0101,
            this.clmnF0102,
            this.clmnF0108,
            this.clmnF0103,
            this.clmnF0104,
            this.clmnF0105,
            this.clmnF0106,
            this.clmnF0107});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.Size = new System.Drawing.Size(851, 408);
            this.dgvMain.TabIndex = 2;
            this.dgvMain.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseDown);
            this.dgvMain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMain_DataError);
            // 
            // clmnF0101
            // 
            this.clmnF0101.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0101.DataPropertyName = "F0101";
            this.clmnF0101.HeaderText = "编号";
            this.clmnF0101.Name = "clmnF0101";
            // 
            // clmnF0102
            // 
            this.clmnF0102.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0102.DataPropertyName = "F0102";
            this.clmnF0102.HeaderText = "姓名";
            this.clmnF0102.Name = "clmnF0102";
            // 
            // clmnF0108
            // 
            this.clmnF0108.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0108.DataPropertyName = "F0108";
            this.clmnF0108.HeaderText = "性别";
            this.clmnF0108.Name = "clmnF0108";
            this.clmnF0108.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnF0108.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmnF0103
            // 
            this.clmnF0103.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0103.DataPropertyName = "F0103";
            this.clmnF0103.HeaderText = "年龄";
            this.clmnF0103.Name = "clmnF0103";
            // 
            // clmnF0104
            // 
            this.clmnF0104.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0104.DataPropertyName = "F0104";
            this.clmnF0104.HeaderText = "参加工作时间";
            this.clmnF0104.Name = "clmnF0104";
            // 
            // clmnF0105
            // 
            this.clmnF0105.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0105.DataPropertyName = "F0105";
            this.clmnF0105.HeaderText = "部门";
            this.clmnF0105.Name = "clmnF0105";
            this.clmnF0105.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnF0105.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmnF0106
            // 
            this.clmnF0106.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0106.DataPropertyName = "F0106";
            this.clmnF0106.HeaderText = "职务";
            this.clmnF0106.Name = "clmnF0106";
            this.clmnF0106.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnF0106.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmnF0107
            // 
            this.clmnF0107.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0107.DataPropertyName = "F0107";
            this.clmnF0107.HeaderText = "联系方式";
            this.clmnF0107.Name = "clmnF0107";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 93);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("宋体", 15F);
            this.btnSave.Location = new System.Drawing.Point(638, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 49);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除记录ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 删除记录ToolStripMenuItem
            // 
            this.删除记录ToolStripMenuItem.Name = "删除记录ToolStripMenuItem";
            this.删除记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除记录ToolStripMenuItem.Text = "删除记录";
            this.删除记录ToolStripMenuItem.Click += new System.EventHandler(this.删除记录ToolStripMenuItem_Click);
            // 
            // frmTechManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 595);
            this.Controls.Add(this.panBg);
            this.Name = "frmTechManager";
            this.Text = "frmTechManager";
            this.Activated += new System.EventHandler(this.frmTechManager_Activated);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panBg.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panBg;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0101;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0102;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmnF0108;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0103;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0104;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmnF0105;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmnF0106;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0107;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除记录ToolStripMenuItem;
    }
}