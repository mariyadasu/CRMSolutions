using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.Entities
{
    public class Trans_EmployeeInfo
    {
        [Key]
        public int Id { get; set; }

        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int GenderId { get; set; }
        public virtual  Lkp_Gender Gender { get; set; }

        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public DateTime DOJ { get; set; }


        public int BranchId { get; set; }
        public virtual  Lkp_Branche Branch { get; set; }

        public int DepartmentId { get; set; }
        public virtual  Lkp_Department Department { get; set; }


        public int DesignationId { get; set; }
        public virtual  Lkp_Designation Designation { get; set; }


        public int ShiftId { get; set; }
        public virtual  Lkp_Shift Shift { get; set; }
       
        public int CreatedBy { get; set; }

        public virtual ICollection<Trans_EmployeeSalaryInfo> Salary { get; set; }

    }
}
