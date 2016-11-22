using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Core.Entities;
using CRM.Core.ORM;

namespace CRM.Data.Concrete
{
    public interface ITrans_CustomerMasterRepository
    {
        bool AddCustomer(Trans_CustomerInfo customer);
        List<Trans_CustomerInfo> GetCustomers();
    }

    public class Trans_CustomerMasterRepository : ITrans_CustomerMasterRepository
    {
        private readonly CRMDbContext _dbContext;

        public Trans_CustomerMasterRepository()
        {
            _dbContext = new CRMDbContext();
        }

        public bool AddCustomer(Trans_CustomerInfo customer)
        {
            _dbContext.Trans_CustomerInfoMaster.Add(customer);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Trans_CustomerInfo> GetCustomers()
        {
           return _dbContext.Trans_CustomerInfoMaster.ToList();
        }
    }
}
