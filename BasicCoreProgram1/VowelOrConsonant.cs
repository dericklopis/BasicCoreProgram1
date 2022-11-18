using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram1
{
    internal class VowelOrConsonant
    {
        public static void Vowels() 
        {
            Console.WriteLine("Enter any Alphabet");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch) 
            {
                case 'a':
                    Console.WriteLine("The Alphabet is Vowel");
                break;
                case 'e':
                    Console.WriteLine("The Alphabet is Vowel");
                break;
                case 'i':
                    Console.WriteLine("The Alphabet is Vowel");
                break;
                case 'o':
                    Console.WriteLine("The Alphabet is Vowel");
                break;
                case 'u':
                    Console.WriteLine("The Alphabet is Vowel");
                break;
                default:
                    Console.WriteLine("The Alphabet is a Consonant");
                break;
            }
            Console.ReadLine();
        }
    }
}
