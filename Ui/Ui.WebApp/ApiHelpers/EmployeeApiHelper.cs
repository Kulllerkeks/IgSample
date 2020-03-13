namespace Ui.WebApp.ApiHelpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using devdeer.IgSample.Logic.Shared.Models;

    using Microsoft.Extensions.Configuration;

    using Newtonsoft.Json;

    public class EmployeeApiHelper : BaseApiHelper
    {
        #region constructors and destructors

        public EmployeeApiHelper(HttpClient client, IConfiguration config) : base(client, config)
        {
        }

        #endregion

        #region methods

        public async Task<IEnumerable<EmployeeEntity>> GetAllAsync()
        {
            var result = await Client.GetAsync("Employee");
            var resultText = await result.Content.ReadAsStringAsync();
            var decoded = JsonConvert.DeserializeObject<IEnumerable<EmployeeEntity>>(resultText);
            return decoded;
        }

        #endregion
    }
}