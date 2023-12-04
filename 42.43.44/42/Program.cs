using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) test1");
            Console.WriteLine("(2) test2");
            Console.WriteLine("(0) exit");
            Console.Write("Select number:");
            int n1= int.Parse(Console.ReadLine());
            while (n1!=0)
            {
                if (n1 == 1)
                {


                    int[] a = { 20, 18, 10, 15, 50, 80, 10, 37 };
                    Array.Sort(a);
                    Console.Write("enter the number: ");
                    int num = int.Parse(Console.ReadLine());
                    int t = Array.BinarySearch(a, num);

                    Console.WriteLine(t);
                    foreach (var i in a)
                        Console.Write("{0,3}", i);
                    Console.WriteLine();
                    Console.WriteLine("***************************");
                    Console.WriteLine("(1) test1");
            Console.WriteLine("(2) test2");
            Console.WriteLine("(0) exit");
            Console.Write("Select number:");
             n1= int.Parse(Console.ReadLine());
                }
                else if (n1 == 2)
                {
                    Console.Write("enter your name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("hello {0}", name);
                    Console.WriteLine("(1) test1");
                    Console.WriteLine("(2) test2");
                    Console.WriteLine("(0) exit");
                    Console.Write("Select number:");
                     n1 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("(1) test1");
                    Console.WriteLine("(2) test2");
                    Console.WriteLine("(0) exit");
                    Console.Write("Select number:");
                     n1 = int.Parse(Console.ReadLine());
                }

            }

            Console.ReadLine();
        }
    }
}
