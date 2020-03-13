namespace Ui.WebApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ApiHelpers;

    using devdeer.IgSample.Logic.Shared.Models;

    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// API controller exposing endpoints for React for targetting Employee-related data.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        #region member vars

        private readonly EmployeeApiHelper _apiHelper;

        #endregion

        #region constructors and destructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="helper">The API helper for Employee backend data.</param>
        public EmployeeController(EmployeeApiHelper helper)
        {
            _apiHelper = helper;
        }

        #endregion

        #region methods

        /// <summary>
        /// Retrieves a list of all employees from the API.
        /// </summary>
        /// <returns>The list of employees.</returns>
        [HttpGet]
        public async Task<IEnumerable<EmployeeEntity>> Get()
        {
            return await _apiHelper.GetAllAsync();
        }

        #endregion
    }
}