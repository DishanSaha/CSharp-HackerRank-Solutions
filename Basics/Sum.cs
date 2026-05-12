// Problem: Solve Me First
// Platform: HackerRank
// Linl: https://www.hackerrank.com/challenges/solve-me-first/problem?isFullScreen=true


class Solution
{

    static int solveMeFirst(int a, int b)
    {
        return a + b;
    }
    public static void Sum(String[] args)
    {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1, val2);
        Console.WriteLine(sum);
    }
}