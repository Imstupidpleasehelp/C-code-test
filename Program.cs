using System;
using System.Net;

namespace C__thing
{
    class Program
    {
        static void Main(string[] args)
        {
        WebClient webClient = new WebClient();
    
webClient.DownloadFile("http://ringba-test-html.s3-website-us-west-1.amazonaws.com/TestQuestions/output.txt", "output.txt" );
       
       
        //dont console log this fucking beast 
         // 1.
        // Array to store frequencies.
        int[] c = new int[(int)char.MaxValue];

        // 2.
        // Read entire text file.
      string textString = System.IO.File.ReadAllText("output.txt");

        // 3.
        // Iterate over each character.
        foreach (char t in textString)
        {
            // Increment table.
            c[(int)t]++;
        }

        // 4.
        // Write all letters found.
        for (int i = 0; i < (int)char.MaxValue; i++)
        {
            if (c[i] > 0 &&
                char.IsLetterOrDigit((char)i))
            {
                Console.WriteLine("Letter: {0}  Frequency: {1}",
                    (char)i,
                    c[i]);
            }
        }
         }
         
    }
    
}
