namespace Pixzor.Models
{
    public sealed class CollectionMedia : Pagination
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("media")]
        public List<Media>? Media { get; set; }
    }
}