using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dtos
{
    public class OrderDetailDto
    {
        public int OrderId { get; set; }
        public int VehicleId { get; set; }
        public string VehiclePlate { get; set; }
        public DateTime? PendingDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public DateTime? CanceledDate { get; set; }
        public string DestinationAddress { get; set; }
        public decimal TotalWeight { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
