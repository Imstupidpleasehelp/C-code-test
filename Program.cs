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
       
         }
    }
}
