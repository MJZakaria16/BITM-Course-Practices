using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber;
            firstNumber = Convert.ToDouble(Console.ReadLine());
            secondNumber = Convert.ToDouble(Console.ReadLine());
            thirdNumber = Convert.ToDouble(Console.ReadLine());
            fourthNumber = Convert.ToDouble(Console.ReadLine());
            fifthNumber = Convert.ToDouble(Console.ReadLine());
            double average = GetAverage(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
            Console.WriteLine("Average is {0}",average);
            Console.ReadKey();
        }

        static double GetAverage(double firstNumber, double secondNumber, double thirdNumber, double fourthNumber, double fifthNumber)
        {
            double average = (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber) / 5;
            return average;
        }
    }
}
