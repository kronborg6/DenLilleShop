using System;
using System.Collections.Generic;
using System.Text;

namespace DenLilleShop
{
    public class Product
    {

        private int ProductID { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public int Stuck { get; set; }
        public int ProductId
        {
            get { return ProductID; }
            set { ProductID = ProductId; }
        }
        public Product(int id, float ItemPrice, string ItemName)
        {
            ProductId = id;
            Price = ItemPrice;
            Name = ItemName;
            //Stuck = HowMany;
        }
        public Product()
        {

        }
    }
}
