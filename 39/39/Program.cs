using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            string[] car =new string[4] { "pride", "pars", "samand", "sayna" };
            long[] price = {100,200,300,4000 };
            Console.Write("Enter the name of car:");
            string item=Console.ReadLine();
            for (int i = 0; i <car.Length; i++)
            
                if (item==car[i])
                {
                    found = true;
                    Console.WriteLine("{0} Found in {1}",item,i+1);
                    Console.WriteLine("the price is {0}",price[i]);
                    break;
                }
            if(!found)
                Console.WriteLine("dont found car");
            
            Console.ReadLine();
        }
    }
}
