using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y");
            int y = Convert.ToInt32(Console.ReadLine());
            x = x + y;
            y = y - x;
            y = -y;
            x = x - y;
            Console.WriteLine("y = " + y);
            Console.WriteLine("x =" + x);
            Console.ReadKey();

        }

    }
}
