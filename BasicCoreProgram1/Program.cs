﻿using System;
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
            Console.WriteLine("1:FlipCoin \n2:LeapYear \n3:PowerOf2 \n4:HarmonicNumbers \n5:Factors \n6:QuotientAndRemainder");
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
                default:
                    Console.WriteLine("Choose from above options only");
                    Console.ReadLine();
                    break;
           }

        }
    }
}
