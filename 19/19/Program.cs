using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nEnter hour:");
            int hour = int.Parse(Console.ReadLine());
            
            int max = hour;
            while (hour > 0)
            {
                if (hour > max)
                 max = hour; 
                Console.WriteLine("Enter 0 for Exit");
                Console.Write("Enter Hour: ");
                hour = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("max={0}", max);
            Console.ReadKey();

        }
    }
}
