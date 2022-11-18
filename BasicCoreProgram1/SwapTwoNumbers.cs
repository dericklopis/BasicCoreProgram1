using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    internal class SwapTwoNumbers
    {
        public static void Swap()
        {
            Console.WriteLine("Enter the number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number:");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swapping the value of a is: " +a);
            Console.WriteLine("After swapping the value of b is: " +b);
            Console.ReadLine();

        }
    }
}
