using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0, minutes;


            for (int i = 1; i < 8; i++)
            {
                Console.Write("please rate the day {0} enter in minutes=", i);
                minutes=int.Parse(Console.ReadLine());
                sum=sum+minutes;
            }
            Console.WriteLine("you studied for {0} minutes a week", sum);
            Console.ReadKey();

        }
    }
}
