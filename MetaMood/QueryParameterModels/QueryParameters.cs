namespace MetaMood.QueryParameterModels
{
    public class QueryParameters
    {
        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public string SortBy { get; set; } = "Name";

    }
}
