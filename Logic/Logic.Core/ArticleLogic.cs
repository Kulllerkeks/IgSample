namespace devdeer.IgSample.Logic.Core
{
    using System;
    using System.Linq;

    using Shared.Interfaces;
    using Shared.Models;

    public class ArticleLogic : BaseLogic<ArticleEntity>, IArticleLogic
    {
        #region constructors and destructors

        public ArticleLogic(IRepository<ArticleEntity> repository) : base(repository)
        {
        }

        #endregion
    }
}