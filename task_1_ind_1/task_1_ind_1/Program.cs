using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_ind_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new string('_', 35);
            Console.WriteLine( "Enter surname" );
            string surname = Console.ReadLine();
            Console.WriteLine("Enter position");
            string position = Console.ReadLine();
            Console.WriteLine("Enter year ");
            string year = Console.ReadLine();
            Console.WriteLine("Enter salary");
            string salary = Console.ReadLine();
            Console.WriteLine("Enter surname 2");
            string surname2 = Console.ReadLine();
            Console.WriteLine("Enter position 2");
            string position2 = Console.ReadLine();
            Console.WriteLine("Enter year 2 ");
            string year2 = Console.ReadLine();
            Console.WriteLine("Enter salary 2");
            string salary2 = Console.ReadLine();
            Console.WriteLine("Enter surname 3");
            string surname3 = Console.ReadLine();
            Console.WriteLine("Enter position 3");
            string position3 = Console.ReadLine();
            Console.WriteLine("Enter year 3 ");
            string year3 = Console.ReadLine();
            Console.WriteLine("Enter salary 3");
            string salary3 = Console.ReadLine();
            Console.WriteLine(a + "\n" + "Human Resources Deportive\n"+a+"\n" + "surname" + " |  "+"position"+"|"+" year "+"|"+"salary"+"|\n"+a+"\n" );
            Console.WriteLine(  surname  + "|"  + position +   " |  " + year + "|" + salary  + "|\n" + a);
            Console.WriteLine(surname2 + "|" + position2 + " |  " + year2 + "|" + salary2 + "|\n" + a);
            Console.WriteLine(surname3 + "|" + position3 + " |  " + year3 + "|" + salary3 + "|\n" + a);
            Console.ReadKey();
        }
    }
}
