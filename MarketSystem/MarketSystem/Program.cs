using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double Suma = 0;
            Console.Write("NameOfProduct     Masa      Quantity    Price ");
            Console.WriteLine();  
            Console.WriteLine("---------------------------------------------");
            Check prod_1 = new Check("Печиво 'Марiя'", 300 , 12);
            prod_1.AddToCheckCard(ref Suma);
            prod_1.AddToCheckCard(ref Suma);
            prod_1.ShowInfo();
            prod_1 = new Check("Снiкерс       ", 200, 22);
            prod_1.AddToCheckCard(ref Suma);
            prod_1.AddToCheckCard(ref Suma);
            prod_1.ShowInfo();
            prod_1 = new Check("Яблука        ", 1000, 14);
            prod_1.AddToCheckCard(ref Suma);
            prod_1.ShowInfo();

            Console.WriteLine("Загальна сума:                        {0}грн", Suma);
            Console.ReadLine();
        }
    }
}
