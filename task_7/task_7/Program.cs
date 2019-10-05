using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 435;
            string b = a.ToString();
            char[]ab = b.ToCharArray();
            Array.Reverse(ab);
            b = new String (ab);
            int reversed = Convert.ToInt32(b);
            Console.WriteLine(" reversed =" + reversed);
            Console.ReadKey();
        }
    }
}
