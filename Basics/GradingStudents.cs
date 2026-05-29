// Problem: timeConversion
// Platform: HackerRank
// link:


class Result9
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] >= 38)
            {
                int multiple = ((grades[i] / 5) + 1) * 5;
                if (multiple - grades[i] < 3)
                {
                    grades[i] = multiple;
                }
            }
        }
        return grades;
    }

}

class Solution11
{
    public static void GradingStudents(string[] args)
    {


        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result9.gradingStudents(grades);
        Console.WriteLine(String.Join("\n", result));
    }
}
