namespace devdeer.IgSample.Services.CoreApi.Controllers
{
    using System;
    using System.Linq;

    using Logic.Shared.Interfaces;
    using Logic.Shared.Models;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : BaseController<ArticleEntity>
    {
        #region constructors and destructors

        public ArticleController(ILogic<ArticleEntity> logic) : base(logic)
        {
        }

        #endregion
    }
}