using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("  ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("+ ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            while (sum < 999)
            {
                Console.WriteLine("= {0}", sum);
                Console.Write("+ ");
                sum = sum + Convert.ToInt32(Console.ReadLine());
            }
                
        }
    }
}
