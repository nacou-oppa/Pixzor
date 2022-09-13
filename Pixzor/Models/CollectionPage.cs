namespace Pixzor.Models
{
    public sealed class CollectionPage
    {
        [JsonPropertyName("collections")]
        public List<Collection>? Collections { get; set; }
    }
}