namespace Pixzor.Models
{
    public abstract class Pagination
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        [JsonPropertyName("prev_page")]
        public string PrevPage { get; set; } = string.Empty;

        [JsonPropertyName("next_page")]
        public string NextPage { get; set; } = string.Empty;

        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
    }
}