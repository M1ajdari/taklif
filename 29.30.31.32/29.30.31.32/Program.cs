using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._30._31._32
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[8] { "", "saturday", "sunday", "monday", "tuesday", "wendsday", "thursday", "friday" };
            Console.Write("Enter the number one day of the week(1-7):");
            byte num = byte.Parse(Console.ReadLine());
            if ((num < 1) || (num > 7))
                Console.Write("Try Again!");
            else
                Console.WriteLine(week[num]);
            Console.ReadKey();
        }
    }
}
