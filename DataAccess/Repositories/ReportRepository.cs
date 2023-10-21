using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;

namespace DataAccess.Repositories
{
    public class ReportRepository : RepositoryBase<Report, LogisticsDbContext>, IReportRepository
    {

    }
}
