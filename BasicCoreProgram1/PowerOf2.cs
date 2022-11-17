using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    internal class PowerOf2
    {
        public static void power()
        {
            Console.WriteLine("Enter the Power of value n ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i<=N; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine("2^{0} = {1}", i, result);
            }
            Console.ReadLine();
        }
    }
}
