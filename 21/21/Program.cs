using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            float min, max;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nEnter hour:");
            float hour = float.Parse(Console.ReadLine());
            min = hour;
            max = hour;
            while (hour > 0)
            {
                if (hour < min)
                { min = hour; }
                if (hour > max)
                { max = hour; }
                Console.WriteLine("Enter 0 for Exit");
                Console.Write("Enter Hour: ");
                hour = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("min={0} and max={1}", min, max);
            Console.ReadKey();

        }
    }
}
