using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a1*x+b1*y+c1*z=d1");
            Console.WriteLine("Enter a1");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b1");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c1");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter d1");
            int d1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Given a2*x+b2*y+c2*z=d2");
            Console.WriteLine("Enter a2");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b2");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c2");
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter d2");
            int d2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Given a3*x+b3*y+c3*z=d3");
            Console.WriteLine("Enter a3");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b3");
            int b3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c3");
            int c3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter d3");
            int d3 = Convert.ToInt32(Console.ReadLine());
            int delta = a1 * b2 * c3 + a3 * b1 * c2 + a2 * b3 * c1 - a3 * b2 * c1 - a1 * b3 * c2 - a2 * b1 * c3;
            if (delta != 0)
            {
                int delta_x = d1 * b2 * c3 + d3 * b1 * c2 + d2 * b3 * c1 - d3 * b2 * c1 - d1 * b3 * c2 - d2 * b1 * c3;
                int delta_y = a1 * d2 * c3 + a3 * d1 * c2 + a2 * d3 * c1 - a3 * d2 * c1 - a1 * d3 * c2 - a2 * d1 * c3;
                int delta_z = a1 * b2 * d3 + a3 * b1 * d2 + a2 * b3 * d1 - a3 * b2 * d1 - a1 * b3 * d2 - a2 * b1 * d3;
                double x = delta_x / delta;
                double y = delta_y / delta;
                double z = delta_z / delta;
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("z = " + z);
                Console.ReadKey();
            }
            else
                Console.WriteLine("ERROR");
            Console.ReadKey();
        }
    }
}
