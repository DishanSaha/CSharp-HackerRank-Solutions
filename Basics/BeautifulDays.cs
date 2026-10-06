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

class Result31
{

    /*
     * Complete the 'beautifulDays' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER i
     *  2. INTEGER j
     *  3. INTEGER k
     */

    public static int beautifulDays(int i, int j, int k)
    {
        int beautifulDay = 0;
        for (int day = i; day <= j; day++)
        {
            int reverse = 0;
            int number = day;
            while (number > 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number = number / 10;
            }
            if (Math.Abs(day - reverse) % k == 0)
            {
                beautifulDay++;
            }

        }
        return beautifulDay;
    }

}

class Solution33
{
    public static void BeautifulDay(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        int result = Result31.beautifulDays(i, j, k);

        Console.WriteLine(result);
    }
}
