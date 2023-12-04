using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2,n3;
            
            int[] num = new int[100] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100 };
            
                Console.Write("You choese the correct number(1-100):");
                num2 = int.Parse(Console.ReadLine());
                
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {

                    Console.Write("You choese the correct number(1-100):");
                    n3 = int.Parse(Console.ReadLine());
                    if (n3 > 59)
                    {
                        Console.WriteLine("number is mines");
                    }
                    if (n3 < 59)
                    {
                        Console.WriteLine("number is plus");
                    }

                    if (n3 == 59)

                        Console.WriteLine("Goooood Job");
                }
                   
            Console.ReadLine();
        }
    }
}
