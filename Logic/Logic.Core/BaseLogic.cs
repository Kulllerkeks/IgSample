namespace devdeer.IgSample.Logic.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Shared.Interfaces;

    public abstract class BaseLogic<TEntity> : ILogic<TEntity>
        where TEntity : IEntity, new()
    {
        #region constructors and destructors

        protected BaseLogic(IRepository<TEntity> repository)
        {
            Repository = repository;
        }

        #endregion

        #region explicit interfaces

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Repository.GetAllAsync();
        }

        #endregion

        #region properties

        protected IRepository<TEntity> Repository { get; }

        #endregion
    }
}