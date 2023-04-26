namespace MetaMood.Models
{
    public class SQLParameters
    {
        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public string? SortBy { get; set; }

        public string? Search { get; set; } = null;

    }
}
