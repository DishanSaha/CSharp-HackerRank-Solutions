// Problem: Staircase
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=true

class Result5
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {

            for (int k = 1; k <= n - i; k++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}

class Solution7
{
    public static void Staircase(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result5.staircase(n);
    }
}
