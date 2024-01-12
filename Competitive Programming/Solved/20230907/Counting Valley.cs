namespace CountingValleys
{
  class Result
  {

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     *  
     *  Basically this program meant to calculate how much valleys that has been travelled judged by:
     *  U -> Means Uphill (Conducting +1)
     *  D -> Means Valley (Conducting -1)
     *  
     *  The initialization always starts from 1.
     *  So if we have 8 steps, with path of UDDDUDUU it should be:
     *  Com = Command (Initialization (I), Upperhill (U), Downhill (D))
     *  Op = Operation (Remarking the math behind)
     *  Al = Altitude (Current altitude after operation)
     *  
     *  Com  Op  Al
     *  I         1
     *  U    +1   2
     *  D    -1  -1
     *  D    -1   0
     *  D    -1  -1
     *  U    +1   0
     *  D    -1  -1
     *  U    +1   0
     *  U    +1   1
     *  
     *  Hacker Rank team has given their own virtualization below:
     *  
     *  _/\      _
     *     \    /
     *      \/\/
     * 
     * Since the steps number 3 to 8 are considered as a valley since it start goes down below altitude 0, and end on step 8, it considered as 1 Valley.   
     */

    public static int countingValleys(int steps, string path)
    {
      int altitude = 1;
      int valleyIdentified = 0;

      bool travellingValley = false;

      for (int i = 0; i < path.Length; i++)
      {
        if (path[i] == 'U')
        {
          altitude++;

          // Check whatever valley stop and will go to normal altitude
          if (altitude == 1 && travellingValley)
          {
            valleyIdentified++;
            travellingValley = false;
          }
        }
        else if (path[i] == 'D')
        {
          altitude--;

          // Valley identified. Flag start travelling valley.
          if (altitude == 0)
          {
            travellingValley = true;
          }
        }
      }

      return valleyIdentified;
    }

  }

  /*
  Case DUDUUUUUUUUDUDDUUDUUDDDUUDDDDDUUDUUUUDDDUUUUUUUDDUDUDUUUDDDDUUDDDUDDDDUUDDUDDUUUDUUUDUUDUDUDDDDDDDDD

                                                          /\
                                                 /\      /  \
                                                /  \/\/\/    \  /\
                                               /              \/  \                      /\/\/\
                      /\                      /                    \/\                /\/      \
             /\/\  /\/  \  /\          /\    /                        \              /          \
            /    \/      \/  \        /  \  /                          \  /\      /\/            \
           /                  \      /    \/                            \/  \/\  /                \
          /                    \  /\/                                          \/                  \
         /                      \/                                                                  \
        /                                                                                            \
  _    /                                                                                              \_
   \/\/

  The output should be 2 since the valley starts from DUDU in the first lane. 

   */

  class Solution
  {
    public static void CountingValley(string[] args)
    {
      //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

      int steps = Convert.ToInt32(Console.ReadLine().Trim());

      string path = Console.ReadLine();

      int result = Result.countingValleys(steps, path);

      //textWriter.WriteLine(result);

      //textWriter.Flush();
      //textWriter.Close();
    }
  }

}