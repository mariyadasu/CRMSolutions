using CRM.Service.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM.Project.Models.HR;
using CRM.Core.Entities;

namespace CRM.Project.Controllers.HR
{
    public class EmployeeSalaryController : Controller
    {
        private readonly IEmployeeService _iEmployeeService;

        public EmployeeSalaryController(IEmployeeService iEmployeeService)
        {
            _iEmployeeService = iEmployeeService;
        }

        // GET: EmployeeSalary
        public ActionResult Add()
        {
            var salary = new EmployeeSalaryViewModel();

            ViewBag.Salaries = _iEmployeeService.EmployeeSalariesList();

            return View(salary);
        }

        [HttpPost]
        public ActionResult Add(EmployeeSalaryViewModel salary)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Salaries = _iEmployeeService.EmployeeSalariesList();
                return View(salary);
            }

            var empSsalary = new Trans_EmployeeSalaryInfo()
            {
                AdditionalAllowance=salary.AdditionalAllowance,
                BankAccNo=salary.BankAccNo,
                BasicSalary=salary.BasicSalary,
                ConveyanceAllowance=salary.ConveyanceAllowance,
                DA=salary.DA,
                EmployeeId=salary.EmployeeId,
                HRA=salary.HRA,
                InsurancyPolicyNo=salary.InsurancyPolicyNo,
                PFAccNo=salary.PFAccNo,
                SpacialAllowance=salary.SpacialAllowance,
                TotalSalary=salary.TotalSalary
                
            };
            _iEmployeeService.AddEmployeeSalary(empSsalary);

            ViewBag.Salaries = _iEmployeeService.EmployeeSalariesList();

            ViewBag.Msg = "Employee Salary Added Successfully!";
            
            return View(new EmployeeSalaryViewModel());
        }
    }
}