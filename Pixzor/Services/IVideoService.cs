using System;

namespace Pixzor.Services
{
    internal interface IVideoService
    {
        List<Video> Videos { get; set; }

        Task GetVideos(int page = 1, int perPage = 80, int? minWidth = null, int? minHeight = null, int? minDuration = null, int? maxDuration = null);

        Task GetVideo(int id);

        Task SearchVideos(string query = "", int page = 1, int perPage = 0, string orientation = "", string size = "", string local = "");
    }
}