// Problem: Bon Appetit
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/bon-appetit/problem?isFullScreen=true


class Result18
{

    /*
     * Complete the 'bonAppetit' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY bill
     *  2. INTEGER k
     *  3. INTEGER b
     */

    public static void bonAppetit(List<int> bill, int k, int b)
    {
        int sum = 0;
        for (int i = 0; i < bill.Count; i++)
        {
            sum += bill[i];
        }
        int actualShare = (sum - bill[k]) / 2;
        if (actualShare < b)
        {
            int refund = b - actualShare;
            Console.WriteLine(refund);
        }
        else
        {
            Console.WriteLine("Bon Appetit");
        }
    }

}

class Solution20
{
    public static void BonAppetit(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        Result18.bonAppetit(bill, k, b);

    }
}
