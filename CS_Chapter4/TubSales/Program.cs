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
            Console.Write("Greetings employee. Please provide your inital. : ");
            string initial = Console.ReadLine().ToUpper();
            while (initial != "Z")
            {
                if (initial == "A")
                {
                    Console.WriteLine("Greetings Andrea.");
                    Console.Write("How much did you sell today? : ");
                    double ASell = Convert.ToDouble(Console.ReadLine());
                    double ACom = ASell * .10;
                }
                else if (initial == "B")
                {
                    Console.WriteLine("Greetings Brittany.");
                    Console.Write("How much did you sell today? : ");
                    double BSell = Convert.ToDouble(Console.ReadLine());
                    double BCom = BSell * .10;
                }
                else if (initial == "E")
                {
                    Console.WriteLine("Greetings Eric.");
                    Console.Write("How much did you sell today? : ");
                    double ESell = Convert.ToDouble(Console.ReadLine());
                    double ECom = ESell * .10;
                }
                else Console.Write("ERROR EMPLOYEE NOT FOUND")
            Console.WriteLine("Andrea's total commission is {0}.", ACom);
            }
        }
    }
}
