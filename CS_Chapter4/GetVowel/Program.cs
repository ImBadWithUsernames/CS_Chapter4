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
            Console.Write("Please name a vowel. Type '!' to end. : ");
            String input = Console.ReadLine().ToUpper();
            while (input != "!")
            {
                input = Console.ReadLine().ToUpper();
                if (input == "E")
                    Console.WriteLine("OK");
                else if (input == "U")
                    Console.WriteLine("OK");
                else if (input == "I")
                    Console.WriteLine("OK");
                else if (input == "O")
                    Console.WriteLine("OK");
                else if (input == "A")
                    Console.WriteLine("OK");
                else
                    Console.WriteLine("ERROR");
                
                Console.Write("Please name another. : ");

            }

        }
    }
}
