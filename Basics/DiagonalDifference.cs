// Problem: Diagonal Difference 
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/diagonal-difference/problem?isFullScreen=true


class Result3
{
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int sum1 = 0;
        int sum2 = 0;
        for (int row = 0; row < arr.Count; row++)
        {
            sum1 += arr[row][row];
            sum2 += arr[row][arr.Count - 1 - row];
        }
        return Math.Abs(sum2 - sum1);
    }
}

class Solution5
{
    public static void Difference(string[] args)
    {

        TextWriter textWriter = Console.Out;

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result3.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
