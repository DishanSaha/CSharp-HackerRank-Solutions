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

class Result28
{

    /*
     * Complete the 'designerPdfViewer' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h
     *  2. STRING word
     */

    public static int designerPdfViewer(List<int> h, string word)
    {
        int maxHeight = 0;

        for (int i = 0; i < word.Length; i++)
        {
            int letterIndex = word[i] - 'a';
            int letterHeight = h[letterIndex];

            if (letterHeight > maxHeight)
            {
                maxHeight = letterHeight;
            }
        }

        int wordWidth = word.Length;
        int area = maxHeight * wordWidth;

        return area;

    }

}

class Solution30
{
    public static void DesignerPdfViewer(string[] args)
    {

        List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

        string word = Console.ReadLine();

        int result = Result28.designerPdfViewer(h, word);

        Console.WriteLine(result);
    }
}
