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
    public abstract class bascial
    {
        public abstract DataSet show();
        public abstract bool save(DataTable dt);
        public abstract bool update();
        public abstract bool delete(string where);
        public static string connectionString = "Data Source = ./SalaryManage.db;";
    }
}
