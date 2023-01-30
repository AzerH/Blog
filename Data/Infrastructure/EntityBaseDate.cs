using Data.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class EntityBaseDate<T> : IData<T> where T : ModelBase
    {

        protected readonly DbContext _context;
        public EntityBaseDate(DbContext context)
        {
            _context = context;

        }

        public void DetachAllEntities()
        {
            var entries = _context.ChangeTracker.Entries()
                .Where(e=>e.State != EntityState.Detached)
                .ToList();

            foreach (var item in entries)
            {

            }



        }






        public DataResult Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public DataResult DeleteByKey(int id)
        {
            throw new NotImplementedException();
        }

       

        public T FirstOrDefault(Expression<Func<T, bool>> predicate, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate, string orderBy = "Id", bool isDesc = false, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll(string orderBy, bool isDesc = false)
        {
            throw new NotImplementedException();
        }

        public List<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<T> GetBy(Expression<Func<T, bool>> predicate, string orderBy, bool isDesc = false)
        {
            throw new NotImplementedException();
        }

        public List<T> GetBy(Expression<Func<T, bool>> predicate, int pageNumber, int pageCount, string orderBy = "Id", bool isDesc = false)
        {
            throw new NotImplementedException();
        }

        public T GetByKey(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetBypage(int pageNumber, int pageCount, string orderBy = "Id", bool isDesc = false)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public DataResult Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public DataResult InsertBulk(List<T> ts, bool validateAndIgnoreBefore = false)
        {
            throw new NotImplementedException();
        }

        public DataResult Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
