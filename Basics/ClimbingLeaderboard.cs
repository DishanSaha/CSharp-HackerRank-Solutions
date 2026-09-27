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

class Result26
{

    /*
     * Complete the 'climbingLeaderboard' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */

    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        List<int> uniqueValues = new List<int>();

        // Duplicate remove
        foreach (int score in ranked)
        {
            if (uniqueValues.Count == 0 || uniqueValues[uniqueValues.Count - 1] != score)
            {
                uniqueValues.Add(score);
            }
        }

        List<int> result = new List<int>();

        foreach (int score in player)
        {
            int left = 0;
            int right = uniqueValues.Count - 1;
            int rank = uniqueValues.Count + 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (score >= uniqueValues[mid])
                {
                    rank = mid + 1;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            result.Add(rank);
        }

        return result;
    }



}

class Solution28
{
    public static void CLimbLeaderBoard(string[] args)
    {

        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        List<int> result = Result26.climbingLeaderboard(ranked, player);

        Console.WriteLine(string.Join("\n", result));
    }
}
