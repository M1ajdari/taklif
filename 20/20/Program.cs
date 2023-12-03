using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nEnter hour:");
            int hour = int.Parse(Console.ReadLine());

            int min = hour;
            while (hour > 0)
            {
                if (hour < min)
                    min = hour;
                Console.WriteLine("Enter 0 for Exit");
                Console.Write("Enter Hour: ");
                hour = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("min={0}", min);
            Console.ReadKey();

        }
    }
}
