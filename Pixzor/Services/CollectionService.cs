using System.Runtime.CompilerServices;

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

        public async Task<CollectionMedia> GetCollection(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<CollectionMedia>($"collections/{id}");
            return result ?? new CollectionMedia();
        }

        public async Task<CollectionPage> GetCollections(int page = 1, int perPage = 80)
        {
            var result = await _httpClient.GetFromJsonAsync<CollectionPage>($"collections/featured?page={page}&per_page={perPage}");
            return result ?? new CollectionPage();
        }

        public async IAsyncEnumerable<CollectionMedia> GetCollectionMedias(IEnumerable<Collection> collections)
        {
            foreach (var collection in collections)
            {
                yield return await _httpClient.GetFromJsonAsync<CollectionMedia>($"collections/{collection.Id}") ?? new CollectionMedia();
            }
        }
    }
}