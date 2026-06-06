// Problem: Bon Appetit
// Platform: HackerRank
// link: 


class Result19
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    { 
        int count = 0;
      for(int i = 0; i < ar.Count;i++){
        if(ar[i] == -1 ) continue;
        for(int j = i+1; j < ar.Count;j++){
             if (ar[j] == -1) continue;
            if(ar[i] == ar[j]){
                 count++;
                 ar[j] = -1;
                 break;
            }
        }
      }
      return count;
    }

}

class Solution21
{
    public static void SockMerchant(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result19.sockMerchant(n, ar);

        Console.WriteLine(result);
    }
}
