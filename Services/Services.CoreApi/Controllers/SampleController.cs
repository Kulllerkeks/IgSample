namespace devdeer.IgSample.Services.CoreApi.Controllers
{
    using System;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        #region methods

        /// <summary>
        /// Inverses a given <paramref name="sample" /> string and retrieves it.
        /// </summary>
        /// <param name="sample">The text to reverse.</param>
        /// <returns>The reversed text.</returns>
        [HttpGet]
        [Route("ReverseString/{sample}")]
        public string Get(string sample)
        {
            return new string(sample.Reverse().ToArray());
        }

        #endregion
    }
}