using System;
using System.Linq;

namespace devdeer.IgSample.Logic.DataAccess.TestRepositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Shared.Models;

    public class TestArticleRepository : BaseRepository<ArticleEntity>
    {
        protected override IQueryable<ArticleEntity> GetEntityQuery()
        {
            return new List<ArticleEntity>
            {
                new ArticleEntity { Id = 1, Number = "TEST-0815" },
                new ArticleEntity { Id = 2, Number = "TEST-0816" }
            }.AsQueryable();
        }
    }
}
