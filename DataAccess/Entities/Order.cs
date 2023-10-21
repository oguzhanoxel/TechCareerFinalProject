using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered,
        Canceled
    }

    public class Order
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public DateTime? PendingDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public DateTime? CanceledDate { get; set; }
        public string DestinationAddress { get; set; }
        public decimal TotalWeight { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
