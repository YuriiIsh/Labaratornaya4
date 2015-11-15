using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_работа___4
{
    class Water
    {
        public IWater State { get; set; }

        public Water(IWater ws)
        {
            State = ws;
        }

        public void Heat()
        {
            State.Heat(this);
        }
        public void Frost()
        {
            State.Frost(this);
        }
    }
}