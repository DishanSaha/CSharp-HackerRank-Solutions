// Problem: timeConversion
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/time-conversion/problem?isFullScreen=true


class Result8
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        DateTime time = DateTime.Parse(s);
        return time.ToString("HH:mm:ss");
    }

}

class Solution10
{
    public static void TimeConversion(string[] args)
    {

        string s = Console.ReadLine();

        string result = Result8.timeConversion(s);

        Console.WriteLine(result);
    }
}

