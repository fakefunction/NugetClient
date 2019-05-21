using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(CalculatorLib.Lib.SomeLib.Add(3, 5));
           Console.ReadKey();
        }
    }
}
