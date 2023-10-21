using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;
using Services.Results;
using Services.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ReportService : IReportService
    {
        private IReportRepository _reportRepository;

        public ReportService(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public List<Report> Search(string search = "")
        {
            if (search.Length > 0)
            {
                return _reportRepository.GetAll(); // uygun bir lambda kullanılmalı
            }
            return _reportRepository.GetAll();
        }

        public Result Create(Report report)
        {
            _reportRepository.Add(report);
            return new SuccessResult();
        }

        public Result Delete(Report report) { 
            _reportRepository.Delete(report);
            return new SuccessResult();
        }
    }
}
