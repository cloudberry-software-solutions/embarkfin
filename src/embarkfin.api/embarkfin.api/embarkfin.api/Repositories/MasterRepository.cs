using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using embarkfin.api.Models.Database;

namespace embarkfin.api.Repositories
{
    public abstract class MasterRepository<T> where T : BaseEntity
    {
        protected DatabaseContext Context { get; }

        public MasterRepository(DatabaseContext context)
        {
            Context = context;
        }

        public T GetById(int id)
        {
           
                return Context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
          
                return Context.Set<T>().ToList();

        }

        public void Insert(T entity)
        {

                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                entity.CreatedAt = DateTime.Now;
                Context.Set<T>().Add(entity);
                Context.SaveChanges();

        }

        public void Update(T entity)
        {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                entity.UpdatedAt = DateTime.Now;
                Context.Set<T>().Update(entity);
                Context.SaveChanges();

        }

        public void Delete(T entity)
        {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                Context.Set<T>().Remove(entity);
                Context.SaveChanges();

        }

    }
}