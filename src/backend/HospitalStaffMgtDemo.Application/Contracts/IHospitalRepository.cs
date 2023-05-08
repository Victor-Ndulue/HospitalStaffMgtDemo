using HospitalStaffMgtDemo.Domain.Models;

namespace HospitalStaffMgtDemo.Application.Contracts
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetAllHospitalAsync(bool trackchanges);
        Task<Hospital> GetHospitalAsync(int  id, bool trackchanges);
        Task<Hospital> GetHospitalByName(string name, bool trackchanges);
        void CreateHospital(Hospital hospital);
        void DeleteteHospital(Hospital hospital);
    }
}
