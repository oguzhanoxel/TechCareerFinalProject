using DataAccess.Entities;
using Services.Results;
using System.Collections.Generic;

namespace Services.Services.Abstracts
{
    public interface IReportService
    {
        List<Report> Search(string search = "");
        Result Create(Report report);
        Result Delete(Report report);
    }
}
