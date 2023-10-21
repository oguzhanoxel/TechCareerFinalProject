using DataAccess.Dtos;
using DataAccess.Entities;
using DataAccess.Repositories;
using DataAccess.Repositories.Abstracts;
using Services.Results;
using Services.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<OrderDetailDto> Search(string seach = "")
        {
            if (seach.Length > 0)
            {
                return _orderRepository.GetOrderDetailList(o => o.VehiclePlate.Contains(seach));
            }

            return _orderRepository.GetOrderDetailList();
        }

        public OrderDetailDto GetOrderDetail(Expression<Func<OrderDetailDto, bool>> filter)
        {
            return _orderRepository.GetOrderDetail(filter);
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            return _orderRepository.GetAll(filter);
        }

        public IResult Add(Order order)
        {
            _orderRepository.Add(order);
            return new SuccessResult();
        }

        public IResult Edit(Order order)
        {
            _orderRepository.Update(order);
            return new SuccessResult();
        }

        public IResult Delete(Order order)
        {
            _orderRepository.Delete(order);
            return new SuccessResult();
        }

        public Order GetById(int id)
        {
            return _orderRepository.Get(o => o.Id == id);
        }
    }
}
