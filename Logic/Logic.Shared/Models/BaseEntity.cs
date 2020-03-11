using System;
using System.Linq;

namespace devdeer.IgSample.Logic.Shared.Models
{
    using System;
    using System.Linq;

    using Interfaces;

    public abstract class BaseEntity : IEntity
    {
        #region explicit interfaces

        public long Id { get; set; }

        #endregion
    }
}