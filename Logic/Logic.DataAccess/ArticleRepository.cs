using System;
using System.Collections.Generic;
using System.Text;

namespace devdeer.IgSample.Logic.DataAccess
{
    using System.Linq;

    using Shared.Models;

    public class ArticleRepository : BaseRepository<ArticleEntity>
    {
        protected override IQueryable<ArticleEntity> GetEntityQuery()
        {
            return new List<ArticleEntity>
            {
                new ArticleEntity { Id = 1, Number = "0815" },
                new ArticleEntity { Id = 2, Number = "0816" }
            }.AsQueryable();
        }
    }
}
