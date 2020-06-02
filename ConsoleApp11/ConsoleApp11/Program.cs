using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numberList=new List<int>();
        int n,number, temp, remainder, reverseNumber = 0;
        int sum = 0;
        for (int i = 100; i <= 999; i++)
        {
            number = i;
            temp = number;
            n = number;
            while (n > 0)
            {
                remainder = n % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                n = n / 10;
            }

            if (temp == reverseNumber)
            {
                numberList.Add(number);
            }
            reverseNumber = 0;
        }

        foreach (var item in numberList)
        {
            sum += numberList.IndexOf(item);
        }
        Console.WriteLine("Summation of the palindrome number between 100 and 999 is {0}",sum);
        Console.ReadKey();
    }
}  
