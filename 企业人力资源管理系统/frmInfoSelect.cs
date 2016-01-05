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
    public partial class frmInfoSelect : Form
    {
        DataSet ds = new DataSet();
        public frmInfoSelect()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            InfoSelect info = new InfoSelect();
            if(txtName.Text == "" && txtNumber.Text == "")
            {
                MessageBox.Show("输入不能为空！", "提示");
                return ;
            }
            else if (!info.ismatch(txtNumber.Text) && txtName.Text == "")
            {
                MessageBox.Show("编号输入错误！", "提示");
                return;
            }
            else if(txtName.Text == "")
            {
                if(info.check("number", null, Convert.ToInt32(txtNumber.Text)))
                {
                    ds = info.show("number", null, Convert.ToInt32(txtNumber.Text));
                    frmSelected frm = new frmSelected();
                    frm.dgvMain.Rows.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        i = frm.dgvMain.Rows.Add();
                        frm.dgvMain.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][1];
                        frm.dgvMain.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][2];
                        frm.dgvMain.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][4];
                        frm.dgvMain.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][5];
                        frm.dgvMain.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][6];
                        frm.dgvMain.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i][7];
                        frm.dgvMain.Rows[i].Cells[6].Value = ds.Tables[0].Rows[i][8];
                        frm.dgvMain.Rows[i].Cells[7].Value = ds.Tables[0].Rows[i][9];
                        frm.dgvMain.Rows[i].Cells[8].Value = ds.Tables[0].Rows[i][10];
                        frm.dgvMain.Rows[i].Cells[9].Value = ds.Tables[0].Rows[i][11];
                        frm.dgvMain.Rows[i].Cells[10].Value = ds.Tables[0].Rows[i][12];
                    }
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("查无此人！", "提示");
                }
            }
            else if(txtNumber.Text == "")
            {
                if(info.check("string", Convert.ToString(txtName.Text), 0))
                {
                    ds = info.show("string", Convert.ToString(txtName.Text), 0);
                    frmSelected frm = new frmSelected();
                    frm.dgvMain.Rows.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        i = frm.dgvMain.Rows.Add();
                        frm.dgvMain.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][1];
                        frm.dgvMain.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][2];
                        frm.dgvMain.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][4];
                        frm.dgvMain.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][5];
                        frm.dgvMain.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][6];
                        frm.dgvMain.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i][7];
                        frm.dgvMain.Rows[i].Cells[6].Value = ds.Tables[0].Rows[i][8];
                        frm.dgvMain.Rows[i].Cells[7].Value = ds.Tables[0].Rows[i][9];
                        frm.dgvMain.Rows[i].Cells[8].Value = ds.Tables[0].Rows[i][10];
                        frm.dgvMain.Rows[i].Cells[9].Value = ds.Tables[0].Rows[i][11];
                        frm.dgvMain.Rows[i].Cells[10].Value = ds.Tables[0].Rows[i][12];
                    }
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("查无此人！", "提示");
                }
            }
            else
            {
                if(info.check("both", Convert.ToString(txtName.Text), Convert.ToInt32(txtNumber.Text)))
                {
                    ds = info.show("both", Convert.ToString(txtName.Text), Convert.ToInt32(txtNumber.Text));
                    frmSelected frm = new frmSelected();
                    frm.dgvMain.Rows.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        i = frm.dgvMain.Rows.Add();
                        frm.dgvMain.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][1];
                        frm.dgvMain.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][2];
                        frm.dgvMain.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][4];
                        frm.dgvMain.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][5];
                        frm.dgvMain.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][6];
                        frm.dgvMain.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i][7];
                        frm.dgvMain.Rows[i].Cells[6].Value = ds.Tables[0].Rows[i][8];
                        frm.dgvMain.Rows[i].Cells[7].Value = ds.Tables[0].Rows[i][9];
                        frm.dgvMain.Rows[i].Cells[8].Value = ds.Tables[0].Rows[i][10];
                        frm.dgvMain.Rows[i].Cells[9].Value = ds.Tables[0].Rows[i][11];
                        frm.dgvMain.Rows[i].Cells[10].Value = ds.Tables[0].Rows[i][12];
                    }
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("查无此人！", "提示");
                }
            }
        }
    }
}
