using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4assignmentq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for loop execuetion");
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("while loop execoetion");
            int j = 0;
            while(j<=10)
            {
                if(j%2==0)
                {
                    Console.WriteLine(j);
                }
                
                j++;
            }
            Console.WriteLine("do while loop execuetion");
            int k = 1;
            do
            {
                if (k % 2 == 1)
                {
                    Console.WriteLine(k);
                }
                k++;

            } while (k <= 10);
            Console.ReadKey();
        }
    }
}
