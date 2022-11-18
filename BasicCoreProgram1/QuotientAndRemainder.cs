using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    internal class QuotientAndRemainder
    {
        public static void QuoRem()
        {
            Console.WriteLine("Enter the dividend: ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor: ");
            int divisor = int.Parse(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient is: " +quotient);
            Console.WriteLine("Remainder is: " +remainder);
            Console.ReadLine();
        }
    }
}
