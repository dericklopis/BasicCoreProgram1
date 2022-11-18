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
            Console.WriteLine("1:FlipCoin \n2:LeapYear \n3:PowerOf2 \n4:HarmonicNumbers \n5:Factors \n6:QuotientAndRemainder \n7:SwapTwoNumbers \n8:EvenOrOdd  \n9:VowelsOrConsonant");
            string options = Console.ReadLine();
           switch (options)
           {
                case "1":
                    FlipCoin.Flip();
                    break;
                case "2":
                    LeapYear.Leap();
                    break;
                case "3":
                    PowerOf2.power();
                    break;
                case "4":
                    HarmonicNumbers.harmonic();
                    break;
                case "5":
                    Factors.Prime();
                    break;
                case "6":
                    QuotientAndRemainder.QuoRem();
                    break;
                case "7":
                    SwapTwoNumbers.Swap();
                    break;
                case "8":
                    EvenOrOdd.EvenOdd();
                    break;
                case "9":
                    VowelOrConsonant.Vowels();
                    break;
                default:
                    Console.WriteLine("Choose from above options only");
                    Console.ReadLine();
                    break;
           }

        }
    }
}
