// Problem: Kangaroo
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/kangaroo/problem?isFullScreen=true


class Result11
{

    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
  
     if(x1 < x2 && v1 > v2){
        if((x2 - x1) % (v1 - v2) == 0){
        return "YES";
        }
        else{
        return "NO";
        }
     }
     else{
        return "NO";
     }
    }

}

class Solution13
{
    public static void Kangaroo(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result11.kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
    }
}
