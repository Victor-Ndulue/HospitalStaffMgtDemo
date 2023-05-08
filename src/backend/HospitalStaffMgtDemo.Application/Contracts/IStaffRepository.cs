using HospitalStaffMgtDemo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStaffMgtDemo.Application.Contracts
{
    public interface IStaffRepository
    {
        Task<IEnumerable<Staff>> GetAllStaffAsync(bool trackchanges);
        Task<Staff> GetStaffByIdAsync(int id, bool trackchanges);
        Task<Staff> GetStaffByNameAsyn(string Firstname, string LastName, bool trackchanges);
        void CreateStaff(Staff staff);
        void DeleteStaff(Staff staff);
    }
}
