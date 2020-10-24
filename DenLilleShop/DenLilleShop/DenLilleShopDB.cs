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
        public void AddCustomer()
        {
            CreateConnection("connDB");
            conn.Open();
            var sql = "INSERT INTO Customer(FirstName, LastName, Email, Vejnavn, Husnummer, Postnummer) VALUES(@FirstName, @LastName, @Email, @Vejnavn, @Husnummer, @Postnummer)";
            using (var cmd = new SqlCommand(sql))
            {
                cmd.Parameters.AddWithValue("@FirstName", "Tina");
                cmd.Parameters.AddWithValue("@SecondName", "Kronborg");
                cmd.Parameters.AddWithValue("@Email", "t.konborg6@gmail.com");
                cmd.Parameters.AddWithValue("@Vejnavn", "Krengerupvej");
                cmd.Parameters.AddWithValue("@Husnummer", "84");
                cmd.Parameters.AddWithValue("@Postnummer", "5690");

                //cmd.ExecuteNonQuery();
            }
        }
    }
}
