using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DenLilleShop
{
    public class Customer : Enty
    {

        public int CustomerID { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public int MobilNummer { get; set; }
        public string Email { get; set; }
        public string Vejnavn { get; set; }
        public string Husnummer { get; set; }
        public int Postnummer { get; set; }



        public Customer()
        {
        }


        public override string ToString()
        {
            return "ID: " + CustomerID + " Fornavn: " + Fornavn + " Efternavn: " + Efternavn + " Mobil: " + MobilNummer + " Email: " + Email;
        }
        public override void Valdit()
        {

        }
        /*static public List<Customer> AddToCustomer()
        {
            List<Customer> customers = new List<Customer>();
            DenLilleShopDB c = new DenLilleShopDB();
            string connString = "connDB";
            string sql = "SELECT * FROM Customer"; 

            try
            {
                c.GetData(connString, sql);
            }
            catch (SqlException exp)
            {
                Console.WriteLine("Something went wrong.");
                Console.WriteLine(exp.Message);
            }


            return customers
        }*/

    }
}
