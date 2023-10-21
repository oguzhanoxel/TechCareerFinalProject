using DataAccess.Dtos;
using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DataAccess.Repositories
{
    public class OrderRepository : RepositoryBase<Order, LogisticsDbContext>, IOrderRepository
    {
        public List<OrderDetailDto> GetOrderDetailList(Expression<Func<OrderDetailDto, bool>> filter = null)
        {
            using (LogisticsDbContext context = new LogisticsDbContext())
            {
                var result = from o in context.Orders
                             join v in context.Vehicles
                             on o.VehicleId equals v.Id
                             select new OrderDetailDto
                             {
                                 OrderId = o.Id,
                                 VehicleId = v.Id,
                                 VehiclePlate = v.Plate,
                                 PendingDate = o.PendingDate,
                                 ShippedDate = o.ShippedDate,
                                 DeliveredDate = o.DeliveredDate,
                                 CanceledDate = o.CanceledDate,
                                 DestinationAddress = o.DestinationAddress,
                                 TotalWeight = o.TotalWeight,
                                 OrderStatus = o.OrderStatus,
                             };
                
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public OrderDetailDto GetOrderDetail(Expression<Func<OrderDetailDto, bool>> filter)
        {
            using (LogisticsDbContext context = new LogisticsDbContext())
            {
                var result = from o in context.Orders
                             join v in context.Vehicles
                             on o.VehicleId equals v.Id
                             select new OrderDetailDto
                             {
                                 OrderId = o.Id,
                                 VehicleId = v.Id,
                                 VehiclePlate = v.Plate,
                                 PendingDate = o.PendingDate,
                                 ShippedDate = o.ShippedDate,
                                 DeliveredDate = o.DeliveredDate,
                                 CanceledDate = o.CanceledDate,
                                 DestinationAddress = o.DestinationAddress,
                                 TotalWeight = o.TotalWeight,
                                 OrderStatus = o.OrderStatus,
                             };

                return result.SingleOrDefault(filter);
            }
        }
    }
}
