using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] computer = new string[5]{"dvd","hdmi","cpu","mbd","ram"} ;
            int[] price = new int[computer.Length];
            for (int i = 0; i <= price.Length; i++)
            {

                Console.Write("Please the enter {0} of money :", computer[i]);
                 
                price[i] = int.Parse(Console.ReadLine());
            }
                            int sum = 0;
                            for (int i = 0; i < computer.Length; i++)
                            {
                                sum=sum + price[i];
                            }
                            Console.WriteLine("the money of buy:{0}",sum);
                            Console.ReadLine();
        }
    }
}
