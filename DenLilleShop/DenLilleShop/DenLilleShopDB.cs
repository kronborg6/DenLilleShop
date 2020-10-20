using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace DenLilleShop
{
    public class DenLilleShopDB
    {
        private SqlConnection conn;
        private SqlCommand sqlCommand;
        private SqlDataReader reader;
        public void CreateConnection(string connString)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[connString].ConnectionString);
            conn = sqlConnection;
        }
        public SqlInteractionn()
        {
            try
            {
                CreateConnection("connDB");
            }
            catch(SqlException exp)
            {
                throw new InvalidOperationException("Data could not be read", exp);
            }
        }
        public SqlInteraction()
        {
            CreateConnection("connDB");
        }
    }
}
