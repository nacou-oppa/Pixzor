namespace Pixzor.Models
{
    public sealed class Collection
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("private")]
        public bool Private { get; set; }

        [JsonPropertyName("media_count")]
        public int MediaCount { get; set; }

        [JsonPropertyName("photos_count")]
        public int PhotosCount { get; set; }

        [JsonPropertyName("videos_count")]
        public int VideosCount { get; set; }
    }
}