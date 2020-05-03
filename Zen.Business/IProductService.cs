using System;
using System.Collections.Generic;
using System.Text;
using Zen.Entities.Concrete;

namespace Zen.Business
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int productId);
        List<Product> GetByCategory(int categoryId);
    }
}
