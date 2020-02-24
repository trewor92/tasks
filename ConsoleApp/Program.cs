using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, " + (args.FirstOrDefault() ?? "not authorized user" + "!"));
        }
    }
}
