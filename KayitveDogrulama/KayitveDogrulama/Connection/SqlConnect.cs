using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KayitveDogrulama.Connection
{
    public class SqlConnect
    {
        public SqlConnection Connection()
        {
            SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=KayitveDogrulamaDB;Integrated Security=True;");
            sql.Open();
            return sql;
        }
    }
}