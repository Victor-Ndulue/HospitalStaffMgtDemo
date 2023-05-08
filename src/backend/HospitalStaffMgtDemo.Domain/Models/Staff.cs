using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStaffMgtDemo.Domain.Models
{
    public class Staff:AuditableBaseEntity
    {
        [ForeignKey (nameof (StaffAddress))]
        public int Staff_Address_Id { get; set; }
        [ForeignKey (nameof (Hospital))]
        public int Staff_Hospital_Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public DateTime BirthDate { get; set; }
        public string? Gender { get; set; }
        public DateTime Date_Joined_Hospital { get; set; }
        public DateTime Date_Left_Hospital { get; set; }
        public string? DepartmentName { get; set; }
        public string? Staff_Position { get; set; }
        public StaffAddress? StaffAddress { get; set; }
        public Hospital? Hospital { get; set; }
        public ICollection <Staff_JobTitles>? Staff_JobTitles { get; set; }
        public ICollection<Staff_Ward_Assignments>? Staff_Ward_Assignments { get; set; }
    }
}
