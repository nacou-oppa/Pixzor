namespace Pixzor.Services
{
    internal sealed class VideoService : IVideoService
    {
        public List<Video> Videos { get; set; }

        public Task GetVideo(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetVideos(int page = 1, int perPage = 80, int? minWidth = null, int? minHeight = null, int? minDuration = null, int? maxDuration = null)
        {
            throw new NotImplementedException();
        }

        public Task SearchVideos(string query = "", int page = 1, int perPage = 0, string orientation = "", string size = "", string local = "")
        {
            throw new NotImplementedException();
        }
    }
}