// Problem: Get Total X
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/between-two-sets/problem?isFullScreen=true


class Result12
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int count = 0;

        int start = a.Max();
        int end = b.Min();

        for (int x = start; x <= end; x++)
        {
            bool ok = true;
            for (int i = 0; i < a.Count; i++)
            {
                if (x % a[i] != 0)
                {
                    ok = false;
                    break;
                }
            }
            if (ok)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    if (b[i] % x != 0)
                    {
                        ok = false;
                        break;
                    }
                }
            }

            if (ok)
            {
                count++;
            }
        }

        return count;

    }

}

class Solution14
{
    public static void GetTotalX(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result12.getTotalX(arr, brr);

        Console.WriteLine(total);
    }
}
