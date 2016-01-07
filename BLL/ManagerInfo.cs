using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace BLL
{
    public class ManagerInfo : Scan
    {
        public override DataSet show()
        {
            string sqlstr = "select * from T01 where F0106 = '销售经理' or F0106 = '技术总监' ";
            SQLiteConnection sqlcon = new SQLiteConnection(connectionString);
            SQLiteCommand sqlcmd = new SQLiteCommand();
            sqlcmd.CommandText = sqlstr;
            sqlcmd.Connection = sqlcon;
            sqlcon.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Table");
            sqlcon.Close();
            return ds;
        }
    }
}
