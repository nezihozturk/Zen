using System;
using System.Collections.Generic;
using System.Text;
using Zen.Core.DataAccess;
using Zen.DataAccess.Abstract;
using Zen.DataAccess.Concrete.EntityFramework.Contexts;
using Zen.Entities.Concrete;

namespace Zen.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EntityRepositoryBase<NorthwindContext,Category> ,ICategoryDal
    {
    }
}
