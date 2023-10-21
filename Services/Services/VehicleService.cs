using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;
using Services.Results;
using Services.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Services
{
    public class VehicleService : IVehicleService
    {
        private IVehicleRepository _vehicleRepository;
        private IOrderService _orderService;

        public VehicleService(IVehicleRepository vehicleRepository, IOrderService orderService)
        {
            _vehicleRepository = vehicleRepository;
            _orderService = orderService;
        }

        public List<Vehicle> Search(string search = "")
        {
            if (search.Length > 0)
            {
                return _vehicleRepository.GetAll(v => v.Plate.Contains(search));
            }

            return _vehicleRepository.GetAll();
        }

        public List<Vehicle> GetAllAvailable(Order order = null)
        {
            if (order == null)
            {
                return _vehicleRepository.GetAll(v => v.IsAvailable == true);
            }
            return _vehicleRepository.GetAll(v => v.IsAvailable == true || order.VehicleId == v.Id);
        }

        public Vehicle GetById(int id) { 
            return _vehicleRepository.Get(v => v.Id == id);
        }

        public IResult Add(Vehicle vehicle)
        {
            _vehicleRepository.Add(vehicle);
            return new SuccessResult();
        }

        public IResult Update(Vehicle vehicle)
        {
            _vehicleRepository.Update(vehicle);
            return new SuccessResult();
        }

        public IResult Edit(Vehicle vehicle)
        {
            foreach (Order order in _orderService.GetAll())
            {
                if (order.VehicleId == vehicle.Id)
                {
                    return new ErrorResult("Vehicle in use cannot be updated.");
                }
            }
            _vehicleRepository.Update(vehicle);
            return new SuccessResult();
        }

        public IResult Delete(Vehicle vehicle)
        {
            if (vehicle.IsAvailable)
            {
                _vehicleRepository.Delete(vehicle);
                return new SuccessResult();
            }

            return new ErrorResult("Vehicle in use cannot be deleted.");
        }
    }
}
