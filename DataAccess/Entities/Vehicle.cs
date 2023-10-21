using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public decimal Capacity { get; set; }
        public decimal MonthlyExpense { get; set; }
        public bool IsAvailable { get; set; }
    }
}
