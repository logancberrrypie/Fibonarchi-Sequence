using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fib(10));
            Console.ReadLine();
        }

        static int fib(int max)
        {
            if (max == 0)
            {
                return 0;        
            }
            else if (max == 1)
            {
                return 1;
        
            }
            else
            {
                return fib(max - 1) + fib(max - 2);   
            }
        }


    }
}
