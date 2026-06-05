// Problem: Day of the Programmer
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/day-of-the-programmer/problem?isFullScreen=true


class Result17
{

    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
      if(year == 1918){
        return $"26.09.{year}";
      }
      else if(year < 1918){
        if(year % 4 ==0){
            return $"12.09.{year}";
        }
        else{
            return $"13.09.{year}";
        }
      }
      else{
        if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)){
            return $"12.09.{year}";
        }
        else{
             return $"13.09.{year}";
        }
      }
    }

}

class Solution19
{
    public static void DayOfProgrammer(string[] args)
    {

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result17.dayOfProgrammer(year);

        Console.WriteLine(result);

    }
}
