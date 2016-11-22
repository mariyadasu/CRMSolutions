using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Core.Entities;
using CRM.Core.ORM;

namespace CRM.Data.Concrete
{
    public interface ITrans_EmployeeMasterRepository
    {
        bool AddEmployee(Trans_EmployeeInfo employee);
        List<Trans_EmployeeInfo> GetEmployees();
        List<Trans_EmployeeSalaryInfo> GetSalaries();
        bool AddEmployeeSalary(Trans_EmployeeSalaryInfo salary);
    }

    public class Trans_EmployeeMasterRepository : ITrans_EmployeeMasterRepository
    {
        private readonly CRMDbContext _dbContext;

        public Trans_EmployeeMasterRepository()
        {
            _dbContext = new CRMDbContext();
        }

        public bool AddEmployee(Trans_EmployeeInfo employee)
        {
            _dbContext.Trans_EmployeeInfoMaster.Add(employee);
            _dbContext.SaveChanges();
            return true;
        }

        public bool AddEmployeeSalary(Trans_EmployeeSalaryInfo salary)
        {
            _dbContext.Trans_EmployeeSalaryInfoMaster.Add(salary);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Trans_EmployeeInfo> GetEmployees()
        {
            //return _dbContext.Trans_EmployeeInfoMaster.ToList();

            List<Trans_EmployeeInfo> employesData = (from emp in _dbContext.Trans_EmployeeInfoMaster
                                           join gender in _dbContext.Lkp_GenderMaster on emp.GenderId equals gender.Id
                                           join branch in _dbContext.Lkp_BrancheMaster on emp.BranchId equals branch.Id
                                           join dep in _dbContext.Lkp_DepartmentMaster on emp.DepartmentId equals dep.Id
                                           join des in _dbContext.Lkp_DesignationMaster on emp.DesignationId equals des.Id
                                           select emp).ToList();

            return employesData;
        }

        public List<Trans_EmployeeSalaryInfo> GetSalaries()
        {
            return _dbContext.Trans_EmployeeSalaryInfoMaster.ToList();
        }
    }
}
