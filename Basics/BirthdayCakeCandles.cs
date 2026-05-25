// Problem: birthdayCakeCandles
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/birthday-cake-candles/problem?isFullScreen=true


class Result7
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
     candles.Sort();
     int count =0;
     for(int i = 0; i <= candles.Count-1;i++){
       if(candles[i] == candles[candles.Count - 1]){
        count++;
       }
     }
     return count;
    }

}

class Solution9
{
    public static void BirthdayCakeCandles(string[] args)
    {

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result7.birthdayCakeCandles(candles);
        

        Console.WriteLine(result);

    }
}
