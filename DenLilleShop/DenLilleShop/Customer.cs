using System;
using System.Collections.Generic;
using System.Text;

namespace DenLilleShop
{
    public class Customer
    {

        public int CustomerID { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public int MobilNummer { get; set; }
        public string Email { get; set; }
        public Customer(int ID, string Fname, string Ename, int MobilN, string Em)
        {
            CustomerID = ID;
            Fornavn = Fname;
            Efternavn = Ename;
            MobilNummer = MobilN;
            Email = Em;
        }

        public Customer()
        {
        }

        public override string ToString()
        {
            return "ID: " + CustomerID + " Fornavn: " + Fornavn + " Efternavn: " + Efternavn + " Mobil: " + MobilNummer + " Email: " + Email;
        }
    }
}
