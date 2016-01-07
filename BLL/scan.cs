using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace BLL
{
    public class Scan : bascial
    {
        public override DataSet show()
        {
            string sqlstr = "select * from T01 ";
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

        public override bool save(DataTable dt)
        {
            string sqlstr = "select * from T01";
            for (int i = 0; i < dt.Rows.Count ; i++)
            {
                string sqlstr2 = string.Format("insert into T02 (F0201, F0101, F0202) values ({0}, {1}, '{2}')", dt.Rows[i]["F0101"], dt.Rows[i]["F0101"], dt.Rows[i]["F0102"]);
                SQLiteConnection sqlcon = new SQLiteConnection(connectionString);
                SQLiteCommand sqlcmd = new SQLiteCommand();
                sqlcmd.CommandText = sqlstr2;
                sqlcmd.Connection = sqlcon;
                sqlcon.Open();
                try
                {
                    sqlcmd.ExecuteNonQuery();
                }
                catch
                { }
                sqlcon.Close();
            }
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sqlstr, connectionString);
            SQLiteCommandBuilder commandBulider = new SQLiteCommandBuilder(dataAdapter);
            dataAdapter.Update(dt);
            return true;
        }

        public override bool update()
        {
            throw new NotImplementedException();
        }

        public override bool delete(string where)
        {
            string sqlstr = "delete from T01 where F0101 = '" + where + "'";
            SQLiteConnection sqlcon = new SQLiteConnection(connectionString);
            SQLiteCommand sqlcmd = new SQLiteCommand();
            sqlcmd.CommandText = sqlstr;
            sqlcmd.Connection = sqlcon;
            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            return true;
        }
    }
}
