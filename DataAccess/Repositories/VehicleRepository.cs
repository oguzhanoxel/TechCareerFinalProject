using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;

namespace DataAccess.Repositories
{
    public class VehicleRepository : RepositoryBase<Vehicle, LogisticsDbContext>, IVehicleRepository
    {

    }
}
