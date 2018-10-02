using sample_mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace sample_mvc.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected MemberDbContext MemberDbContext
        {
            get;
            private set;
        }
        public Repository()
        {
            this.MemberDbContext = new MemberDbContext();
        }
        public T Add(T entity)
        {
            MemberDbContext.Entry(entity).State = EntityState.Added;
            MemberDbContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        => MemberDbContext.Entry(entity).State = EntityState.Deleted;

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter)
        => MemberDbContext.Set<T>().Where(filter);

        public IEnumerable<T> GetAll()
        => MemberDbContext.Set<T>();

        public T GetById(int id)
         => MemberDbContext.Set<T>().Find(id);


        public T GetSingle(Expression<Func<T, bool>> filter)
         => MemberDbContext.Set<T>().FirstOrDefault(filter);

        public void Update(T entity)
        {
            MemberDbContext.Entry(entity).State = EntityState.Modified;
            MemberDbContext.SaveChanges();
        }
    }
}