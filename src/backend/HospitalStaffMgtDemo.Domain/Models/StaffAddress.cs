using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStaffMgtDemo.Domain.Models
{
    public class StaffAddress: AuditableBaseEntity
    { 
        public int BuildingNumber { get; set; }
        public string? StreetName { get; set; }
        public string? Area_locality { get; set; }
        public string? Landmark { get; set; }
        public string? City { get; set; }
        public int Zip_PostalCode { get; set; }
        public string? State_Province { get; set; }

        public ICollection<Staff>? Staff { get; set; }
    }
}
