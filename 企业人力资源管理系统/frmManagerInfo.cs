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
    public partial class frmManagerInfo : Form
    {
        DataTable dt = new DataTable();
        Global g = new Global();
        private int CurrentRowIndex { get; set; }
        public frmManagerInfo()
        {
            InitializeComponent();
        }

        private void frmManagerInfo_Activated(object sender, EventArgs e)
        {
            ManagerInfo man = new ManagerInfo();
            DataSet ds = new DataSet();
            clmnF0108.Items.Add("男");
            clmnF0108.Items.Add("女");
            clmnF0105.Items.Add("销售部");
            clmnF0105.Items.Add("技术部");
            clmnF0106.Items.Add("销售经理");
            clmnF0106.Items.Add("技术总监");
            ds = man.show();
            dt = ds.Tables[0];
            this.dgvMain.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool temp = true;
            ManagerInfo man = new ManagerInfo();
            for (int i = 0; i < dgvMain.RowCount - 1;i++)
            {
                if (isNull(i) == false)
                {
                    temp = false;
                    break;
                }
            }
            if (temp == true)
            {
                try
                {
                    man.save(dt);
                    MessageBox.Show("保存成功！", "提示");
                }
                catch (Exception ex)
                {
                    if (ex.Message.Length == 45)
                    {
                        MessageBox.Show("编号已存在！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("输入错误！", "提示");
                    }
                }
            }
        }

        private bool isNull(int row)//TODO: finish others.
        {
            if (dgvMain.Rows[row].Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("姓名输入不能为空！", "提示");
                return false;
            }
            if (dgvMain.Rows[row].Cells[2].Value.ToString() != "" && !g.ageCheck(dgvMain.Rows[row].Cells[2].Value.ToString()))
            {
                MessageBox.Show("年龄输入错误！", "提示");
                return false ;
            }
            return true;
        }

        private void dgvMain_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                CurrentRowIndex = e.RowIndex;
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
                ManagerInfo man = new ManagerInfo();
                man.delete(where);
                this.dgvMain.Rows.Remove(row);
            }
        }

        private void dgvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message.Length == 12)
            {
                MessageBox.Show("应输入数字！", "警告", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("日期格式错误，参照YYYY-MM-DD输入", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
