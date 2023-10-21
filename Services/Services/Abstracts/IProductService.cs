using DataAccess.Entities;
using Services.Results;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Services.Services.Abstracts
{
    public interface IProductService
    {
        List<Product> Search(string search = "");
        List<Product> GetList(Expression<Func<Product, bool>> filter = null);
        Product GetById(int id);
        IResult Add(Product product);
        IResult Edit(Product product);
        IResult Delete(Product product);
    }
}
