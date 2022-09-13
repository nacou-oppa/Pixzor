namespace Pixzor.Models
{
    public class CollectionPage
    {
        [JsonPropertyName("collections")]
        public List<Collection>? Collections { get; set; }
    }
}