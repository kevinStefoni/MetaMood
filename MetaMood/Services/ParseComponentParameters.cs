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

            if(type == typeof(SpotifyTrackDTO))
                return "spotify-tracks";

            return null;
        }

    }
}
