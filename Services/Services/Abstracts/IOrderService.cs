using DataAccess.Dtos;
using DataAccess.Entities;
using Services.Results;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Services.Services.Abstracts
{
    public interface IOrderService
    {
        List<OrderDetailDto> Search(string search = "");
        OrderDetailDto GetOrderDetail(Expression<Func<OrderDetailDto, bool>> filter);
        List<Order> GetAll(Expression<Func<Order, bool>> filter = null);
        Order GetById(int id);
        IResult Add(Order order);
        IResult Edit(Order order);
        IResult Delete(Order order);
    }
}
