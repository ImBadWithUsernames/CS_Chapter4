using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Greetings employee. Please provide your initial : ");
            string initial = Console.ReadLine().ToUpper();
            double ACom = 0, BCom = 0, ECom = 0;

            while (initial != "Z")
            {
                if (initial == "A")
                {
                    Console.Write("Greetings Andrea. How much did you sell today? : ");
                    double ASell = Convert.ToDouble(Console.ReadLine());
                    ACom = ACom + ASell * .10;
                }
                else if (initial == "B")
                {
                    Console.Write("Greetings Brittany. How much did you sell today? : ");
                    double BSell = Convert.ToDouble(Console.ReadLine());
                    BCom = BCom + BSell * .10;
                }
                else if (initial == "E")
                {
                    Console.Write("Greetings Eric. How much did you sell today? : ");
                    double ESell = Convert.ToDouble(Console.ReadLine());
                    ECom = ECom + ESell * .10;
                }
                else
                {
                    Console.WriteLine("I don't recognize that employee.");
                }

                Console.Write("Please provide another employee initial : ");
                initial = Console.ReadLine().ToUpper();


            }

            // Output each seller's commision
            Console.WriteLine("\nTotal Commission For Each Employee\n=========================================");
            Console.WriteLine("  Andrea              {0}", ACom.ToString("C"));
            Console.WriteLine("  Brittany            {0}", BCom.ToString("C"));
            Console.WriteLine("  Eric                {0}", ECom.ToString("C"));
        }
    }
}
