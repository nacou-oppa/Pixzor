using System;

namespace Pixzor.Services
{
    internal interface IVideoService
    {
        List<Video> Videos { get; set; }

        Task<VideoPage> GetVideos(int page = 1, int perPage = 80, int? minWidth = null, int? minHeight = null, int? minDuration = null, int? maxDuration = null);

        Task<Video> GetVideo(int id);

        Task<VideoPage> SearchVideos(string query, int page = 1, int perPage = 80, string orientation = "", string size = "", string local = "");
    }
}