// Problem: Birthday
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/the-birthday-bar/problem?isFullScreen=true


class Result14
{

    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        int count = 0;
        for(int i = 0;i <= s.Count - m;i++){
        int sum = 0;
        for(int j = i; j < i + m; j++){
            sum += s[j];
        }
        if(sum == d){
        count++;
        }
       } 
     return count;
    }

}

class Solution16
{
    public static void Birthday(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result14.birthday(s, d, m);

        Console.WriteLine(result);
    }
}
