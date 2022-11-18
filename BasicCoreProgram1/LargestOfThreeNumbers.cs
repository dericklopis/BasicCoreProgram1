using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    internal class LargestOfThreeNumbers
    {
        public static void LargestNumber() 
        {
            Console.WriteLine("Enter any number: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any number: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any number: ");
            int C = Convert.ToInt32(Console.ReadLine());
            if (A > B && A > C)
            {
                Console.WriteLine("The Largest number  " +A);
            }
            else if(B > C && B > C)
            {
                Console.WriteLine("The Largest number  " +B);
            }
            else
            {
                Console.WriteLine("The Largest number  " +C);
            }
            Console.ReadLine();
        }
    }
}
