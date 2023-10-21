using DataAccess.Dtos;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Repositories.Abstracts
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<OrderDetailDto> GetOrderDetailList(Expression<Func<OrderDetailDto, bool>> filter = null);
        OrderDetailDto GetOrderDetail(Expression<Func<OrderDetailDto, bool>> filter);
    }
}
