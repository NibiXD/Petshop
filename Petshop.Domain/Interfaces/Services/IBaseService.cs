using FluentValidation;

namespace Petshop.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();
        TEntity Get(long id);
        TEntity Add(TEntity entity);
        void BeforeAdd<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>;
        void AfterAdd<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>;
        TEntity Update(TEntity entity);
        void BeforeUpdate<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>;
        void AfterUpdate<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>;
        void Delete(long id);
        void BeforeDelete(long id);
        void AfterDelete(long id);
    }
}
