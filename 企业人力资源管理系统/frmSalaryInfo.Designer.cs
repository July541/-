namespace 企业人力资源管理系统
{
    partial class frmSalaryInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panBg = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clmnF0201 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0202 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0204 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0205 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0206 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0207 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panTop.SuspendLayout();
            this.panBg.SuspendLayout();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(193, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "员工工资总览";
            // 
            // panBg
            // 
            this.panBg.Controls.Add(this.panMain);
            this.panBg.Controls.Add(this.panTop);
            this.panBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBg.Location = new System.Drawing.Point(0, 0);
            this.panBg.Name = "panBg";
            this.panBg.Size = new System.Drawing.Size(851, 595);
            this.panBg.TabIndex = 1;
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
            this.clmnF0201,
            this.clmnF0202,
            this.clmnF0204,
            this.clmnF0205,
            this.clmnF0206,
            this.clmnF0207});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Enabled = false;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.Size = new System.Drawing.Size(851, 408);
            this.dgvMain.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 93);
            this.panel1.TabIndex = 1;
            // 
            // clmnF0201
            // 
            this.clmnF0201.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0201.DataPropertyName = "F0201";
            this.clmnF0201.HeaderText = "编号";
            this.clmnF0201.Name = "clmnF0201";
            // 
            // clmnF0202
            // 
            this.clmnF0202.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0202.HeaderText = "姓名";
            this.clmnF0202.Name = "clmnF0202";
            // 
            // clmnF0204
            // 
            this.clmnF0204.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0204.DataPropertyName = "F0204";
            this.clmnF0204.HeaderText = "实发工资";
            this.clmnF0204.Name = "clmnF0204";
            // 
            // clmnF0205
            // 
            this.clmnF0205.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0205.DataPropertyName = "F0205";
            this.clmnF0205.HeaderText = "基本工资";
            this.clmnF0205.Name = "clmnF0205";
            // 
            // clmnF0206
            // 
            this.clmnF0206.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0206.DataPropertyName = "F0206";
            this.clmnF0206.HeaderText = "奖金";
            this.clmnF0206.Name = "clmnF0206";
            // 
            // clmnF0207
            // 
            this.clmnF0207.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0207.DataPropertyName = "F0207";
            this.clmnF0207.HeaderText = "扣发工资";
            this.clmnF0207.Name = "clmnF0207";
            // 
            // frmSalaryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 595);
            this.Controls.Add(this.panBg);
            this.Name = "frmSalaryInfo";
            this.Text = "frmSalaryInfo";
            this.Activated += new System.EventHandler(this.frmSalaryInfo_Activated);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panBg.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panBg;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0201;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0202;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0204;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0205;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0206;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0207;
    }
}