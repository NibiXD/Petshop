namespace Petshop.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public IList<TEntity> GetAll();
        public TEntity Get(long id);
        public void Insert(TEntity entity);
        public void BeforeInsert(TEntity entity);
        public void AfterInsert(TEntity entity);
        public void Update(TEntity entity);
        public void BeforeUpdate(TEntity entity);
        public void AfterUpdate(TEntity entity);
        public void Delete(long id);
        public void BeforeDelete(long id);
        public void AfterDelete(long id);
    }
}
