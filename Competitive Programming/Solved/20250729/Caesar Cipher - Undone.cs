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

namespace CaesarCipher;

class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        string alphabeth = "abcdefghijklmnopqrstuvwxyz";
        char[] alphabethSeq = alphabeth.ToCharArray();

        int divider = 1;
        int flag = k;

        while (flag > 26)
        {
            if (flag / divider == 0)
            {
                break;
            }

            flag--;
        }

        string startSub = alphabeth.Substring(0, flag);
        string temp = alphabeth.Replace(startSub, "");
        char[] encryption = (temp + startSub).ToCharArray();

        Dictionary<char, char> dict = new();

        for (int i = 0; i < alphabeth.Length; i++)
        {
            dict.Add(alphabethSeq[i], encryption[i]);
        }

        string cipher = "";

        Console.WriteLine(alphabeth);
        Console.WriteLine(new string(encryption));

        foreach (var kvp in dict)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine($"ASCII {s[i]} - {(int)s[i]}");
            bool isBigAlphabeth = ((64 < (int)s[i]) && ((int)s[i] < 91));
            bool isSmallAlphabeth = (96 < (int)s[i] && (int)s[i] < 123);
            if (isBigAlphabeth || isSmallAlphabeth)
            {
                if (isBigAlphabeth)
                {
                    char convertedAlphabeth = Convert.ToChar(((int)s[i]) + 32);
                    cipher += dict[convertedAlphabeth].ToString().ToUpper();
                }
                else
                {
                    cipher += dict[s[i]];
                }
            }
            else
            {
                cipher += s[i];
            }
        }

        return cipher;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
