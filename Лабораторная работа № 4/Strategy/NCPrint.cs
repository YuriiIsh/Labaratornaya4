using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_работа___4
{ 
    class NCPrint:IPrint 
    {
        public string Do(string a)
        {
            a = a.ToLower().Replace(' ', '_');
            return a;
        }
    }
}
