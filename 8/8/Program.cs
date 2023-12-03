using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 30; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine("hop");
                else
                    Console.WriteLine(i);
            }

            
            Console.ReadKey();
        }
    }
}
