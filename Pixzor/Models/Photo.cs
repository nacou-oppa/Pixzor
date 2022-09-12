namespace Pixzor.Models
{
    public class Photo
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("width")]
        public int Width { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
        [JsonPropertyName("photographer")]
        public string Photographer { get; set; } = string.Empty;
        [JsonPropertyName("photographer_url")]
        public string PhotographerUrl { get; set; } = string.Empty;
        [JsonPropertyName("photographer_id")]
        public int PhotographerId { get; set; }
        [JsonPropertyName("avg_color")]
        public string AvgColor { get; set; } = string.Empty;
        [JsonPropertyName("src")]
        public Source Src { get; set; }
        [JsonPropertyName("liked")]
        public bool Liked { get; set; }
        [JsonPropertyName("alt")]
        public string Alt { get; set; } = string.Empty;
    }
}