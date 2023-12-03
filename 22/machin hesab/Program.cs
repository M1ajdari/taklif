using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machin_hesab
{
    class Program
    {
        static void Main(string[] args)
        {
            int select;
            float num1 = 0;
            float num2 = 0;
            Console.WriteLine("-------Console Calculator-------");
            Console.WriteLine("1. Enter A , B");
            Console.WriteLine("2. CALC A+B=");
            Console.WriteLine("3. CALC A*B=");
            Console.WriteLine("4. CALC A/B=");
            Console.WriteLine("5. CALC A-B=");
            Console.WriteLine("6. Exit ");
            Console.WriteLine("----------------------");
            Console.WriteLine("A=0       B=0");
            Console.WriteLine("----------------------");
            Console.WriteLine("Enter Number(1-6): ");
            Console.SetCursorPosition(19, 10);
            select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.SetCursorPosition(2, 8);
                num1 = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(12, 8);
                num2 = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(19, 10);
                select = int.Parse(Console.ReadLine());
            }
            if (select == 2)
            {
                Console.SetCursorPosition(13, 2);
                Console.Write(num1 + num2);
                Console.SetCursorPosition(19, 10);
                select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    Console.SetCursorPosition(13, 2);
                    Console.Write("     ");
                    Console.SetCursorPosition(2, 8);
                    Console.Write("     ");
                    Console.SetCursorPosition(12, 8);
                    Console.Write("     ");
                    Console.SetCursorPosition(2, 8);
                    num1 = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(12, 8);
                    num2 = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(19, 10);
                    select = int.Parse(Console.ReadLine());
                }
            }
            if (select == 3)
            {
                Console.SetCursorPosition(13, 3);
                Console.Write(num1 * num2);
                Console.SetCursorPosition(19, 10);
                select = int.Parse(Console.ReadLine());
            }
            if (select == 1)
            {
                Console.SetCursorPosition(13, 3);
                Console.Write("     ");
                Console.SetCursorPosition(2, 8);
                Console.Write("     ");
                Console.SetCursorPosition(12, 8);
                Console.Write("     ");
                Console.SetCursorPosition(2, 8);
                num1 = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(12, 8);
                num2 = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(19, 10);
                select = int.Parse(Console.ReadLine());
            }
            if (select == 4)
            {
                Console.SetCursorPosition(13, 4);
                Console.Write(num1 / num2);
                Console.SetCursorPosition(19, 10);
                select = int.Parse(Console.ReadLine());
            }
            if (select == 1)
            {
                Console.SetCursorPosition(13, 4);
                Console.Write("                ");
                Console.SetCursorPosition(2, 8);
                Console.Write("     ");
                Console.SetCursorPosition(12, 8);
                Console.Write("     ");
                Console.SetCursorPosition(2, 8);
                num1 = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(12, 8);
                num2 = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(19, 10);
                select = int.Parse(Console.ReadLine());
            }
            if (select == 5)
            {
                Console.SetCursorPosition(13, 5);
                Console.Write(num1 - num2);
                Console.SetCursorPosition(19, 10);
                select = int.Parse(Console.ReadLine());
            }
            if (select == 1)
            {
                Console.SetCursorPosition(13, 5);
                Console.Write("     ");
                Console.SetCursorPosition(2, 8);
                Console.Write("     ");
                Console.SetCursorPosition(12, 8);
                Console.Write("     ");
                Console.SetCursorPosition(2, 8);
                num1 = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(12, 8);
                num2 = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(19, 10);
                select = int.Parse(Console.ReadLine());
            }
            if (select == 6)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Session Ended");
            }

            Console.ReadKey();
        }
    }
}
