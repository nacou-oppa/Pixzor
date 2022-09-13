namespace Pixzor.Services
{
    internal interface ICollection
    {
        List<Collection> Collections { get; set; }

        Task GetCollections(int page = 1, int perPage = 0);

        Task GetCollection(int id);
    }
}