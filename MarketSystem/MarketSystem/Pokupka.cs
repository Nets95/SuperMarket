using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSystem
{
   public class Pokupka: Product
    {
        private double suma;
        private double wholeMasa;
        private int quantity;

        public double GetSuma()
        {
            return suma += Price;
        }
        public double GetWholeMasa()
        {
            return wholeMasa += Masa;
        }
        public double GetQuantity()
        {
            return quantity ++;
        }

        public double Suma {
            get {
                return suma;
            }
            set {
                 suma = value;
            }
        }

        public double WholeMasa
        {
            get
            {
                return wholeMasa;
            }
            set
            {
                wholeMasa = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public void AddToCheckCard(ref double WholeSuma)
        {
            GetSuma();
            GetQuantity();
            GetWholeMasa();
            WholeSuma += Price;
            
        }

    }
}
