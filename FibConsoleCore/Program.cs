using System;
using Dummy1;

namespace FibConsoleCore
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
