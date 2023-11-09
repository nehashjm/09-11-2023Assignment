using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4assignmentq3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a=0, b=1, c, i;
            Console.WriteLine("enter the size");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (i <= 1)
                {
                    c = i;
                }
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine(c+"");
            }
            Console.ReadKey();
        }
    }
}
