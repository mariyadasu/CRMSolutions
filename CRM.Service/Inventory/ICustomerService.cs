using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Data.Concrete;
using CRM.Core.Entities;

namespace CRM.Service.Inventory
{
    public interface ICustomerService
    {
        bool InsertCustomer(Trans_CustomerInfo customer);
        List<Trans_CustomerInfo> GetCustomersList();
    }


    public class CustomerService : ICustomerService
    {
        private readonly ITrans_CustomerMasterRepository _iTrans_CustomerMasterRepository;
        public CustomerService(ITrans_CustomerMasterRepository iTrans_CustomerMasterRepository)
        {
            _iTrans_CustomerMasterRepository = iTrans_CustomerMasterRepository;
        }

        public List<Trans_CustomerInfo> GetCustomersList()
        {
            return _iTrans_CustomerMasterRepository.GetCustomers();
        }

        public bool InsertCustomer(Trans_CustomerInfo customer)
        {
            return _iTrans_CustomerMasterRepository.AddCustomer(customer);
        }
    }
}
