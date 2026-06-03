// Problem: Migratory Birds
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/migratory-birds/problem?isFullScreen=true


class Result16
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
    int[] freq = new int[6]; 
    foreach(int bird in arr)
    {
        freq[bird]++;
    }
    int maxCount = 0;
    int answer = 0;

    for(int i = 1; i <= 5; i++)
    {
        if(freq[i] > maxCount)
        {
            maxCount = freq[i];
            answer = i;
        }
    }
    return answer;
    }

}

class Solution18
{
    public static void MigratoryBirds(string[] args)
    {

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result16.migratoryBirds(arr);

        Console.WriteLine(result);
    }
}
