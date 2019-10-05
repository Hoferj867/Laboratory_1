using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_individual_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b ");
            double b = Convert.ToDouble(Console.ReadLine());
            double e = 2.718;
            double z = a * x * Math.Sin(2 * x) + Math.Pow(e, -2 * x) * (x + b);
            if (z >= 0)
            {
                z = Math.Sqrt(z);

                double w = Math.Pow(a, 2) + Math.Pow(b, 2);
                if (w > 0)
                {
                    w = Math.Sqrt(w);
                    w = Math.Pow(Math.Cos(Math.Pow(x, 3)), 2) - x / (Math.Sqrt((a * a) + (b * b)));
                    Console.WriteLine("z = " + z);
                    Console.WriteLine("w = " + w);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("ERROR");
                    Console.ReadKey();
                }
            }
            else
                Console.WriteLine("ERROR");
            Console.ReadKey();
        }



    }
}
