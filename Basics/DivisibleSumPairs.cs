// Problem: Divisible Sum Pairs
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/divisible-sum-pairs/problem?isFullScreen=true


class Result15
{

    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int count = 0;
        for (int i = 0; i < ar.Count; i++)
        {
            for (int j = i + 1; j < ar.Count; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }

}

class Solution17
{
    public static void DivisibleSumPairs(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result15.divisibleSumPairs(n, k, ar);

        Console.WriteLine(result);
    }
}
