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
using Model;

namespace 企业人力资源管理系统
{
    public partial class frmScan : Form
    {
        //List<T01> lst = new List<T01>();
        DataTable dt = new DataTable();
        Global g = new Global();
        private int CurrentRowIndex { get; set; }
        public frmScan()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool temp = true;
            Scan scan = new Scan();
            for (int i = 0 ; i < dgvMain.RowCount - 1 ; i++ )
            {
                if (isNull(i) == false)
                {
                    temp = false;
                    break;
                }
            }
            if (temp == true)
            {
                if (scan.save(dt))
                {
                    //MessageBox.Show(dt.Rows[1]["F0102"].ToString());
                    MessageBox.Show("保存成功！", "提示");
                }
                else
                {
                    MessageBox.Show("编号已存在！", "提示");
                }
            }
       
        }
        /// <summary>
        /// dataGridView 输入验证。
        /// </summary>
        /// <returns></returns>
        private bool isNull(int row)//TODO: finish others.
        {
            if (dgvMain.Rows[row].Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("姓名输入不能为空！", "提示");
                return false;
            }
            //if (!g.dateCheck(Convert.ToString(dgvMain.Rows[row].Cells[4].Value)))
            //{
            //    MessageBox.Show("日期输入格式不正确！", "提示");
            //    return false;
            //}
            if (!g.ageCheck(dgvMain.Rows[row].Cells[2].Value.ToString()))
            {
                MessageBox.Show("年龄输入不合法！", "提示");
                return false;
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
            //MessageBox.Show(CurrentRowIndex.ToString());
            DataGridViewRow row = dgvMain.Rows[CurrentRowIndex];
            string where = Convert.ToString(this.dgvMain.Rows[CurrentRowIndex].Cells[0].Value);
            if (where == "")
            {  }
            else
            {
                Scan scan = new Scan();
                scan.delete(where);
                this.dgvMain.Rows.Remove(row);
                dt.Rows.Remove(dt.Rows[CurrentRowIndex]);
                MessageBox.Show(dgvMain.Rows.Count.ToString());
            }
        }

        private void frmScan_Activated(object sender, EventArgs e)
        {
            Scan scan = new Scan();
            DataSet ds = new DataSet();
            clmnF0103.Items.Add("男");
            clmnF0103.Items.Add("女");
            clmnF0106.Items.Add("销售部");
            clmnF0106.Items.Add("技术部");
            clmnF0107.Items.Add("销售经理");
            clmnF0107.Items.Add("技术总监");
            clmnF0107.Items.Add("销售人员");
            clmnF0107.Items.Add("技术人员");
            ds = scan.show();
            dt = ds.Tables[0];
            //foreach(DataRow dr in dt.Rows)
            //{
            //    lst.Add(
            //        new T01()
            //        {
            //            F0101 = int.Parse(Convert.ToString(dr[0])),
            //            F0102 = Convert.ToString(dr[1]),
            //            F0103 = int.Parse(Convert.ToString(dr[2])),
            //            F0104 = DateTime.Parse(Convert.ToString(dr[3])),
            //            F0105 = Convert.ToString(dr[4]),
            //            F0106 = Convert.ToString(dr[5]),
            //            F0107 = Convert.ToString(dr[6]),
            //            F0108 = Convert.ToString(dr[7])
            //        }
            //        );
            //}
            this.dgvMain.DataSource = dt;
        }
    }
}
