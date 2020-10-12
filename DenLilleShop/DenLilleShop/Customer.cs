using System;
using System.Collections.Generic;
using System.Text;

namespace DenLilleShop
{
    class Customer
    {

        private int CustomerID;
        public string Fornavn;
        public string Efternavn;
        public int MobilNummer;
        public string Email;

        public int CustomerId 
        { 
            get { return CustomerID; }
            set { CustomerID = CustomerId; }
        }
        public Customer(int ID, string Fname, string Ename, int MobilN, string Em)
        {
            CustomerId = ID;
            Fornavn = Fname;
            Efternavn = Ename;
            MobilNummer = MobilN;
            Email = Em;
        }
    }
}
