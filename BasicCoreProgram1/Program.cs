using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose one program from below options");
            Console.WriteLine("1:FlipCoin \n2:LeapYear");
            string options = Console.ReadLine();
            switch (options)
            {
                case "1":
                    FlipCoin.Flip();
                    break;
                case "2":
                    LeapYear.Leap();
                    break;
                default:
                    Console.WriteLine("Choose from above options only");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
