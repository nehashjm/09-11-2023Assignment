using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4assignmentq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[5];
            int total = 0;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {

                    
                Console.WriteLine("enter the values");
                values[i] = int.Parse(Console.ReadLine());     
                 total += values[i];
                sum = total / 5;
            }
            foreach(int i in values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("sum is " + total + "average is " + sum);
            Console.ReadKey();
        }
    }
}
