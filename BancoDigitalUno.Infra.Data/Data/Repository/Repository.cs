using BancoDigitalUno.Domain.Interfaces.Repository;
using BancoDigitalUno.Infra.Data.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BancoDigitalUno.Infra.Data.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region "Attributes"

        protected readonly BduDbContext _dbContext;

        private readonly DbSet<TEntity> _dbSet;

        #endregion


        #region "Constructor"

        public Repository(BduDbContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = this._dbContext.Set<TEntity>();
        }

        #endregion


        #region "Create"

        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        #endregion


        #region "Recovery"

        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }        

        #endregion


        #region "Update"

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);

            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        #endregion


        #region "Delete"

        public virtual void Delete(object id)
        {
            TEntity entity = _dbSet.Find(id);

            Delete(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _dbSet.Remove(entity);
        }

        #endregion
    }
}
