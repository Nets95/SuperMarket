using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSystem
{
    public class Check:Pokupka
    {
        public Check(string nameOfProduct, double masa, double price)
        {
            this.nameOfProduct = nameOfProduct;
            this.masa = masa;
            this.price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.Write(NameOfPrduct);
            Console.Write("  {0} грам.  ", WholeMasa);
            Console.Write("  {0} шт.  ", Quantity);
            Console.WriteLine("  {0} грн. ", Suma);
            Console.WriteLine("---------------------------------------------");
        }

         

    }
}
