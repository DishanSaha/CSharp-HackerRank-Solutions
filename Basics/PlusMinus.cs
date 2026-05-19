// Problem: PlusMinus
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/plus-minus/problem?isFullScreen=true



class Result4
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static decimal[] plusMinus(List<int> arr)
    {
        decimal positive = 0;
        decimal negative = 0;
        decimal zero = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
            {
                positive++;
            }
            else if (arr[i] < 0)
            {
                negative++;
            }
            else if (arr[i] == 0)
            {
                zero++;
            }
        }
        positive = positive / arr.Count;
        negative = negative / arr.Count;
        zero = zero / arr.Count;
        return new decimal[] { positive, negative, zero };
    }

}

class Solution6
{
    public static void PlusMinus(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result4.plusMinus(arr);
        decimal[] result = Result4.plusMinus(arr);

        foreach (decimal num in result)
        {
            Console.WriteLine(num.ToString("F6"));
        }
    }
}
