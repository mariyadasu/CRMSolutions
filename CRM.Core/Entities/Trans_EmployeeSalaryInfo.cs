using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRM.Core.Entities
{
    public class Trans_EmployeeSalaryInfo
    {
        [Key]
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        public virtual Trans_EmployeeInfo Employee { get; set; }

        public int TotalSalary { get; set; }
        public string PFAccNo { get; set; }
        public string BankAccNo { get; set; }
        public string InsurancyPolicyNo { get; set; }
        public int BasicSalary { get; set; }
        public int DA { get; set; }
        public int HRA { get; set; }
        public int ConveyanceAllowance { get; set; }
        public int SpacialAllowance { get; set; }
        public int AdditionalAllowance { get; set; }
    }
}
