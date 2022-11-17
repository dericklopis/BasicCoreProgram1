using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    internal class HarmonicNumbers
    {
        public static void harmonic() 
        {
            double Harmonic=0;
            Console.WriteLine("Enter the Harmonic value n");
            int N = int.Parse(Console.ReadLine());
            for (double i = 1; i<=N; i++) 
            {
                Harmonic = Harmonic+(1/i);
            }
            Console.WriteLine("The Harmonic value is: " +Harmonic);
            Console.ReadLine();
        }

    }
}
