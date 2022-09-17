namespace Pixzor.Services
{
    internal interface IPhotoService
    {
        PhotoPage Photos { get; set; }

        Task<Photo> GetPhoto(int id);

        Task<PhotoPage> GetPhotos(int page = 1, int perPage = 80);

        Task<PhotoPage> SearchPhoto(string query, int page = 1, int perPage = 80, string orientation = "", string size = "", string color = "", string local = "");
    }
}