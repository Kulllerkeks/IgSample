namespace devdeer.IgSample.Logic.Shared.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ILogic<TEntity>
        where TEntity : IEntity, new()
    {
        #region methods

        Task<IEnumerable<TEntity>> GetAllAsync();

        #endregion
    }
}