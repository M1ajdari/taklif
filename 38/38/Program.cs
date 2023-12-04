using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] price=new int[3]{1,2,3};
            for ( i = 0; i < price.Length; i++)
            {
                Console.Write("Enter the price of {0} the product:",i+1);
                int temp = int.Parse(Console.ReadLine());
                if (temp>0)
                
                     price[i] = temp;
                    else
	
                    break;
	
                
            }
            Console.WriteLine("product price plus mall:");
            for (int j = 0; j < i; j++)
            {
                price[j] = (int)(price[j] + 0.09 * price[j]);
                Console.WriteLine("product {0}: {1}",j+1,price[j]);
            }
            Console.ReadLine();
        }
    }
}
