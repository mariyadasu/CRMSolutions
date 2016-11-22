using CRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Data.Concrete;

namespace CRM.Service
{
    public interface ILokpsService
    {
        List<Lkp_Branche> GetBranches();
        List<Lkp_Department> GetDepartments();
        List<Lkp_Designation> GetDesignations();
        List<Lkp_Gender> GetGenders();
        List<Lkp_Shift> GetShifts();
    }

    public class LokpsService : ILokpsService
    {
        private readonly ILokps_MasterRepository _iLokps_MasterRepository;
        public LokpsService(ILokps_MasterRepository iLokps_MasterRepository)
        {
            _iLokps_MasterRepository = iLokps_MasterRepository;
        }

        public List<Lkp_Branche> GetBranches()
        {
            return _iLokps_MasterRepository.GetBranches();
        }

        public List<Lkp_Department> GetDepartments()
        {
            return _iLokps_MasterRepository.GetDepartments();
        }

        public List<Lkp_Designation> GetDesignations()
        {
            return _iLokps_MasterRepository.GetDesignations();
        }

        public List<Lkp_Gender> GetGenders()
        {
            return _iLokps_MasterRepository.GetGenders();
        }

        public List<Lkp_Shift> GetShifts()
        {
            return _iLokps_MasterRepository.GetShifts();
        }
    }
}
