using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.Entities;

namespace Zen.Core.DataAccess
{
    public interface IEntityRepository<T> where T: IEntity
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null);

        T GetById(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Remove(T entity);

        void Update(T entity);

        int SaveAll();

    }
}
