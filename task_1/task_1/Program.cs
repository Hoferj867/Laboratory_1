using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            double number = Convert.ToDouble(Console.ReadLine());
            number = number * 10;
            int result = (int)number % 10;
            Console.WriteLine("Result = "+ result);
            Console.ReadKey();
        }
    }
}
