namespace devdeer.IgSample.Logic.Shared.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Models;

    public interface IEmployeeLogic : ILogic<EmployeeEntity>
    {
        #region methods

        Task<IEnumerable<EmployeeEntity>> GetFiredAsync();

        #endregion
    }
}