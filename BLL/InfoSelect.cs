using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using BLL;

namespace BLL
{
    public class InfoSelect
    {
        public static string connectionString = "Data Source = ./SalaryManage.db;";
        public bool check(string str, string where, int number)
        {
            string sqlstr = null;
            if(str == "number")
            {
                sqlstr = "select * from T01 where F0101 = '" + number + "'";
            }
            if(str == "string")
            {
                sqlstr = "select * from T01 where F0102 = '" + where + "'";
            }
            if(str == "both")
            {
                sqlstr = "select * from T01 where F0101 = '" + number + "' and F0102 = '" + where + "'";
            }
            SQLiteConnection sqlcon = new SQLiteConnection(connectionString);
            SQLiteCommand sqlcmd = new SQLiteCommand();
            sqlcmd.CommandText = sqlstr;
            sqlcmd.Connection = sqlcon;
            sqlcon.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "table");
            sqlcon.Close();
            if (ds.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public DataSet show(string str, string where, int number)
        {
            string sqlstr = null;
            if (str == "number")
            {
                sqlstr = "select * from T02 where F0101 = '" + number + "'";
            }
            if (str == "string")
            {
                sqlstr = "select * from T02 where F0202 = '" + where + "'";
            }
            if (str == "both")
            {
                sqlstr = "select * from T02 where F0101 = '" + number + "' and F0202 = '" + where + "'";
            }
            SQLiteConnection sqlcon = new SQLiteConnection(connectionString);
            SQLiteCommand sqlcmd = new SQLiteCommand();
            sqlcmd.CommandText = sqlstr;
            sqlcmd.Connection = sqlcon;
            sqlcon.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "table");
            sqlcon.Close();
            return ds;
        }

        public bool ismatch(string str)
        {
            string regextext = @"^(-?\d+)(\.\d+)?$";
            Regex regex = new Regex(regextext, RegexOptions.None);
            return regex.IsMatch(str.Trim());
        }
    }
}
