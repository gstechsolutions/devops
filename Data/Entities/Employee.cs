using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tempus.service.core.api.Data.Entities
{
    [Table ("tblEmployee")]
    public class Employee
    {
        //this is the PK
        [Key]
        public long EmployeeID { get; set; }

        public long? HomeCompanyID { get; set; }

        public long? HomeCompanyDepartmentID { get; set; }
    }
}
