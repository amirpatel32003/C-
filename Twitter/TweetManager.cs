using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    static class TweetManager
    {
        static List<Tweet> TWEETS;
        public static string FILENAME;

        //It is not possible to read from file inside constructor because when TweetManager class is called then it go inside
        //constructor class then only after then it will initialize the fields.
        //There are three ways to do the task:
        //1. Write the file location of the filename in this class itself like this
        //public static string FILENAME = @"C:\Users\Amir\Dropbox\PC\Desktop\semester 2\C#\Twitter\TweetFile.txt";

        //2. Create another static method called ReadFromFile() used to read from the text file
        //So when TweetManager class is called it will call the constructor then initialize fields and call ReadFromFile method.

        //3. We can use overloaded constructor with one argument to pass string file location, So that we can read the file inside constructor
        static TweetManager()
        {
            TWEETS = new List<Tweet>();
        }

        public static void ReadFromFile()
        {
            //If file exist in the computer, Then below If condition is true
            if (File.Exists(FILENAME))
            {
                //Read all the lines from the text file and store it on the string array
                string[] lines = File.ReadAllLines(FILENAME);

                //Loop through the lines string array
                for (int i = 0; i < lines.Length; i++)
                {
                    //Take one by one line from the lines array
                    string line = lines[i];
                    //Pass the line to Tweet class Parse method
                    Tweet tweet = Tweet.Parse(line);
                    //Add to the TWEETS list collection
                    TWEETS.Add(tweet);
                }
            }
            else
            {
                Console.WriteLine("Error :: File not found!");
            }
        }

        //Used this method for testing
        public static void Initialize()
        {
            //Here we cannot put 4 empty space as tab space, It won't recognize.
            //So \t is used as delimiter
            string line1 = "@radhi\t@john\tI am in USA\t#USA";
            string line2 = "@azam\t@wick\tReleased new movie\t#movie";
            string line3 = "@albert4\t@john\tThailand is amazing\t#Thailand";
            string line4 = "@show2\t@professor\tNew lessons out\t#lesson";
            string line5 = "@titanic2\t@actor2\tNew actor required\t#actor";

            //Pass the line to Tweet class Parse method
            Tweet tweet1 = Tweet.Parse(line1);
            Tweet tweet2 = Tweet.Parse(line2);
            Tweet tweet3 = Tweet.Parse(line3);
            Tweet tweet4 = Tweet.Parse(line4);
            Tweet tweet5 = Tweet.Parse(line5);

            //Initialize TWEETS list collection
            TWEETS = new List<Tweet>();
            //Add to the list collection
            TWEETS.Add(tweet1);
            TWEETS.Add(tweet2);
            TWEETS.Add(tweet3);
            TWEETS.Add(tweet4);
            TWEETS.Add(tweet5);

            //Another way of adding tweet object to the list
            //TWEETS.AddRange(new List<Tweet>() { tweet1, tweet2, tweet3, tweet4, tweet5 });
        }

        /// <summary>
        /// Show all the tweets
        /// </summary>
        public static void ShowAll()
        {
            string heading = "From".PadRight(20) + "To".PadRight(20) + "Body".PadRight(40) + "Tag";
            Console.WriteLine(heading);

            //Loop through the TWEETS list
            for (int i = 0; i < TWEETS.Count; i++)
            {
                //Print the tweet
                Console.WriteLine(TWEETS[i].ToString());
            }
        }

        /// <summary>
        /// Show all the tweets for this tag
        /// </summary>
        /// <param name="tag"></param>
        public static void ShowAll(string tag)
        {
            bool IsTagExist = false;
            string heading = "From".PadRight(20) + "To".PadRight(20) + "Body".PadRight(40) + "Tag";

            Console.WriteLine("\nSearch by Tag : " + tag);
            Console.WriteLine(heading);
            for (int i = 0; i < TWEETS.Count; i++)
            {
                //If tag exist in the TWEETS list collection, Then below If condition is true
                if (TWEETS[i].Tag.ToLower() == tag.ToLower())
                {
                    Console.WriteLine(TWEETS[i].ToString());
                    IsTagExist = true;
                }
            }

            //If tag doesn't exist display message
            if (IsTagExist == false)
            {
                Console.WriteLine("No Tweet exist for the tag " + tag);
            }

        }
    }
}
