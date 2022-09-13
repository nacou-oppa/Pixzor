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
        public string Width { get; set; } = string.Empty;

        [JsonPropertyName("height")]
        public string Height { get; set; } = string.Empty;

        [JsonPropertyName("link")]
        public string Link { get; set; } = string.Empty;
    }
}