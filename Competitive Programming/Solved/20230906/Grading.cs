/**
 * Did in Microsoft Visual Studio 2022 for Mac
 * 
 * Sorry if the tab indentation messing things up.
 */
namespace Grading
{
    class Result
    {

        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         * 
         * So basically, this problem is to round up students grade whatever the grade is ((closest multiple by 5 number) - grade) < 3.
         * But this rule is only apply if the score is above 38 since 40 is a consider as failing.
         * 
         * Example:
         * if grade is 84, then you should round it up to 85 since (85 - 84) < 3
         * If grade is 29, then you should not round it up since the number is below 38.
         * If grade is 57, then you should not round it up to 60 since (60 - 57) = 3
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                // If grade is less than 38, skip this loop
                if (grades[i] < 38) { continue; }

                // Make a 5 multiplication started from f(8) = 40 to f(20) = 100
                for (int j = 8; j < 21; j++)
                {
                    // Find the most closest positive integer to zero for the e, and round up the value.
                    if (((5 * j) - grades[i]) < 3 && ((5 * j) - grades[i]) > 0)
                    {
                        grades[i] = (5 * j);
                    }
                }
            }

            return grades;
        }

    }

    class Solution
    {
        public static void Gradings(string[] args)
        {
            // Comment this to run in local
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            // Comment this to run in local
            textWriter.WriteLine(String.Join("\n", result));
            textWriter.Flush();
            textWriter.Close();
        }
    }

}