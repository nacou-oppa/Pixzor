namespace Pixzor.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly HttpClient _httpClient;

        public PhotoPage Photos { get; set; } = new();

        public PhotoService(IHttpClientFactory clientFactory)
        {
            _httpClient = clientFactory.CreateClient("PexelPhoto");
        }

        public async Task<Photo> GetPhoto(int id)
        {
            var photo = await _httpClient.GetFromJsonAsync<Photo>($"photos/{id}");
            return photo;
        }

        public async Task<PhotoPage> GetPhotos(int page = 1, int perPage = 15)
        {
            var photoPage = await _httpClient.GetFromJsonAsync<PhotoPage>($"curated?page={page}&per_page={perPage}");
            return photoPage;
        }

        public async Task<PhotoPage> SearchPhoto(string query, int page = 1, int perPage = 0, string orientation = "", string size = "", string color = "", string local = "")
        {
            string requestUri = $"search?query={query}";

            if (!string.IsNullOrWhiteSpace(orientation))
                requestUri += $"&orientation={orientation}";
            if (!string.IsNullOrWhiteSpace(size))
                requestUri += $"&size={size}";
            if (!string.IsNullOrWhiteSpace(color))
                requestUri += $"&color={color}";
            if (!string.IsNullOrWhiteSpace(local))
                requestUri += $"&local={local}";
            if (perPage != 0)
                requestUri += $"&per_page={perPage}";

            requestUri += $"&page={page}";

            Photos = await _httpClient.GetFromJsonAsync<PhotoPage>(requestUri);

            return Photos;
        }
    }
}