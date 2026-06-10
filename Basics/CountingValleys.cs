// Problem: Counting Valleys
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/counting-valleys/problem?isFullScreen=true


class Result21
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int altitude = 0;
        int valleyCount = 0;
        for (int i = 0; i < path.Length; i++)
        {
            int previousAltitude = altitude;
            if (path[i] == 'D')
            {
                altitude--;
            }
            else if (path[i] == 'U')
            {
                altitude++;
            }
            if (previousAltitude < 0 && altitude == 0)
            {
                valleyCount++;
            }
        }
        return valleyCount;

    }

}

class Solution23
{
    public static void CountingValleys(string[] args)
    {

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result21.countingValleys(steps, path);

        Console.WriteLine(result);

    }
}
