using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum1 = 0, sum2 = 0, sum3 = 0;
            for (int i = 0; i <= 100; i++)
            {
                int j = i * i;
                sum1 += j;
                sum2 += i;
                sum3 = sum2*sum2;
            }
            sum = sum3 - sum1;
            Console.WriteLine("The difference between the sum of " +
                              "the squares of the first hundred natural numbers and " +
                              "the square of the sum is {0} − {1} = {2}.", sum3, sum1, sum);
            Console.ReadKey();
            }
    }
}
