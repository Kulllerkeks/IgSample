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

    /// <summary>
    /// API helper for communication towards the Employee API.
    /// </summary>
    public class EmployeeApiHelper : BaseApiHelper
    {
        #region constructors and destructors

        /// <inheritdoc />
        public EmployeeApiHelper(HttpClient client, IConfiguration config) : base(client, config)
        {
        }

        #endregion

        #region methods

        /// <summary>
        /// Retrieves a list of all employees from the API.
        /// </summary>
        /// <returns>The list of employees.</returns>
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