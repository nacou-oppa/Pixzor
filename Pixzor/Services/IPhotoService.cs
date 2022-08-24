namespace Pixzor.Services
{
    public interface IPhotoService
    {
        PhotoPage Photos { get; set; }

        Task<Photo> GetPhoto(int id);

        Task GetPhotos(int page = 1, int perPage = 15);

        Task<PhotoPage> SearchPhoto(string query, string orientation = "", string size = "", string color = "", string local = "", int page = 1, int perPage = 15);
    }
}