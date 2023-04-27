using MetaMood.Models;

namespace MetaMood.Services
{
    public static class ClusterConvertor
    {

        public static string ToCluster(this int a, Type t)
        {
            if (t == typeof(SpotifyTrackDTO))
            {
                return a switch
                {
                    0 => "Happy",
                    1 => "Sad",
                    2 => "Ferocious",
                    3 => "Happy",
                    4 => "Sad",
                    5 => "Relaxed",
                    6 => "Anger",
                    _ => "ERROR",
                };
            }
            else if(t == typeof(RedditCommentDTO) || t == typeof(TweetDTO))
            {
                return a switch
                {
                    0 => "Anger",
                    1 => "Fear",
                    2 => "Happy",
                    3 => "Love",
                    4 => "Sad",
                    5 => "Surprise",
                    _ => "ERROR",
                };
            }
            else
            {
                return "ERROR";
            }

        }

    }
}
