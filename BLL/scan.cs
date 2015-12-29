using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Model;

namespace BLL
{
    public class Scan : bascial
    {
        public override DataSet show()
        {
            T01 t01 = new T01();
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
            //throw new NotImplementedException();
        }
    }
}
