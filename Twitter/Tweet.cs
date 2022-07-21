using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    class Tweet
    {
        static int CURRENT_ID;
        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }

        public Tweet(string from, string to, string body, string tag)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
        }

        public override string ToString()
        {
            string result = From.PadRight(20) + To.PadRight(20) + Body.PadRight(40) + Tag;
            return result;
        }

        public static Tweet Parse(string line)
        {
            //Split each tweet (represent by line) by \t and store it into string array
            string[] values = line.Split('\t');

            //Pass the respective values to local variable
            string from = values[0];
            string to = values[1];
            string body = values[2];
            string tag = values[3];

            //Increment the id
            CURRENT_ID++;

            //Create overload constructo of class Tweet and create object
            Tweet tweet = new Tweet(from, to, body, tag);

            //return the object
            return tweet;

        }
    }

}