using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dummy1;

namespace FibConsoleFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dummy1.Fibonacci.GetDefaultSequence());
            Console.ReadLine();

        }
    }
}
