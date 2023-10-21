using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;

namespace DataAccess.Repositories
{
    public class OrderItemRepository : RepositoryBase<OrderItem, LogisticsDbContext>, IOrderItemRepository
    {

    }
}
