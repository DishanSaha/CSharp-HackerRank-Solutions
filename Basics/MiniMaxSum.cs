// Problem: miniMaxSum
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/mini-max-sum/problem?isFullScreen=true



class Result6
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
     arr.Sort();

     long minSum = 0;
     long maxSum = 0;

     for(int i = 0; i < 4; i++)
    {
         minSum += arr[i];
    }

     for(int i = 1; i < 5; i++)
    {
          maxSum += arr[i];
    }
     Console.Write(minSum);
     Console.Write(" ");
     Console.Write(maxSum);
    }

}

class Solution8
{
    public static void MiniMaxSum(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result6.miniMaxSum(arr);
    }
}
