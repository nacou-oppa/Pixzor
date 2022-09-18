using MudBlazor;

namespace Pixzor.Services
{
    internal sealed class VideoService : IVideoService
    {
        private readonly HttpClient _httpClient;

        public List<Video> Videos { get; set; } = new();

        public VideoService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("PexelVideo");
        }

        public async Task<Video> GetVideo(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Video>($"videos/{id}");
            return result ?? new Video();
        }

        public async Task<VideoPage> GetVideos(int page = 1, int perPage = 80, int? minWidth = null, int? minHeight = null, int? minDuration = null, int? maxDuration = null)
        {
            string requestUri = $"popular?page={page}&per_page={perPage}";

            if (minWidth is not null)
                requestUri += $"&min_width={minWidth}";
            if (minHeight is not null)
                requestUri += $"&min_height={minHeight}";
            if (minDuration is not null)
                requestUri += $"&min_duration={minDuration}";
            if (maxDuration is not null)
                requestUri += $"&max_duration={maxDuration}";

            var result = await _httpClient.GetFromJsonAsync<VideoPage>(requestUri);
            return result ?? new VideoPage();
        }

        public async Task<VideoPage> SearchVideos(string query, int page = 1, int perPage = 80, string orientation = "", string size = "", string local = "")
        {
            string requestUri = $"search?query={query}&page={page}";

            if (perPage != 0) requestUri += $"&per_page={perPage}";
            if (!string.IsNullOrEmpty(orientation)) requestUri += $"&orientation={orientation}";
            if (!string.IsNullOrEmpty(size)) requestUri += $"&size={size}";
            if (!string.IsNullOrEmpty(local)) requestUri += $"&local={local}";

            var result = await _httpClient.GetFromJsonAsync<VideoPage>(requestUri);
            return result ?? new VideoPage();
        }
    }
}