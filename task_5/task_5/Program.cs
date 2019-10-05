using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter b");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("c =" + c);
            double perimeter = a + c + b;
            Console.WriteLine("perimeter =" + perimeter);
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p*(p - a) + (p - b) + (p - c));
            Console.WriteLine("s =" + s);
            Console.ReadKey();
        }
    }
}
