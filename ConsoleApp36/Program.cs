using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        static void Func()
        {
            for (int x = 0; x<=4; x++)
            {
                Console.WriteLine("Привет");
            }
        }
    }
}
