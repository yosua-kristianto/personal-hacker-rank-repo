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

namespace LonelyInteger;
class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
        a.Sort();

        int lastNumber = -1;
        int counter = 0;

        foreach (int i in a)
        {
            // If lastNumber is -1, save it to lastNumber
            if (lastNumber == -1)
            {
                lastNumber = i;
            }
            // If the previous number is same as current, counter++ 
            else if (lastNumber == i)
            {
                counter++;
            }
            else
            {
                // If the counter is 0 and this is not the last number, break.
                if (counter == 0)
                {
                    break;
                }

                // Reset counter when the previous number is not same. 
                lastNumber = i;
                counter = 0;
            }
        }


        return lastNumber;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
