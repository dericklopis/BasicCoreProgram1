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
            Console.WriteLine("1:FlipCoin \n");
            string options = Console.ReadLine();
            switch (options)
            {
                case "1":
                    FlipCoin.Flip();
                 break;
            }
               

        }
    }
}
