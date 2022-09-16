namespace Pixzor.Models
{
    public sealed class VideoFile
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("quality")]
        public string Quality { get; set; } = string.Empty;

        [JsonPropertyName("file_type")]
        public string FileType { get; set; } = string.Empty;

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; } = string.Empty;
    }
}