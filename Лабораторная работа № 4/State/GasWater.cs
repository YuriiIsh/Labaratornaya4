using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_работа___4
{
    class GasWater : IWater  //газообразное состояние - пар.
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Повышение температуры пара");
            water.State = new GasWater();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем пар в жидкость");
            water.State = new SolidWater();
        }
    }
}
