using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRM.Project.Models.HR
{
    public class EmployeeRegistrationViewModel
    {
        [Required(ErrorMessage = "Please Enter Employee Code")]
        [Display(Name = "Employee Code")]
        public string EmployeeCode { get; set; }

        [Required(ErrorMessage = "Please Enter Employee Name")]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Please Enter Date Of Birth")]
        [Display(Name = "Date Of Birth")]
        public string DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please Enter Gender")]
        [Display(Name = "Gender")]
        public int GenderId { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter Mobile No")]
        [Display(Name = "Mobile No")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Date Of Joning")]
        [Display(Name = "Date Of Joning")]
        public string DOJ { get; set; }

        [Required(ErrorMessage = "Please Enter Branch")]
        [Display(Name = "Branch")]
        public int BranchId { get; set; }

        [Required(ErrorMessage = "Please Enter Departement")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please Enter Designation")]
        [Display(Name = "Designation")]
        public int DesignationId { get; set; }

        [Required(ErrorMessage = "Please Enter Shift")]
        [Display(Name = "Shift")]
        public int ShiftId { get; set; }
        
    }

    public class EmployeeSalaryViewModel
    {
        [Required(ErrorMessage = "Please Enter Employee Id")]
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Please Enter Total Salary")]
        [Display(Name = "Total Salary")]
        public int TotalSalary { get; set; }

        [Required(ErrorMessage = "Please Enter PF ACC NO")]
        [Display(Name = "PF ACC NO")]
        public string PFAccNo { get; set; }

        [Required(ErrorMessage = "Please Enter Bank ACC NO")]
        [Display(Name = "Bank ACC NO")]
        public string BankAccNo { get; set; }

        [Required(ErrorMessage = "Please Enter Insurancy Policy No")]
        [Display(Name = "Insurancy Policy No")]
        public string InsurancyPolicyNo { get; set; }

        [Required(ErrorMessage = "Please Enter Basic Salary")]
        [Display(Name = "Basic Salary")]
        public int BasicSalary { get; set; }

        [Required(ErrorMessage = "Please Enter DA")]
        [Display(Name = "DA")]
        public int DA { get; set; }

        [Required(ErrorMessage = "Please Enter HRA")]
        [Display(Name = "HRA")]
        public int HRA { get; set; }

        [Required(ErrorMessage = "Please Enter Conveyance Allowance")]
        [Display(Name = "Conveyance Allowance")]
        public int ConveyanceAllowance { get; set; }

        [Required(ErrorMessage = "Please Enter Spacial Allowance")]
        [Display(Name = "Spacial Allowance")]
        public int SpacialAllowance { get; set; }

        [Required(ErrorMessage = "Please Enter Additional Allowance")]
        [Display(Name = "Additional Allowance")]
        public int AdditionalAllowance { get; set; }
        
    }
}