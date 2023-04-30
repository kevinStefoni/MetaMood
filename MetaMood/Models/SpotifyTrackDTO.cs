using System.ComponentModel;
using static MetaMood.Models.CustomAttributes.CustomAttributes;

namespace MetaMood.Models
{
    public class SpotifyTrackDTO
    {
        [Searchable]
        public string? Name { get; set; }

        [DisplayName("Release")]
        public string? ReleaseDate { get; set; }

        public int? Popularity { get; set; }

        [DisplayName("Acoustic")]
        public double? Acousticness { get; set; }

        public double? Danceability { get; set; }

        public double? Energy { get; set; }

        public double? Liveness { get; set; }

        public double? Loudness { get; set; }

        [DisplayName ("Speech")]
        public double? Speechiness { get; set; }

        public double? Tempo { get; set; }

        [DisplayName("Instrument")]
        public double? Instrumentalness { get; set; }

        public double? Valence { get; set; }

        [Cluster]
        public int Emotion { get; set; }

        [DisplayName ("Cover")]
        [UrlData]
        public string? CoverImageUrl { get; set; }

    }
}
