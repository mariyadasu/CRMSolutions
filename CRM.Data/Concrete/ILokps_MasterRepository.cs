using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Core.Entities;
using CRM.Core.ORM;

namespace CRM.Data.Concrete
{
    public interface ILokps_MasterRepository
    {
        List<Lkp_Branche> GetBranches();
        List<Lkp_Department> GetDepartments();
        List<Lkp_Designation> GetDesignations();
        List<Lkp_Gender> GetGenders();
        List<Lkp_Shift> GetShifts();
    }

    public class Lokps_MasterRepository : ILokps_MasterRepository
    {
        private readonly CRMDbContext _dbContext;

        public Lokps_MasterRepository()
        {
            _dbContext = new CRMDbContext();
        }

        public List<Lkp_Branche> GetBranches()
        {
           return _dbContext.Lkp_BrancheMaster.ToList();
        }

        public List<Lkp_Department> GetDepartments()
        {
            return _dbContext.Lkp_DepartmentMaster.ToList();
        }

        public List<Lkp_Designation> GetDesignations()
        {
            return _dbContext.Lkp_DesignationMaster.ToList();
        }

        public List<Lkp_Gender> GetGenders()
        {
            return _dbContext.Lkp_GenderMaster.ToList();
        }

        public List<Lkp_Shift> GetShifts()
        {
            return _dbContext.Lkp_ShiftsMaster.ToList();
        }
    }
}
