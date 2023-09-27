namespace MarsExploration
{
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
         * Complete the 'marsExploration' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING s as parameter.
         */

        public static int marsExploration(string s)
        {
            int differenceFlag = 0;

            for (int i = 0; i < s.Length; i += 3)
            {
                string processString = s.ToUpper();

                if (processString[i] != 'S') differenceFlag++;
                if (processString[i + 1] != 'O') differenceFlag++;
                if (processString[i + 2] != 'S') differenceFlag++;
            }

            return differenceFlag;
        }

    }

    class Solution
    {
        public static void MarsExplorations(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            int result = Result.marsExploration(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}