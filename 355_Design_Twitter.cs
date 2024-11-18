using System;
using System.Collections.Generic;
using System.Linq;

public class Twitter {
    // Tweet class
    public class Tweet
    {
        public int tweetId { get; }
        public int userId { get; }
        public DateTime Timestamp { get; }

        public Tweet(int userId, int tweetId)
        {
            this.userId = userId;
            this.tweetId = tweetId;
            Timestamp = DateTime.UtcNow;
        }
    }

    // List to store all tweets
    private readonly List<Tweet> _tweets;
    // Dictionary to manage follow relationships
    private readonly Dictionary<int, HashSet<int>> _follows;
    
    // Constructor
    public Twitter() 
    {
        _tweets = new List<Tweet>();
        _follows = new Dictionary<int, HashSet<int>>();
    }
    
    // Method to post tweet
    public void PostTweet(int userId, int tweetId) 
    {
        var tweet = new Tweet(userId, tweetId);
        _tweets.Add(tweet);    
    }
    
    // Method to get the news feed
    public IList<int> GetNewsFeed(int userId) 
    {
        // Get the list of followees including the user themselves
        var followees = _follows.ContainsKey(userId) 
            ? _follows[userId]
            : new HashSet<int>();
        followees.Add(userId);

        // Filter tweets from user + their followees order by timestamp DESC
        var recentTweets = _tweets
            .Where(tweet => followees.Contains(tweet.userId))
            .OrderByDescending(tweet => tweet.Timestamp)
            .Take(10)
            .Select(tweet => tweet.tweetId)
            .ToList();

        return recentTweets;
    }
    
    // Method to follow a user
    public void Follow(int followerId, int followeeId) 
    {
        if (followerId == followeeId) return; 
        if (!_follows.ContainsKey(followerId))
        {
            _follows[followerId] = new HashSet<int>();
        }
        _follows[followerId].Add(followeeId);
    }
    
    // Method to unfollow a user
    public void Unfollow(int followerId, int followeeId) 
    {
        if (_follows.ContainsKey(followerId))
        {
            _follows[followerId].Remove(followeeId);
        }    
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */
