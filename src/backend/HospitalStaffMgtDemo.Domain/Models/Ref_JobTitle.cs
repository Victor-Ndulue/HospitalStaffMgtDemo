namespace HospitalStaffMgtDemo.Domain.Models
{
    public class Ref_JobTitle:AuditableBaseEntity
    {
        public string? Job_Title_Description { get; set; }
        public ICollection<Staff_JobTitles>? Staff_JobTitles { get; set; }
    }
}