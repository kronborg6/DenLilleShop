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
        public void GetData(string connString, string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[connString].ConnectionString);
            conn = sqlConnection;
            SqlCommand cmd = new SqlCommand(sql);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
        }
        public void SqlInteractionn()
        {
            CreateConnection("connDB");
            SqlCommand cmd = new SqlCommand("SELECT CustomerID, FirstName, LastName, Email, Vejnavn, Husnummer, Postnummer FROM Customer");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            List<Customer> customers = new List<Customer>();
            using (SqlDataReader sdr = cmd.ExecuteReader()) 
            {
                while (sdr.Read())  
                {
                    customers.Add(new Customer
                    {
                        CustomerID = Convert.ToInt32(sdr["CustomerID"]),
                        Fornavn = sdr["FirstName"].ToString(),
                        Efternavn = sdr["LastName"].ToString(),
                        MobilNummer = Convert.ToInt32(sdr["Telfon"]),
                        Email = sdr["Email"].ToString(),
                        Vejnavn = sdr["Vejnavn"].ToString(),
                        Husnummer = sdr["Husnummer"].ToString(),
                        Postnummer = Convert.ToInt32(sdr["Postnummer"])

                    });
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
                List<Customer> customers = new List<Customer>();
                string connString = "connDB";
                string sql = "SELECT * FROM Customer";

                try
                {

                }
                catch (SqlException exp)
                {
                    Console.WriteLine("Something went wrong.");
                    Console.WriteLine(exp.Message);
                }


                return customers
                //cmd.ExecuteNonQuery();
            }
        }
        public void AddTo()
        {
            CreateConnection("connDB");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer");
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
