using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            int firstNumber;
            int lastNumber;
            Console.WriteLine("Enter Upper limit and lower limit");
            lastNumber = Convert.ToInt32(Console.ReadLine());
            firstNumber = Convert.ToInt32(Console.ReadLine());
            for (int i=firstNumber; i <= lastNumber; i++)
            {
                Console.WriteLine(i);

            }

            Console.ReadKey();

        }
    }
}
