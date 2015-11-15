using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_работа___4
{
    class UCPrint : IPrint
    {
        public string Do(string a)
        {
            a = a.ToUpper();
            a = a.Replace(' ', '_');
            return a;
        }
    }
}
