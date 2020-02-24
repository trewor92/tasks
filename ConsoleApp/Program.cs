using System;
using System.Linq;
using HelloLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, " + (args.FirstOrDefault() ?? "not authorized user" + "!"));
            Console.WriteLine(Hello.TimeHello(args.FirstOrDefault()));
        }
    }
}
