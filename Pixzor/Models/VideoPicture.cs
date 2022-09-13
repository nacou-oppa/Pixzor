namespace Pixzor.Models
{
    public sealed class VideoPicture
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nr")]
        public int Nr { get; set; }

        [JsonPropertyName("picture")]
        public string Picture { get; set; } = string.Empty;
    }
}