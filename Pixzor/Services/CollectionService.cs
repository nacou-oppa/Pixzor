namespace Pixzor.Services
{
    internal sealed class CollectionService : ICollectionService
    {
        private readonly HttpClient _httpClient;

        public List<CollectionService> Collections { get; set; } = new();

        public CollectionService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("PexelPhoto");
        }

        public async Task<CollectionMedia> GetCollection(string type)
        {
            var result = await _httpClient.GetFromJsonAsync<CollectionMedia>($"collections/{type}");
            return result ?? new CollectionMedia();
        }

        public async Task<CollectionPage> GetCollections(int page = 1, int perPage = 80)
        {
            var result = await _httpClient.GetFromJsonAsync<CollectionPage>($"collections/featured?page={page}&per_page={perPage}");
            return result ?? new CollectionPage();
        }
    }
}