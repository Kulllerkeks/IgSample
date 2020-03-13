namespace Ui.WebApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

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

        private readonly ILogger<EmployeeController> _logger;

        private readonly IConfiguration _config;

        #endregion

        #region constructors and destructors

        public EmployeeController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeEntity>> Get()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri($"{_config["Api:BaseUrl"]}")
            };
            var result = await client.GetAsync("Employee");
            var resultText = await result.Content.ReadAsStringAsync();
            var decoded = JsonConvert.DeserializeObject<IEnumerable<EmployeeEntity>>(resultText);
            return decoded;
        }

        #endregion
    }
}