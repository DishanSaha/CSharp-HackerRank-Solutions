// Problem: A Very Big Sum
// Platform: HackerRank
// link:https://www.hackerrank.com/challenges/a-very-big-sum/problem?isFullScreen=true

class Result2
{

    /*
     * Complete the 'aVeryBigSum' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER_ARRAY ar as parameter.
     */

    public static long aVeryBigSum(List<long> ar)
    {
        long sum = 0;
        foreach (long arraySum in ar)
        {
            sum += arraySum;
        }
        return sum;
    }

}

class Solution4
{
    public static void BigSum(string[] args)
    {
        TextWriter textWriter = Console.Out;

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = Result2.aVeryBigSum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
