using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for ( x = 0; x <= 25; x++)
            {
                for (y = 0; y <= 10; y++)
                {
                    if (2000*x+5000*y==50000)
                    {
                        Console.WriteLine("x={0}\ty={1}",x,y);
                    }
                }
                }
            Console.ReadKey();

        }
    }
}
