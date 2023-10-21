using DataAccess.Entities;
using Services.Results;
using System.Collections.Generic;

namespace Services.Services.Abstracts
{
    public interface IVehicleService
    {
        IResult Add(Vehicle vehicle);
        IResult Edit(Vehicle vehicle);
        IResult Update(Vehicle vehicle);
        IResult Delete(Vehicle vehicle);
        List<Vehicle> Search(string search = "");
        List<Vehicle> GetAllAvailable(Order order = null);
        Vehicle GetById(int id);
    }
}
