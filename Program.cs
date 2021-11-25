using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace TwitterSearchAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Authenticating...
            Auth.SetUserCredentials(SearchTweet.APIKey, SearchTweet.APIKeySecret, SearchTweet.APIToken, SearchTweet.APITokenSecret);

            Console.WriteLine("Enter twitter search term: ");
            SearchTweet.TweetSearch(Console.ReadLine());
        }
    }
}
