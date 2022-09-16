namespace Pixzor.Services
{
    internal interface ICollectionService
    {
        List<CollectionService> Collections { get; set; }

        Task<CollectionPage> GetCollections(int page = 1, int perPage = 80);

        Task<CollectionMedia> GetCollection(string id);

        IAsyncEnumerable<CollectionMedia> GetCollectionMedias(IEnumerable<Collection> collections);
    }
}