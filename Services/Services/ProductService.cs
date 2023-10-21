using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;
using Services.Results;
using Services.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> Search(string search = "")
        {
            if (search.Length > 0)
            {
                return _productRepository.GetAll(p => p.Name.Contains(search));
            }

            return _productRepository.GetAll();
        }

        public List<Product> GetList(Expression<Func<Product, bool>> filter = null)
        {
            return _productRepository.GetAll(filter);
        }

        public Product GetById(int id) {
            return _productRepository.Get(p => p.Id == id);
        }

        public IResult Add(Product product)
        {
            _productRepository.Add(product);
            return new SuccessResult();
        }

        public IResult Edit(Product product)
        {
            _productRepository.Update(product);
            return new SuccessResult();
        }

        public IResult Delete(Product product)
        {
            _productRepository.Delete(product);
            return new SuccessResult();
        }
    }
}
