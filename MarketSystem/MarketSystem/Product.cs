using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSystem
{
    public class Product
    {
        protected string nameOfProduct;
        protected double price;
        protected double masa;

        public string NameOfPrduct {
            get {
                return nameOfProduct;
            }
            set {
                nameOfProduct = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public double Masa
        {
            get
            {
                return masa;
            }
            set
            {
                masa = value;
            }
        }


    }
}
