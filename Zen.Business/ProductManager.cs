using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zen.DataAccess.Abstract;
using Zen.DataAccess.Concrete.EntityFramework.Contexts;
using Zen.Entities.Concrete;

namespace Zen.Business
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.Get().ToList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.Get(p => p.CategoryId == categoryId).ToList();
        }

        public Product GetById(int productId)
        {
            return _productDal.GetById(p => p.ProductId == productId);
        }
    }
}
