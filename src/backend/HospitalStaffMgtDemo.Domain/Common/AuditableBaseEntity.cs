using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStaffMgtDemo.Domain
{
    public abstract class AuditableBaseEntity
    {
        public int Id { get; set; } //the Id represents our primary key  
        public string? CreatedBy { get; set; }
        public DateTime DateCreated { get; set;} = DateTime.Now;
        public string? ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}
