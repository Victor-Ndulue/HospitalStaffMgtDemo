using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStaffMgtDemo.Domain.Models
{
    public class Wards:AuditableBaseEntity
    {
        public string? Ward_Name { get; set; }
        public string? Ward_Location { get; set; }
        public string? Ward_Description { get; set; }
    }
}
