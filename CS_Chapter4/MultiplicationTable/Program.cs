using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            const int limit = 10;
            x = 1;
            y = 1;
            int z = x * y;
            while (x <= limit)
            {
                Console.WriteLine("{0} * {1} = {2}.",x,y,z);
                ++x;
                z = x * y;
            }
            for (x = 1;y = 1, x <= limit; ++x) ;
        }
    }
}
