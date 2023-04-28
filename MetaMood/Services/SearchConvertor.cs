using MetaMood.Models;

namespace MetaMood.Services
{
    public class SearchConvertor
    {

        public static string DataSetTypeToSearchString(Type t)
        {
            if(t == typeof(SpotifyTrackDTO))
            {
                return "track name";
            }
            else if(t == typeof(RedditCommentDTO)) 
            {
                return "reddit posts";
            }
            else if(t == typeof(TweetDTO))
            {
                return "tweet";
            }
            else
            {
                return "item";
            }
        }

    }
}
