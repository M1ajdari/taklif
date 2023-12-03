using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int student = 10, num;
            for ( num = 1; num <=5; num++)
            {
                Console.WriteLine("{0}_{1}",num,student);
                student--;
            }
            Console.ReadLine();
        }
    }
}
