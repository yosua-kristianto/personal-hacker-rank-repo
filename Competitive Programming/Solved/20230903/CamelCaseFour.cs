using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCaseFour
{
  class Solution
  {
    /**
     * camelCaseFour
     * This function contains text operation to combine or seperate, and processing the text by its categorization (Variable, Class, or Method)
     * 
     * Algorithm:
     * 1. Parse the information through command
     *    If the command is "C" (stands for Combine), then the input must be have some space(s) seperating every phrase. 
     *      Removing the spaces, and then concat every phrase by doing operation number 2's rule.
     *    If the command is "S" (stands for Seperate), then the input must be already in programmatic naming way such as camelCase or PascalCase thingy.
     *      Seperate the phrase by its "Capital" letter, and add space before every capital letter, and end it by decapitalize the letter. However, watchout for "M" categorization since it has () that must be deleted in this command.
     * 2. Categorization 
     *    If the command is "M" (stands for Method), then the input must be treated as a function / method. 
     *      For the "C" command, I must convert the input into camelCase and add () behind.
     *      For the "S" command, it mean that I have to remove the () behind, and then do the number 1 for "S".
     *    If the command is "C" (stands for Class), then the input must be treated as a class.
     *      For the "C" command, I must convert the input into PascalCase.
     *    If the command is "V" (stands for Variable), then the input must be treated as a variable.
     *      For the "C" command, I must convert the input into camelCase.
     */
    protected internal string camelCaseFour(string command, string categorization, string rawInput)
    {
      // This variable used to store the output.
      string newPhrase = "";

      // Clean up the input from any regex
      string input = rawInput.Replace("\r", "");

      switch (command)
      {
        case "S":

          // Remove () within M categorized input
          if (categorization == "M")
          {
            input = input.Replace("(", "");
            input = input.Replace(")", "");
          }

          for (int j = 0; j < input.Length; j++)
          {
            char i = input[j];
            // Convert the currently looped character into ascii code.
            int asciiCode = (int)i;

            /**
             * Hence input:
             * TheQuickBrownFoxJumpOverTheLazyDog
             * I'm searching the Q,B,F,J,O,T,L,D to make them start with space
             * 
             * Check whatever asciiCode of input[i] is referring to capital letter or not
             * AND
             * i is not 0 means the current character not referring the first letter.
             * 
             * @link https://www.asciitable.com/
             */
            if ((asciiCode >= 65 && asciiCode <= 90) && (j != 0))
            {
              // Append the *space*
              newPhrase = newPhrase + " ";
            }

            // Append the input[i] as lower case.
            newPhrase += i.ToString().ToLower();
          }
          break;

        case "C":

          bool capitalizedFlag = false;

          for (int j = 0; j < input.Length; j++)
          {
            char i = input[j];

            // Convert the currently looped character into ascii code.
            int asciiCode = (int)i;

            /**
             * Hence input:
             * 
             * Check whatever asciiCode of input[i] is referring to space
             * AND
             * i is not 0 means the current character not referring the first letter.
             * 
             * @link https://www.asciitable.com/
             */
            if ((asciiCode == 32) && (j != 0))
            {
              // Set capitalizedFlag as true
              capitalizedFlag = true;

              // You don't want to continue the operation after getting space.
              continue;
            }

            // Check if categorization is C, then if i = 0, the capitalizedFlag must be set as true since it is meant to be PascalCase.
            if (categorization == "C" && j == 0)
            {
              capitalizedFlag = true;
            }

            // Check if categorization is 


            if (capitalizedFlag == true)
            {
              newPhrase += i.ToString().ToUpper();

              // Set capitalizedFlag as false afterwards.
              capitalizedFlag = false;
            }
            else
            {
              newPhrase += i.ToString().ToLower();
            }
          }

          // If the categorization is M, then add () behind.
          if (categorization == "M")
          {
            newPhrase += "()";
          }
          break;
      }

      return newPhrase;
    }

    public Solution()
    {
      /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

      string input = Console.In.ReadToEnd();

      try
      {
        foreach (string stdin in input.Split("\n"))
        {
          string[] values = (stdin ?? "").Split(";");
          Console.WriteLine(this.camelCaseFour(values[0], values[1], values[2]));
        }
      }
      catch (Exception e)
      {
        Console.WriteLine("Error parsing input. Expected Operation method of S or C in first phrase, M, C, or V in second phrase, and string in the third phrase. Every phrase must be seperated with ;. \nExample: C;V;mobile phone");
      }
    }

    static void Main(String[] args)
    {
      new Solution();
    }
  }
}
