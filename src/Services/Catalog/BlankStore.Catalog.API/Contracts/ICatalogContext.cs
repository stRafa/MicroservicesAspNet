using BlankStore.Catalog.API.Entities;
using MongoDB.Driver;

namespace BlankStore.Catalog.API.Contracts
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
