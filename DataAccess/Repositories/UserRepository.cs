using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;

namespace DataAccess.Repositories
{
    public class UserRepository : RepositoryBase<User, LogisticsDbContext>, IUserRepository
    {

    }
}
