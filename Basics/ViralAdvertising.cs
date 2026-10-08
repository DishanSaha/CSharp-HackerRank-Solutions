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

class Result32
{

    /*
     * Complete the 'viralAdvertising' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int viralAdvertising(int n)
    {
        int recipients = 5;
        int totalLikes = 0;
        for (int i = 0; i < n; i++)
        {
            int likes = recipients / 2;
            totalLikes += likes;
            int recipient = likes * 3;
            recipients = recipient;
        }
        return totalLikes;
    }
}

class Solution34
{
    public static void ViralAdvertise(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result32.viralAdvertising(n);

        Console.WriteLine(result);
    }
}
