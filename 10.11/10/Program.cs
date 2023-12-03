using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0, minutes;


            for (int i = 1; i < 31; i++)
            {
                Console.Write("please rate the day {0} enter in minutes=", i);
                minutes = int.Parse(Console.ReadLine());
                sum = sum + minutes;
            }
            Console.WriteLine("you studied for {0} hour a month", sum/60);
            Console.WriteLine("you studide average {0} hour a month",sum/30);
            Console.ReadKey();

        }
    }
}
