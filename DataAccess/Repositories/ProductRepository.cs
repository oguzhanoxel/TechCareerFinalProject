using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;

namespace DataAccess.Repositories
{
    public class ProductRepository : RepositoryBase<Product, LogisticsDbContext>, IProductRepository
    {

    }
}
