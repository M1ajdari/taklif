using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int month, guess, score = 5;
            Console.Write(" Enter number your month:");
            month = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <=5; i++)
            {
                Console.Write("Your guess?");
                guess = int.Parse(Console.ReadLine());
                if (guess==month)
                {
                   // Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You Win");
                    Console.WriteLine("Your score {0}",score);
                    break;
                }
                    
                else
                {
                    
                    score -= 1;
                    Console.WriteLine("try again!");
                    
                }
            }
        }
    }
}
