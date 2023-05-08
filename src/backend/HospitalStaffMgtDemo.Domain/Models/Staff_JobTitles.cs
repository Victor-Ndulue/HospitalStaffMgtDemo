using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStaffMgtDemo.Domain.Models
{
    public class Staff_JobTitles : AuditableBaseEntity
    {
        [ForeignKey(nameof(Ref_JobTitle))]
        public int Ref_JobTitle_Code { get; set; }
        [ForeignKey(nameof(Staff))]
        public int Staff_Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Ref_JobTitle? Ref_JobTitle { get; set; }
        public Staff? Staff { get; set; }
    }
}
