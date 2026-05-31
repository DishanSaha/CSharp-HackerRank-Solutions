// Problem: Count Apples and Oranges
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true


class Result10
{

    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {   
       int countA = 0;
       foreach(int apple in apples){
         int positionA = a + apple;
         if(positionA >= s && positionA <= t){
            countA++;
        } 
      }
      Console.WriteLine(countA);  
      int countB = 0;
      foreach(int orange in oranges){
         int positionB = b + orange; 
         
         if(positionB >= s && positionB <= t){
            countB++;
         }
      }
      Console.WriteLine(countB);  
    }

}

class Solution12
{
    public static void CountApplesAndOranges(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result10.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}

