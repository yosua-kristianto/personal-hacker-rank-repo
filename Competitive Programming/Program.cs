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
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     * 
     * This problem makes me find the binary of the n first, and then flip the n, and then convert it into the long again.
     * 
     * @since September, 6th 2023 17:44
     * There is a problem that for some reason, the bitmapCollection only count 1 to 16.
     */

    public static long flippingBits(long n)
    {
        // This is the data structure to store the bitmap.
        List<byte> bitmapCollection = new List<byte>();
        
        while(n > 0)
        {
            // Save the remainder to judge its bit
            long remainder = n % 2;

            // Reassign n as quotient
            n = n / 2;

            if(remainder != 0)
            {
                // This is intentional since I want to flip the result
                bitmapCollection.Insert(0, 0);
            }
            else
            {
                // This is intentional since I want to flip the result
                bitmapCollection.Insert(0, 1);
            }
        }

        // Force the bitmap collection to 32-bit
        if(bitmapCollection.Count < 32)
        {
            for(int i = 0; i < (32 - bitmapCollection.Count); i++)
            {
                // This is intentional since I want to flip the result
                bitmapCollection.Insert(0, 1);
            }
        }

        // New Number
        double newLong = 0L;

        for(int i = 0; i < bitmapCollection.Count; i++)
        {
            byte e = bitmapCollection[i];

            if(e == 1)
            {
                newLong += (double) Math.Pow(2, i);
            }
        }

        return (long) newLong;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            //textWriter.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
