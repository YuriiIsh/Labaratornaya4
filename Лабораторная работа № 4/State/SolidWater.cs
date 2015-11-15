using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_работа___4
{
    class SolidWater : IWater //твердое состояние - лед;
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем жидкость в пар");
            water.State = new GasWater();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем жидкость в лёд");
            water.State = new SolidWater();
        }
    }
}
