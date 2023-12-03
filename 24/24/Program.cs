using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[10];
            for (int i = 1; i <= name.Length; i++)
            {
                Console.Write("Enter the name{0}:", i);
                name[i] = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
