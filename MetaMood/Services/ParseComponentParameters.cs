using MetaMood.Models;

namespace MetaMood.Services
{
    public class ParseComponentParameters
    {

        /// <summary>
        /// This method simply returns a string that conveys what type of entity the table will be displaying.
        /// </summary>
        /// <param name="type">The type of the entity being displayed in the table</param>
        /// <returns>The name of the table that is going to be created</returns>
        public static string? ParseTableFromType(Type? type)
        {

            if (type == typeof(SpotifyTrackDTO))
                return "spotify-tracks";
            else if (type == typeof(RedditCommentDTO))
                return "reddit-comments";
            else if (type == typeof(TweetDTO))
                return "tweets";
            return null;
        }

        public static string? GetDefaultSort(Type? t)
        {
            if (t == typeof(SpotifyTrackDTO))
                return "Name";
            else if (t == typeof(RedditCommentDTO))
                return "Body";
            else if (t == typeof(TweetDTO))
                return "Tweet";
            
            return null;
        }

    }
}
