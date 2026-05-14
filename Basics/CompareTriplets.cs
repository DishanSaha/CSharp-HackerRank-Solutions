// Problem:Compare Triplets
// Platform: HackerRank
// link:https://www.hackerrank.com/challenges/compare-the-triplets/problem?isFullScreen=true

class Result1
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {

        int alice = 0;
        int bob = 0;
        for (int i = 0; i < b.Count; i++)
        {
            if (a[i] > b[i])
            {
                alice++;
            }
            if (a[i] < b[i])
            {
                bob++;
            }
        }
        return new List<int> { alice, bob };
    }

}

class Solution3
{
    public static void Triplets(string[] args)
    {
        TextWriter textWriter = Console.Out;

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result1.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
