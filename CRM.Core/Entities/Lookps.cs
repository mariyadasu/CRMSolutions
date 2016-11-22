using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.Entities
{
    public class Lkp_Gender
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public virtual ICollection<Trans_EmployeeInfo> Employees { get; set; }
    }

    public class Lkp_Branche
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public virtual ICollection<Trans_EmployeeInfo> Employees { get; set; }
    }

    public class Lkp_Department
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public virtual ICollection<Trans_EmployeeInfo> Employees { get; set; }
    }

    public class Lkp_Designation
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public virtual ICollection<Trans_EmployeeInfo> Employees { get; set; }
    }

    public class Lkp_Shift
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public virtual ICollection<Trans_EmployeeInfo> Employees { get; set; }
    }
}
