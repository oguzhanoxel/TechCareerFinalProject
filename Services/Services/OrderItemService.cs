using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;
using Services.Results;
using Services.Services.Abstracts;
using System.Collections.Generic;

namespace Services
{
    public class OrderItemService : IOrderItemService
    {
        private IOrderItemRepository _orderItemRepository;

        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public IResult Add(OrderItem item)
        {
            _orderItemRepository.Add(item);
            return new SuccessResult();
        }

        public IResult Delete(OrderItem item)
        {
            _orderItemRepository.Delete(item);
            return new SuccessResult();
        }

        public OrderItem GetById(int id)
        {
            return _orderItemRepository.Get(item => item.Id == id);
        }

        public List<OrderItem> GetListByOrderId(int id)
        {
            return _orderItemRepository.GetAll(item => item.OrderId == id);
        }
    }
}
