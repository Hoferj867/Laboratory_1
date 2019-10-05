using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a =Convert.ToInt32(Console.ReadLine());
            if (((int)(a / 1000) < 10) && (int)(a / 1000) > 0)
            {
                int n_1 = (a / 1000);
                int n_2 = a % 1000 / 100;
                int n_3 = a % 100 / 10;
                int n_4 = a % 10;
                int amount = n_1 * n_2 * n_3 * n_4;
                Console.WriteLine("amount = " + amount);
                Console.ReadKey();
            } 
            else
                Console.WriteLine("ERROR");
                Console.ReadKey();


        }
    }
}
