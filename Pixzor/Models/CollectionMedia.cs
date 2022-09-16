namespace Pixzor.Models
{
    public sealed class CollectionMedia : Pagination
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("media")]
        public List<Media>? Media { get; set; }
    }
}