namespace Ui.WebApp.ApiHelpers
{
    using System;
    using System.Linq;
    using System.Net.Http;

    using Microsoft.Extensions.Configuration;

    public abstract class BaseApiHelper
    {
        #region constructors and destructors

        public BaseApiHelper(HttpClient client, IConfiguration config)
        {
            client.BaseAddress = new Uri($"{config["Api:BaseUrl"]}");
            Client = client;
        }

        #endregion

        #region properties

        protected HttpClient Client { get; }

        #endregion
    }
}