using Petshop.Domain.Entities;
using Petshop.Domain.Interfaces.Repositories;
using Petshop.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Infrastructure.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly PetshopContext _context;

        public BaseRepository(PetshopContext context)
        {
            _context = context;
        }

        public void AfterDelete(long id)
        {
            
        }

        public void AfterInsert(TEntity entity)
        {
            
        }

        public void AfterUpdate(TEntity entity)
        {
            
        }

        public void BeforeDelete(long id)
        {
            Delete(id);
        }

        public void BeforeInsert(TEntity entity)
        {
            Insert(entity);
        }

        public void BeforeUpdate(TEntity entity)
        {
            Update(entity);
        }

        public void Delete(long id)
        {
            var entity = Get(id);
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public TEntity Get(long id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IList<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }
    }
}
