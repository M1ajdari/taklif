using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0, avg;
            int count = 0;
            Console.Write("Enter num{0}=",count+1);
            float num = float.Parse(Console.ReadLine());
            while (num>=0)
            {
                sum = sum + num;
                count++;
                Console.Write("Enter num {0}=",count+1);
                num = float.Parse(Console.ReadLine());
            }
            avg = sum / count;
            Console.WriteLine(avg);
            Console.ReadKey();
        }
    }
}
