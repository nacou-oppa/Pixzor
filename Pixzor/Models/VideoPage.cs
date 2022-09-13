namespace Pixzor.Models
{
    public sealed class VideoPage : Pagination
    {
        [JsonPropertyName("videos")]
        public List<Video>? Videos { get; set; }
    }
}