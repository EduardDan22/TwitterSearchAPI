using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace TwitterSearchAPI
{
    class SearchTweet
    {
        // User key credentials
        public static string APIKey = "xzyQxAgG90gvYMR0pGMD9Mc6G";
        public static string APIKeySecret = "COw92f6C9gpJ4C6Omfw7QUTJvAYAmLnks177cJbxk2IY91b4B6";
        public static string APIToken = "1081862025045786625-9O16Xm1gQxVafI2HDdUr6U99DeNpSM";
        public static string APITokenSecret = "3vTB38QvuZpSu3NWFYXmRuwytaGhICrBbWjDUozcFxDtW";

        // List of strings for tweet view
        private static List<string> tweetList = new List<string>();

        // Tweet search method
        public static void TweetSearch(string query)
        {
            
            IEnumerable<ITweet> tweets = Search.SearchTweets(query);
            foreach (ITweet tweet in tweets)
            {
                tweetList.Add(tweet.Text);
            }
            foreach (string str in tweetList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(tweetList.Count);
            Console.ReadLine();
        }
    }
}
