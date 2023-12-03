using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int end;
            Console.Write("yek adad vared konid:");
            end = int.Parse(Console.ReadLine());
            for (int i = 1; i <=end; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
