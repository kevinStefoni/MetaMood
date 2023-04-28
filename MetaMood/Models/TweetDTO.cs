using System.ComponentModel;
using static MetaMood.Models.CustomAttributes.CustomAttributes;

namespace MetaMood.Models
{
    public class TweetDTO
    {
        public string? User { get; set; }

        [Searchable]
        public string? Tweet { get; set; }

        [Cluster]
        public int Emotion { get; set; }
    }
}
