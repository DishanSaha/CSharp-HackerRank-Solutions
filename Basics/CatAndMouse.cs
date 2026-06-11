// Problem: Cat and Mouse
// Platform: HackerRank
// link: https://www.hackerrank.com/challenges/cats-and-a-mouse/problem?isFullScreen=true


class Solution25
{
    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z)
    {
        int cata = Math.Abs(x - z);
        int catb = Math.Abs(y - z);
        if (cata > catb)
        {
            return "Cat B";
        }
        else if (catb > cata)
        {
            return "Cat A";
        }
        else
        {
            return "Mouse C";
        }

    }

    public static void CatAndMouse(string[] args)
    {

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            Console.WriteLine(result);
        }
    }
}
