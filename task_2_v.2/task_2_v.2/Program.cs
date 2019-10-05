using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_v._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many seconds are gone?");
            int seconds = Convert.ToInt32((Console.ReadLine()));
            int hours = (int)(seconds / 3600);
            int minutes = (int)(seconds / 60);
            while (minutes > 60)            
            minutes = minutes - 60;
            Console.WriteLine("Time are gone: " + hours + " hours " + minutes + " minutes");
            Console.ReadKey();
        }
    }
}
