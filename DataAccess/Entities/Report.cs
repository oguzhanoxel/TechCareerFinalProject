using System;

namespace DataAccess.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalProductPrice { get; set; }
        public decimal PersonalTotalSalary { get; set; }
        public decimal ExpenseOfVehicles { get; set; }
        public decimal Result { get; set; }
    }
}
