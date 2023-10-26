using BlankStore.Catalog.API.Entities;
using MongoDB.Driver;

namespace BlankStore.Catalog.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
