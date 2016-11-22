using CRM.Core.Entities;
using CRM.Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Service.HR
{
    public interface IEmployeeService
    {
        bool AddEmployee(Trans_EmployeeInfo employee);
        List<Trans_EmployeeInfo> EmployeesList();
        List<Trans_EmployeeSalaryInfo> EmployeeSalariesList();
        bool AddEmployeeSalary(Trans_EmployeeSalaryInfo salary);
    }

    public class EmployeeService : IEmployeeService
    {
        private readonly ITrans_EmployeeMasterRepository _iTrans_EmployeeMasterRepository;
        public EmployeeService(ITrans_EmployeeMasterRepository iTrans_EmployeeMasterRepository)
        {
            _iTrans_EmployeeMasterRepository = iTrans_EmployeeMasterRepository;
        }

        public bool AddEmployee(Trans_EmployeeInfo employee)
        {
            return _iTrans_EmployeeMasterRepository.AddEmployee(employee);
        }

        public bool AddEmployeeSalary(Trans_EmployeeSalaryInfo salary)
        {
            return _iTrans_EmployeeMasterRepository.AddEmployeeSalary(salary);
        }

        public List<Trans_EmployeeSalaryInfo> EmployeeSalariesList()
        {
            return _iTrans_EmployeeMasterRepository.GetSalaries();
        }

        public List<Trans_EmployeeInfo> EmployeesList()
        {
            return _iTrans_EmployeeMasterRepository.GetEmployees();
        }
    }
}
