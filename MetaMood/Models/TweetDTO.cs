using System.ComponentModel;
using static MetaMood.Models.CustomAttributes.CustomAttributes;

namespace MetaMood.Models
{
    public class TweetDTO
    {

        [Searchable]
        public string? Tweet { get; set; }

        [Cluster]
        public int Emotion { get; set; }
    }
}
