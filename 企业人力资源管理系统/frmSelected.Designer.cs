namespace 企业人力资源管理系统
{
    partial class frmSelected
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.clmnF0101 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0202 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0204 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0205 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0206 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0207 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0208 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0209 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0210 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0211 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnF0212 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 65);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 22F);
            this.lblTitle.Location = new System.Drawing.Point(383, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "查询结果";
            // 
            // dgvMain
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 15F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnF0101,
            this.clmnF0202,
            this.clmnF0204,
            this.clmnF0205,
            this.clmnF0206,
            this.clmnF0207,
            this.clmnF0208,
            this.clmnF0209,
            this.clmnF0210,
            this.clmnF0211,
            this.clmnF0212});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 15F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 65);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.Size = new System.Drawing.Size(918, 258);
            this.dgvMain.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 65);
            this.panel2.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("宋体", 15F);
            this.btnClose.Location = new System.Drawing.Point(763, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // clmnF0101
            // 
            this.clmnF0101.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0101.DataPropertyName = "F0101";
            this.clmnF0101.HeaderText = "编号";
            this.clmnF0101.Name = "clmnF0101";
            // 
            // clmnF0202
            // 
            this.clmnF0202.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0202.DataPropertyName = "F0202";
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
            // clmnF0208
            // 
            this.clmnF0208.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0208.DataPropertyName = "F0208";
            this.clmnF0208.HeaderText = "销售额";
            this.clmnF0208.Name = "clmnF0208";
            // 
            // clmnF0209
            // 
            this.clmnF0209.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0209.DataPropertyName = "F0209";
            this.clmnF0209.HeaderText = "提成比例";
            this.clmnF0209.Name = "clmnF0209";
            // 
            // clmnF0210
            // 
            this.clmnF0210.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0210.DataPropertyName = "F0210";
            this.clmnF0210.HeaderText = "职务津贴";
            this.clmnF0210.Name = "clmnF0210";
            // 
            // clmnF0211
            // 
            this.clmnF0211.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0211.DataPropertyName = "F0211";
            this.clmnF0211.HeaderText = "工作时数";
            this.clmnF0211.Name = "clmnF0211";
            // 
            // clmnF0212
            // 
            this.clmnF0212.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnF0212.DataPropertyName = "F0212";
            this.clmnF0212.HeaderText = "每小时金额";
            this.clmnF0212.Name = "clmnF0212";
            // 
            // frmSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 323);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.panel1);
            this.Name = "frmSelected";
            this.Text = "frmSelected";
            this.Activated += new System.EventHandler(this.frmSelected_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0101;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0202;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0204;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0205;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0206;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0207;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0208;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0209;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0210;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0211;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnF0212;

    }
}