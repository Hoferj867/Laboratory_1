using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter x");
            int x = Convert.ToInt32(Console.ReadLine());
            int a = (int)Math.Pow(x, 4);
            int b = (int)Math.Pow(x, 3);
            int c = (int)Math.Pow(x, 2);
            int result = 3 * a - 5 * b + 2 * c - x + 7;
            Console.WriteLine("resilt = " + result);
            Console.ReadKey();

        }
    }
}
