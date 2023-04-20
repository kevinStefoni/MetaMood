using static MetaMood.Models.CustomAttributes.CustomAttributes;
using System.ComponentModel;

namespace MetaMood.Models
{
    public class SpotifyAnalysisDTO
    {

        public double? Acousticness { get; set; }

        public double? Danceability { get; set; }

        public double? Energy { get; set; }

        public double? Liveness { get; set; }

        public double? Speechiness { get; set; }

        public double? Instrumentalness { get; set; }

        public double? Valence { get; set; }
    }
}
