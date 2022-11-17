using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    internal class Factors
    {
        public static void Prime()
        {
            Console.WriteLine("Enter Number to find the prime factors");
            int N = int.Parse(Console.ReadLine());
            for (int i=2;i<=N;i++)
            {
                while (N%i==0) 
                {
                    Console.WriteLine("The prime factor of the number {0} is: {1}" ,N,i);
                    N=N/i;
                }
                Console.ReadLine(); 
            }
        }
    }
}
