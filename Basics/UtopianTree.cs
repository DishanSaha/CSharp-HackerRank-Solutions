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

class Result29
{

    /*
     * Complete the 'utopianTree' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int utopianTree(int n)
    {
int height = 1;

for (int cycle = 1; cycle <= n; cycle++)
{
    if (cycle % 2 != 0)
    {
        int newHeight = height * 2;
        height = newHeight;
    }
    else
    {
        int newHeight = height + 1;
        height = newHeight;
    }
}

return height;
    }

}

class Solution31
{
    public static void UtopianTree(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result29.utopianTree(n);

            Console.WriteLine(result);
        }
    }
}
