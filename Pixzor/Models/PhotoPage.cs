namespace Pixzor.Models
{
    public sealed class PhotoPage : Pagination
    {
        [JsonPropertyName("photos")]
        public List<Photo>? Photos { get; set; }
    }
}