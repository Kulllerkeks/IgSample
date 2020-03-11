namespace devdeer.IgSample.Services.CoreApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Logic.Shared.Interfaces;

    using Microsoft.AspNetCore.Mvc;

    public class BaseController<TEntity> : ControllerBase
        where TEntity : IEntity, new()
    {
        #region constructors and destructors

        public BaseController(ILogic<TEntity> logic)
        {
            Logic = logic;
        }

        #endregion

        #region methods

        [HttpGet]
        public async Task<IEnumerable<TEntity>> Get()
        {
            return await Logic.GetAllAsync();
        }

        #endregion

        #region properties

        public ILogic<TEntity> Logic { get; }

        #endregion
    }
}