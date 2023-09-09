using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'flippingMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
     * 
     * @ide Microsoft Visual Studio 2022 Mac
     */

    public static int flippingMatrix(List<List<int>> matrix)
    {

        // Since it must be a square matrix, then the height and width should be same.
        int maximalPivotSize = matrix.Count() / 2; // An n should be divided by 2.

        int maxValueInAColumn = 0;
        int rowNumberMaxValueInAColumn = 0;

        // Search maximum value by column
        for(int i = 0; i < matrix.Count(); i++)
        {
            // Search per column
            for(int j = 0; j < matrix[i].Count(); j++)
            {
                if (matrix[i][j] < maxValueInAColumn)
                {
                    maxValueInAColumn = matrix[i][j];
                    rowNumberMaxValueInAColumn = j;
                }
            }

            if(rowNumberMaxValueInAColumn > (maximalPivotSize - 1))
            {
                matrix[i].Reverse();
            }

            maxValueInAColumn = 0;
            rowNumberMaxValueInAColumn = 0;
        }

        int result = 0;

        for(int i = 0; i < maximalPivotSize; i++)
        {
            for(int j = 0; j < maximalPivotSize; j++)
            {
                result += matrix[i][j];
            }
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = Result.flippingMatrix(matrix);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
