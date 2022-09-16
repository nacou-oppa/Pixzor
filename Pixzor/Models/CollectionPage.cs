namespace Pixzor.Models
{
    public sealed class CollectionPage : Pagination
    {
        [JsonPropertyName("collections")]
        public List<Collection>? Collections { get; set; }
    }
}