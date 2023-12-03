using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,4}", i * 1);
                Console.Write("{0,4}", i * 2);
                Console.Write("{0,4}", i * 3);
                Console.Write("{0,4}", i * 4);
                Console.Write("{0,4}", i * 5);
                Console.Write("{0,4}", i * 6);
                Console.Write("{0,4}", i * 7);
                Console.Write("{0,4}", i * 8);
                Console.Write("{0,4}", i * 9);
                Console.Write("{0,4}", i * 10);
                Console.WriteLine();
            }




            Console.ReadKey();
        }
    }
}
