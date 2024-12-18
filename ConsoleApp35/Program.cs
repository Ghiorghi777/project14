using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Input("n=");
            Func(n);
            Console.ReadKey();
        }
        static int Input (string mes)
        {
            Console.Write(mes);
            return int.Parse(Console.ReadLine());
        }
        static void Func(int n)
        {
            int x = 1;
            while (x <= n)
            {
                Console.WriteLine(x);
                x++;
            }
            
        }
    }
}
