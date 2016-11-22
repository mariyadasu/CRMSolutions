using CRM.Project.Models.HR;
using CRM.Service.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM.Service;
using CRM.Core.Entities;
using CRM.Project.Infrastructure;

namespace CRM.Project.Controllers.HR
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _iEmployeeService;
        private readonly ILokpsService _iLokpsService;

        public EmployeeController(IEmployeeService iEmployeeService,ILokpsService iLokpsService)
        {
            _iEmployeeService = iEmployeeService;
            _iLokpsService = iLokpsService;
        }

        // GET: Employee
        public ActionResult Add()
        {
            var employee = new EmployeeRegistrationViewModel();
           
            ViewBag.Gender = new SelectList(_iLokpsService.GetGenders(), "Id", "Name");
            ViewBag.Branches = new SelectList(_iLokpsService.GetBranches(), "Id", "Name"); 
            ViewBag.Departments = new SelectList(_iLokpsService.GetDepartments(), "Id", "Name");
            ViewBag.Designations = new SelectList(_iLokpsService.GetDesignations(), "Id", "Name");
            ViewBag.Shifts = new SelectList(_iLokpsService.GetShifts(), "Id", "Name");

            ViewBag.Employees = _iEmployeeService.EmployeesList();
            return View(employee);
        }

        [HttpPost]
        public ActionResult Add(EmployeeRegistrationViewModel employee)
        {
            if (!ModelState.IsValid)
            {

                ViewBag.Gender = new SelectList(_iLokpsService.GetGenders(), "Id", "Name");
                ViewBag.Branches = new SelectList(_iLokpsService.GetBranches(), "Id", "Name");
                ViewBag.Departments = new SelectList(_iLokpsService.GetDepartments(), "Id", "Name");
                ViewBag.Designations = new SelectList(_iLokpsService.GetDesignations(), "Id", "Name");
                ViewBag.Shifts = new SelectList(_iLokpsService.GetShifts(), "Id", "Name");

                ViewBag.Employees = _iEmployeeService.EmployeesList();

                return View(employee);
            }

            var emp = new Trans_EmployeeInfo()
            {
                Address = employee.Address,
                BranchId = employee.BranchId,
                CreatedBy = 1,
                DateOfBirth = Utility.ConvertStringToDate(employee.DateOfBirth),
                DepartmentId = employee.DepartmentId,
                DesignationId = employee.DesignationId,
                DOJ = Utility.ConvertStringToDate(employee.DOJ),
                Email = employee.Email,
                EmployeeCode = employee.EmployeeCode,
                GenderId = employee.GenderId,
                PhoneNo = employee.PhoneNo,
                ShiftId = employee.ShiftId,
                EmployeeName=employee.EmployeeName
            };
            _iEmployeeService.AddEmployee(emp);

            ViewBag.Msg = "Employee Added Successfully!";
            ViewBag.Gender = new SelectList(_iLokpsService.GetGenders(), "Id", "Name");
            ViewBag.Branches = new SelectList(_iLokpsService.GetBranches(), "Id", "Name");
            ViewBag.Departments = new SelectList(_iLokpsService.GetDepartments(), "Id", "Name");
            ViewBag.Designations = new SelectList(_iLokpsService.GetDesignations(), "Id", "Name");
            ViewBag.Shifts = new SelectList(_iLokpsService.GetShifts(), "Id", "Name");

            ViewBag.Employees = _iEmployeeService.EmployeesList();
            return View(new EmployeeRegistrationViewModel());
        }

       
    }
}