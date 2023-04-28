using System.ComponentModel;
using static MetaMood.Models.CustomAttributes.CustomAttributes;

namespace MetaMood.Models
{
    public class RedditCommentDTO
    {

        [Searchable]
        public string? Body { get; set; }

        [Cluster]
        public int? Emotion { get; set; }
    }
}
