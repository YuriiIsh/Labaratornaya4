using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа___4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringPrinter rousey = new StringPrinter(new NCPrint());
            rousey.Do();
            Console.ReadLine(); // Strategy
            Water water = new Water(new LiquidWater()); //State
            water.Heat();
            water.Heat();
            water.Frost();
            water.Frost();
            Console.ReadLine();
        }
    }
}
