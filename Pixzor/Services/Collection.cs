namespace Pixzor.Services
{
    internal sealed class Collection : ICollection
    {
        public List<Collection> Collections { get; set; } = new();

        public Task GetCollection(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetCollections(int page = 1, int perPage = 0)
        {
            throw new NotImplementedException();
        }
    }
}