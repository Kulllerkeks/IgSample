using System;
using System.Collections.Generic;
using System.Text;

namespace devdeer.IgSample.Logic.DataAccess
{
    using System.Linq;
    using System.Threading.Tasks;

    using Shared.Interfaces;

    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity, new()
    {
        public virtual Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var query = GetEntityQuery();
            var entities = query.ToList();
            return Task.FromResult(entities.AsEnumerable());
        }

        protected abstract IQueryable<TEntity> GetEntityQuery();
    }
}
