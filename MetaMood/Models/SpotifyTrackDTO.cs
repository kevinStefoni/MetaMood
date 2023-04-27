using System.ComponentModel;
using static MetaMood.Models.CustomAttributes.CustomAttributes;

namespace MetaMood.Models
{
    public class SpotifyTrackDTO
    {
        [Searchable]
        public string? Name { get; set; }

        [DisplayName("Release Date")]
        public string? ReleaseDate { get; set; }

        public int? Popularity { get; set; }

        public double? Acousticness { get; set; }

        public double? Danceability { get; set; }

        public double? Energy { get; set; }

        public double? Liveness { get; set; }

        public double? Loudness { get; set; }

        public double? Speechiness { get; set; }

        public double? Tempo { get; set; }

        public double? Instrumentalness { get; set; }

        public double? Valence { get; set; }

        [Cluster]
        public int Emotion { get; set; }

        [ColorHex]
        public string? ImageColorHex { get; set; }

    }
}
