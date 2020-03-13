namespace devdeer.IgSample.Ui.Old
{
    using System;
    using System.Linq;

    public class EmployeeEntity
    {
        #region properties

        public DateTimeOffset? DateFired { get; set; }

        public string Firstname { get; set; }

        public long Id { get; set; }

        public string Lastname { get; set; }

        #endregion
    }
}