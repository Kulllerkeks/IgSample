namespace devdeer.IgSample.Logic.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Shared.Interfaces;
    using Shared.Models;

    public class EmployeeLogic : BaseLogic<EmployeeEntity>, IEmployeeLogic
    {
        #region constructors and destructors

        public EmployeeLogic(IRepository<EmployeeEntity> repository) : base(repository)
        {
        }

        #endregion

        #region explicit interfaces

        public async Task<IEnumerable<EmployeeEntity>> GetFiredAsync()
        {
            var all = await Repository.GetAllAsync();
            return all.Where(e => e.DateFired.HasValue);
        }

        #endregion
    }
}