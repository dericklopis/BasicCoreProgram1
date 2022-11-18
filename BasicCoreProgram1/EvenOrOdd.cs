using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    internal class EvenOrOdd
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter any number: ");
            int N=Convert.ToInt32(Console.ReadLine());
            if (N % 2== 0)
            {
                Console.WriteLine(" + is a Even number");
            }
            else
            { 
                Console.WriteLine(" + is a Odd number");
            }
            Console.ReadLine(); 
        }
    }
}
