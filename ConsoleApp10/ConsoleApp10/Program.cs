using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(String[] args)
        {
            
            int max = 0;
            int number = Convert.ToInt32(Console.ReadLine());
            int quotient = number;
            //if (number % 2 == 1)
            //{
            //    max++;
            //}
            for (int i = 1;i<=quotient; i++)
            {
                quotient = number / 2;
                number = quotient;
            }
            Console.ReadKey();
        }


    }
}
