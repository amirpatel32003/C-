using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Below two line of code for testing
            //TweetManager.Initialize();
            //TweetManager.ShowAll();

            //Below lines in production
            TweetManager.FILENAME = @"C:\Users\Amir\Dropbox\PC\Desktop\semester 2\C#\Twitter\TweetFile.txt";
            TweetManager.ReadFromFile();
            TweetManager.ShowAll();
            TweetManager.ShowAll("#movie");
            TweetManager.ShowAll("#abcd");
            Console.ReadLine();
        }
    }
}
