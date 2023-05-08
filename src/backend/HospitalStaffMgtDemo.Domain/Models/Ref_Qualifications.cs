using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStaffMgtDemo.Domain.Models
{
    public class Ref_Qualifications:AuditableBaseEntity
    {
        public string? Qualification_Title { get; set; }
        public string? Qualification_Description { get; set; }
    }
}
