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
    public partial class frmSellManager : Form
    {
        DataTable dt = new DataTable();
        private int CurrentRowIndex { get; set; }
        public frmSellManager()
        {
            InitializeComponent();
        }

        private void frmSellManager_Activated(object sender, EventArgs e)
        {
            ManagerSell man = new ManagerSell();
            DataSet ds = new DataSet();
            clmnF0108.Items.Add("男");
            clmnF0108.Items.Add("女");
            clmnF0105.Items.Add("销售部");
            clmnF0106.Items.Add("销售经理");
            ds = man.show();
            dt = ds.Tables[0];
            this.dgvMain.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ManagerInfo man = new ManagerInfo();
            if (man.save(dt))
            {
                MessageBox.Show("保存成功！");
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

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMain.Rows[CurrentRowIndex];
            string where = Convert.ToString(this.dgvMain.Rows[CurrentRowIndex].Cells[0].Value);
            if (where == "")
            { }
            else
            {
                ManagerInfo man = new ManagerInfo();
                man.delete(where);
                this.dgvMain.Rows.Remove(row);
            }
        }

    }
}
