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
                    MessageBox.Show("ss");
                }
                else
                {
                    MessageBox.Show("查无此人！");
                }
            }
            else if(txtNumber.Text == "")
            {
                if(info.check("string", Convert.ToString(txtName.Text), 0))
                {
                    MessageBox.Show("ssw");
                }
                else
                {
                    MessageBox.Show("查无此人！");
                }
            }
            else
            {
                if(info.check("both", Convert.ToString(txtName.Text), Convert.ToInt32(txtNumber.Text)))
                {
                    MessageBox.Show("bith");
                }
                else
                {
                    MessageBox.Show("查无此人！");
                }
            }
        }
    }
}
