using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    class Program
    {
        static void Main(string[] args)
        {
            string myster;
            Console.Write("enter the name:");
            myster = Console.ReadLine();
            foreach (char a in myster)
            {
                Console.WriteLine(a);
                
            }
            Console.ReadLine();
        }
    }
}
