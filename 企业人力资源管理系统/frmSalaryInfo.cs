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
    public partial class frmSalaryInfo : Form
    {
        DataTable dt = new DataTable();
        public frmSalaryInfo()
        {
            InitializeComponent();
        }

        private void frmSalaryInfo_Activated(object sender, EventArgs e)
        {
            SalaryInfo sal = new SalaryInfo();
            DataSet ds = new DataSet();
            ds = sal.show();
            dt = ds.Tables[0];
            dgvMain.Rows.Clear();
            for(int i = 0 ; i < dt.Rows.Count; i++)
            {
                i = dgvMain.Rows.Add();
                dgvMain.Rows[i].Cells[0].Value = dt.Rows[i][1];
                dgvMain.Rows[i].Cells[1].Value = dt.Rows[i][2];
                dgvMain.Rows[i].Cells[2].Value = dt.Rows[i][4];
                dgvMain.Rows[i].Cells[3].Value = dt.Rows[i][5];
                dgvMain.Rows[i].Cells[4].Value = dt.Rows[i][6];
                dgvMain.Rows[i].Cells[5].Value = dt.Rows[i][7];
            }
        }
    }
}
