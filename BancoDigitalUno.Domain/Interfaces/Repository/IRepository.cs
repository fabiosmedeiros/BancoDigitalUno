using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BancoDigitalUno.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region "Create"

        void Add(TEntity entity);

        #endregion


        #region "Recovery"

        TEntity GetById(object id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        #endregion


        #region "Update"

        void Update(TEntity entity);

        #endregion


        #region "Delete"

        void Delete(object id);

        void Delete(TEntity entity);

        #endregion
    }
}
