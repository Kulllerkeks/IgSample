namespace devdeer.IgSample.Services.CoreApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Logic.Shared.Interfaces;
    using Logic.Shared.Models;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : BaseController<EmployeeEntity>
    {
        #region constructors and destructors

        public EmployeeController(ILogic<EmployeeEntity> logic) : base(logic)
        {
        }

        #endregion

        #region methods

        [HttpGet]
        [Route("Fired")]
        public async Task<IEnumerable<EmployeeEntity>> GetFired()
        {
            var specificLogic = Logic as IEmployeeLogic;
            return await specificLogic.GetFiredAsync();
        }

        #endregion
    }
}