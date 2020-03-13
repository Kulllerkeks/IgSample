namespace Ui.WebApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

    using ApiHelpers;

    using devdeer.IgSample.Logic.Shared.Models;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;

    using Newtonsoft.Json;

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        #region member vars

        private readonly EmployeeApiHelper _apiHelper;

        #endregion

        #region constructors and destructors

        public EmployeeController(EmployeeApiHelper helper)
        {
            _apiHelper = helper;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeEntity>> Get()
        {
            return await _apiHelper.GetAllAsync();
        }

        #endregion
    }
}