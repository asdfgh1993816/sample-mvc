using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace sample_mvc.Repository
{
    interface IRepository<T> where T :class
    {
        T GetById(int id);
        T GetSingle(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
