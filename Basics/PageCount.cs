// Problem: Page Count
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/drawing-book/problem?isFullScreen=true


class Result20
{

    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int pageCount(int n, int p)
    {
    int front = p / 2;
    int back = n / 2 - p / 2;

    return Math.Min(front, back);
    }

}

class Solution22
{
    public static void PageCount(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result20.pageCount(n, p);
 
        Console.WriteLine(result);

    }
}
