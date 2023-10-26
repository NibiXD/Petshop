using FluentValidation;
using Petshop.Domain.Entities;
using Petshop.Domain.Interfaces.Repositories;
using Petshop.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Service.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _repository;
        private readonly IValidator<TEntity> _validator;

        public BaseService(
            IBaseRepository<TEntity> repository,
            IValidator<TEntity> validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public TEntity Add(TEntity entity)
        {
            _repository.Insert(entity);
            return entity;
        }

        public void AfterAdd<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>
        {
            _repository.AfterInsert(entity);
        }

        public void AfterDelete(long id)
        {
            _repository.AfterDelete(id);
        }

        public void AfterUpdate<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>
        {
            _repository.AfterUpdate(entity);
        }

        public void BeforeAdd<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>
        {
            Validate(entity, Activator.CreateInstance<TValidator>());
            Add(entity);
        }

        public void BeforeDelete(long id)
        {
            _repository.BeforeDelete(id);
        }

        public void BeforeUpdate<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>
        {
            Validate(entity, Activator.CreateInstance<TValidator>());
            Update(entity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public TEntity Get(long id)
        {
            return _repository.Get(id);
        }

        public IList<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity Update(TEntity entity)
        {
            _repository.Update(entity); 
            return entity;
        }

        private void Validate(TEntity entity, AbstractValidator<TEntity> validator)
        {
            if (entity == null)
                throw new Exception("Entry not detected!");

            validator.ValidateAndThrow(entity);
        }
    }
}
