using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 企业人力资源管理系统
{
    public partial class frmMain : Form
    {
        List<Form> frmLst = new List<Form>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form frm = new frmScan();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
        void showForm(string text)
        {
            Form frm = null;
            frm = frmLst.Find(x => x.Text == text);
            if (frm != null)
            {
                frm.Activate();
                return;
            }
            if (text == "员工信息总览")
            {
                frm = new frmScan();
            }
            else if (text == "经理信息")
            {
                frm = new frmManagerInfo();
            }
            else if (text == "销售经理信息")
            {
                frm = new frmSellManager();
            }
            else if(text == "技术总监信息")
            {
                frm = new frmTechManager();
            }
            else if (text == "销售人员信息")
            {
                frm = new frmSeller();
            }
            else if (text == "技术人员信息")
            {
                frm = new frmTecher();
            }
            else if (text == "员工工资总览")
            {
                frm = new frmSalaryInfo();
            }
            else if(text == "经理工资")
            {
                frm = new frmSalaryManager();
            }
            else if (text == "销售经理工资")
            {
                frm = new frmSalarySellManager();
            }
            else if (text == "技术总监工资")
            {
                frm = new frmSalaryTechManager();
            }
            else if (text == "销售人员工资")
            {
                frm = new frmSalarySell();
            }
            else if (text == "技术人员工资")
            {
                frm = new frmSalaryTech();
            }
            else if (text == "员工信息查询")
            {
                frm = new frmInfoSelect();
            }
            frm.Text = text;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frmLst.Add(frm);
            frm.Show();
        }

        private void trvMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            showForm(trvMain.SelectedNode.Text);
        }
    }
}
