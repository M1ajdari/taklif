using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 30; i++)
            {
                i++;
                Console.Write("{0,5}", i);
            }
            Console.ReadKey();
        }
    }
}
