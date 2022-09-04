namespace Pixzor.Models
{
    public class PhotoPage
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("photos")]
        public List<Photo> Photos { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        [JsonPropertyName("prev_page")]
        public string PrevPage { get; set; }

        [JsonPropertyName("next_page")]
        public string NextPage { get; set; }
    }
}