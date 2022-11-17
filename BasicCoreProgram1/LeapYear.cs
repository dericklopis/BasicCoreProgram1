using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    internal class LeapYear
    {
        public static void Leap()
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (Year >= 1000 && Year <= 9999)
            {
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                    Console.WriteLine("{0} is a Leap Year.", Year);
                else
                    Console.WriteLine("{0} is not a Leap Year.", Year);
            }
            else
            {
                Console.WriteLine("Enter 4 digit no.");
            }
            Console.ReadLine();
        }        
    }
}
