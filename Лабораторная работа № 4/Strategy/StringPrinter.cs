using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_работа___4
{
    class StringPrinter
    {
        public string a = "The quick brown fox jumps over the lazy dog.";
        public StringPrinter(IPrint printer)
        {
            printerx = printer;
        }
        public IPrint printerx { get; set; }
        public void Do()
        {
            Console.WriteLine(printerx.Do(a));
        }
    }
}
