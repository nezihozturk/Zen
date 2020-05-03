using System;
using System.Collections.Generic;
using System.Text;
using Zen.Core.DataAccess;
using Zen.Entities.Concrete;

namespace Zen.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
