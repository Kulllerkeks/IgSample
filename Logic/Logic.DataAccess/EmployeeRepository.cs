namespace devdeer.IgSample.Logic.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Shared.Models;

    public class EmployeeRepository : BaseRepository<EmployeeEntity>
    {
        #region methods

        protected override IQueryable<EmployeeEntity> GetEntityQuery()
        {
            return new List<EmployeeEntity>
            {
                new EmployeeEntity
                {
                    Id = 1,
                    Firstname = "Horst",
                    Lastname = "Müller"
                },
                new EmployeeEntity
                {
                    Id = 2,
                    Firstname = "Manuela",
                    Lastname = "Meier"
                },
                new EmployeeEntity
                {
                    Id = 3,
                    Firstname = "Sigi",
                    Lastname = "Schlampig",
                    DateFired = DateTimeOffset.Now.Subtract(TimeSpan.FromDays(2))
                }
            }.AsQueryable();
        }

        #endregion
    }
}