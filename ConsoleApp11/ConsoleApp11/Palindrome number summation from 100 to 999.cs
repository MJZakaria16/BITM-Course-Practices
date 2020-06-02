using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array=new int[]{10,20,30,40,50};
        int average = GetArrayAverage(array);
        int maxArray = GetMaximumOfArray(array);
        int minArray = GetMinimumOfArray(array);
        Console.WriteLine(minArray);
        Console.ReadKey();
    }

    private static int GetMinimumOfArray(int[] array)
    {
        int min = array[0];
        foreach (var VARIABLE in array)
        {
            if (min < VARIABLE)
                min = min;
            else
            {
                min = VARIABLE;
            }
        }

        return min;
    }

    private static int GetMaximumOfArray(int[] array)
    {
        int max = 0;
        foreach (var VARIABLE in array)
        {
            if (max < VARIABLE)
                max = VARIABLE;
        }

        return max;
    }

    private static int GetArrayAverage(int[] array)
    {
        int average = 0;
        foreach (var VARIABLE in array)
        {
            average += VARIABLE;
        }

        average = average / array.Length;
        return average;
    }
}

