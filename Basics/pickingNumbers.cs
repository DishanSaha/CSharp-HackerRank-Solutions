using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result25
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        int[] count = new int[101];
        foreach (int number in a)
        {
            count[number]++;
        }
        int max = 0;
        for (int i = 0; i < 100; i++)
        {
            int current = count[i + 1] + count[i];
            max = Math.Max(max, current);
        }
        return max;
    }
}
class Solution27
{
    public static void PickNumbers(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result25.pickingNumbers(a);
        Console.WriteLine(result);

    }
}
