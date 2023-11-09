using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4assignmentq5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examscore;
            
            Console.WriteLine("enter student percentage ");
            examscore = int.Parse(Console.ReadLine());
            if(examscore >= 90)
            {
                Console.WriteLine("student has got A grade");
            }
            else if(examscore >80 &&  examscore <= 89)
            {
                Console.WriteLine("student has got B grade");
            }
            else if (examscore > 70 && examscore <= 79)
            {
                Console.WriteLine("student has got C grade");
            }
            else if (examscore > 60 && examscore <= 69)
            {
                Console.WriteLine("student has got D grade");
            }
            else
            { Console.WriteLine("student has got f grade");
            }
            Console.ReadKey();
        }
    }
}
