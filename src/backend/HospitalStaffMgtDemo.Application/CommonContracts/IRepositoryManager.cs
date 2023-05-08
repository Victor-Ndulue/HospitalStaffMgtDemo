using HospitalStaffMgtDemo.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStaffMgtDemo.Application.CommonContracts
{
    public interface IRepositoryManager
    {
        IStaffRepository staff { get; }
        IHospitalRepository hospital { get; }
        Task SaveAsync();
    }
}
