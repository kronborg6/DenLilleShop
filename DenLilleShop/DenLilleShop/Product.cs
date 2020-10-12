using System;
using System.Collections.Generic;
using System.Text;

namespace DenLilleShop
{
    class Product
    {
        public Product()
        {

        }
        private int ProductID;
        public float Price;
        public string Name;
        public int Stuck;
        public int ProductId
        {
            get { return ProductID; }
            set { ProductID = ProductId; }
        }
    }
}
