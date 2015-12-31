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
    public partial class frmSalaryTech : Form
    {
        DataTable dt = new DataTable();
        public frmSalaryTech()
        {
            InitializeComponent();
        }

        private void frmSalaryTech_Activated(object sender, EventArgs e)
        {
            SalaryTech sal = new SalaryTech();
            DataSet ds = new DataSet();
            ds = sal.show();
            dt = ds.Tables[0];
            dgvMain.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                i = dgvMain.Rows.Add();
                dgvMain.Rows[i].Cells[0].Value = dt.Rows[i][1];
                dgvMain.Rows[i].Cells[1].Value = dt.Rows[i][2];
                dgvMain.Rows[i].Cells[2].Value = dt.Rows[i][4];
                dgvMain.Rows[i].Cells[3].Value = dt.Rows[i][5];
                dgvMain.Rows[i].Cells[4].Value = dt.Rows[i][6];
                dgvMain.Rows[i].Cells[5].Value = dt.Rows[i][7];
                dgvMain.Rows[i].Cells[6].Value = dt.Rows[i][11];
                dgvMain.Rows[i].Cells[7].Value = dt.Rows[i][12];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvMain.Rows[i].Cells[2].Value = Convert.ToDecimal(dgvMain.Rows[i].Cells[3].Value) + Convert.ToDecimal(dgvMain.Rows[i].Cells[4].Value) - Convert.ToDecimal(dgvMain.Rows[i].Cells[5].Value) + Convert.ToDecimal(dgvMain.Rows[i].Cells[6].Value) * Convert.ToDecimal(dgvMain.Rows[i].Cells[7].Value);
                dt.Rows[i][4] = dgvMain.Rows[i].Cells[2].Value;
                dt.Rows[i][5] = dgvMain.Rows[i].Cells[3].Value;
                dt.Rows[i][6] = dgvMain.Rows[i].Cells[4].Value;
                dt.Rows[i][7] = dgvMain.Rows[i].Cells[5].Value;
                dt.Rows[i][11] = dgvMain.Rows[i].Cells[6].Value;
                dt.Rows[i][12] = dgvMain.Rows[i].Cells[7].Value;
            }
            SalaryTech sal = new SalaryTech();
            sal.save(dt);
        }
    }
}
