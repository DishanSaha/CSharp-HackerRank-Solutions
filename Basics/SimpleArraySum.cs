// Problem: Simple Array Sum
// Platform: HackerRank
// link:https://www.hackerrank.com/challenges/simple-array-sum/problem?isFullScreen=true

class Result
{

    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> ar)
    {
        int sum = 0;
        foreach (int number in ar)
        {
            sum += number;
        }
        return sum;
    }

}
class Solution2
{
    public static void ArraySum(string[] args)
    {
        TextWriter textWriter = Console.Out;
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}