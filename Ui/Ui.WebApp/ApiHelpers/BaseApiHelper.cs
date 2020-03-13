namespace Ui.WebApp.ApiHelpers
{
    using System;
    using System.Linq;
    using System.Net.Http;

    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Abstract base class for all API helpers.
    /// </summary>
    public abstract class BaseApiHelper
    {
        #region constructors and destructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="client">HTTP client injected by ASP.NET.</param>
        /// <param name="config">Configuration handler.</param>
        public BaseApiHelper(HttpClient client, IConfiguration config)
        {
            client.BaseAddress = new Uri($"{config["Api:BaseUrl"]}");
            Client = client;
        }

        #endregion

        #region properties

        /// <summary>
        /// The injected HTTP client to perform requests against the API.
        /// </summary>
        protected HttpClient Client { get; }

        #endregion
    }
}