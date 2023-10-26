using BlankStore.Catalog.API.Contracts;
using BlankStore.Catalog.API.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlankStore.Catalog.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext _context;

        public ProductRepository(ICatalogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task<Product> GetProduct(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
