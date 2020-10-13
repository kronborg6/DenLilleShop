using System;
using System.Collections.Generic;
using System.Text;

namespace DenLilleShop
{
    public class Order
    {
        public int OrderID { get; set; }
        // var list
        public float Saldo { get; set; }
        public string payed { get; set; }
        public List<Product> items { get; set; }
        public Order()
        {

        }
        public void ByCustomerId(int CustomerId)
        {

        }
    }
}
