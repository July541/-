using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace 企业人力资源管理系统
{
    public partial class frmTecher : Form
    {
        DataTable dt = new DataTable();
        private int CurrentRowIndex { get; set; }
        public frmTecher()
        {
            InitializeComponent();
        }

        private void frmTecher_Activated(object sender, EventArgs e)
        {
            Techer man = new Techer();
            DataSet ds = new DataSet();
            clmnF0108.Items.Add("男");
            clmnF0108.Items.Add("女");
            clmnF0105.Items.Add("技术部");
            clmnF0106.Items.Add("技术人员");
            ds = man.show();
            dt = ds.Tables[0];
            this.dgvMain.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Techer tech = new Techer();
            if (tech.save(dt))
            {
                MessageBox.Show("保存成功！");
            }
        }

        private void 删除记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMain.Rows[CurrentRowIndex];
            string where = Convert.ToString(this.dgvMain.Rows[CurrentRowIndex].Cells[0].Value);
            if (where == "")
            { }
            else
            {
                Techer tech = new Techer();
                tech.delete(where);
                this.dgvMain.Rows.Remove(row);
            }
        }

        private void dgvMain_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                CurrentRowIndex = e.RowIndex;
            }
        }
    }
}
