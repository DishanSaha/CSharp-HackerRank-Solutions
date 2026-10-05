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

class Result30
{

    /*
     * Complete the 'angryProfessor' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY a
     */

    public static string angryProfessor(int k, List<int> a)
    {

        string msg = "YES";
        int count = 0;
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] <= 0)
            {
                count++;
                if (count == k)
                {
                    break;
                }
            }
        }
        if (count == k)
        {
            msg = "NO";
        }
        return msg;
    }

}

class Solution32
{
    public static void AngryProfessor(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            string result = Result30.angryProfessor(k, a);
            Console.WriteLine(result);

        }

    }
}
