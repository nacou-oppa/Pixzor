namespace Pixzor.Models
{
    public sealed class Media
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        // Photo Properties
        [JsonPropertyName("photographer")]
        public string Photographer { get; set; } = string.Empty;

        [JsonPropertyName("photographer_url")]
        public string PhotographerUrl { get; set; } = string.Empty;

        [JsonPropertyName("photographer_id")]
        public int PhotographerId { get; set; }

        [JsonPropertyName("avg_color")]
        public string AvgColor { get; set; } = string.Empty;

        [JsonPropertyName("src")]
        public Source? Src { get; set; }

        [JsonPropertyName("liked")]
        public bool Liked { get; set; }

        [JsonPropertyName("alt")]
        public string Alt { get; set; } = string.Empty;

        // Video Properties
        [JsonPropertyName("full_res")]
        public bool? FullRes { get; set; }

        [JsonPropertyName("tags")]
        public string[]? Tags { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;

        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        [JsonPropertyName("user")]
        public User? User { get; set; }

        [JsonPropertyName("video_files")]
        public List<VideoFile>? VideoFiles { get; set; }

        [JsonPropertyName("video_picture")]
        public List<VideoPicture>? VideoPictures { get; set; }
    }
}