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
        public void SqlInteractionn()
        {
            CreateConnection("connDB");
            SqlCommand cmd = new SqlCommand("SELECT CustomerID, FirstName, LastName, Email, Vejnavn, Husnummer, Postnummer FROM Customer");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            using (SqlDataReader sdr = cmd.ExecuteReader()) 
            {
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["CustomerID"].ToString());
                    Console.WriteLine(sdr["FirstName"].ToString());
                    Console.WriteLine(sdr["LastName"].ToString());
                    Console.WriteLine(sdr["Email"].ToString());
                    Console.WriteLine(sdr["Vejnavn"].ToString());
                    Console.WriteLine(sdr["Husnummer"].ToString());
                    Console.WriteLine(sdr["Postnummer"].ToString());
                }
                conn.Close();
            }

        }
    }
}
