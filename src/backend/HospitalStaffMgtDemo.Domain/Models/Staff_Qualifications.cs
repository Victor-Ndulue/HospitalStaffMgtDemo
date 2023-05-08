using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStaffMgtDemo.Domain.Models
{
    public class Staff_Qualifications
    {
        public int Staff_Id { get; set; }
        public int Qualification_Code { get; set; }
        public DateTime Date_Obtained { get; set; }
    }
}
