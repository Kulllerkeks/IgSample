using System;
using System.Linq;

namespace devdeer.IgSample.Logic.Shared.Models
{
    using System;
    using System.Linq;

    public class EmployeeEntity : BaseEntity
    {
        #region properties

        public DateTimeOffset? DateFired { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        #endregion
    }
}