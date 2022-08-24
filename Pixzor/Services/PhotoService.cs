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

        public async Task GetPhotos(int page = 1, int perPage = 15)
        {
            Photos = await _httpClient.GetFromJsonAsync<PhotoPage>($"curated?page={page}&per_page={perPage}");
        }

        public async Task<PhotoPage> SearchPhoto(string query, string orientation = "", string size = "", string color = "", string local = "", int page = 1, int perPage = 15)
        {
            string requestUri = $"search?query={query}";

            if (!string.IsNullOrWhiteSpace(orientation))
            {
                requestUri += $"&orientation={orientation}";
            }
            if (!string.IsNullOrWhiteSpace(size))
            {
                requestUri += $"&size={size}";
            }
            if (!string.IsNullOrWhiteSpace(color))
            {
                requestUri += $"&color={color}";
            }
            if (!string.IsNullOrWhiteSpace(local))
            {
                requestUri += $"&local={local}";
            }

            requestUri += $"&page={page}&per_page={perPage}";

            Photos = await _httpClient.GetFromJsonAsync<PhotoPage>(requestUri);

            return Photos;
        }
    }
}