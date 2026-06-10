// Problem: Get the Money Spent
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/electronics-shop/problem?isFullScreen=true

public class Solution24
{
    /*
     * Complete the getMoneySpent function below.
     */
    public static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int maxCost = -1;
        for (int i = 0; i < keyboards.Length; i++)
        {
            for (int j = 0; j < drives.Length; j++)
            {
                int total = keyboards[i] + drives[j];
                if (total <= b && total > maxCost)
                {
                    maxCost = total;
                }
            }
        }
        return maxCost;
    }

    public static void GetMoneySpent(string[] args)
    {
        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        Console.WriteLine(moneySpent);

    }
}
