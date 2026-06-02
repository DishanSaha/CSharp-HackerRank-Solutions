// Problem: Breaking Records
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem?isFullScreen=true


class Result13
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        int countHiggest = 0;
        int countLowest = 0;
        int maxSoFar = scores[0];
        int minSoFar = scores[0];
        for (int i = 0; i < scores.Count; i++)
        {
            if (scores[i] > maxSoFar)
            {
                maxSoFar = scores[i];
                countHiggest++;
            }
        }
        for (int j = 0; j < scores.Count; j++)
        {
            if (scores[j] < minSoFar)
            {
                minSoFar = scores[j];
                countLowest++;
            }
        }
        return new List<int> { countHiggest, countLowest };
    }

}

class Solution15
{
    public static void BreakingRecords(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result13.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));
    }
}
