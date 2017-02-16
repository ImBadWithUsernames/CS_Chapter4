using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please name a vowel in caps. Type '!' to end.");
            String input = Console.ReadLine().ToUpper();
            while (input != "!")
            {
                while (input == "E" || "U" || "I" || "O" || "A")
                    Console.WriteLine("OK");
                Console.WriteLine("ERROR");
            }

        }
    }
}
