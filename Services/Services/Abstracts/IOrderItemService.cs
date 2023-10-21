using DataAccess.Entities;
using Services.Results;
using System.Collections.Generic;

namespace Services.Services.Abstracts
{
    public interface IOrderItemService
    {
        OrderItem GetById(int id);
        List<OrderItem> GetListByOrderId(int id);
        IResult Delete(OrderItem item);
        IResult Add(OrderItem item);
    }
}
