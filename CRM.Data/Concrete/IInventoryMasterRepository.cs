using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Core.Entities;
using CRM.Core.ORM;

namespace CRM.Data.Concrete
{
    public interface IInventoryMasterRepository
    {
        List<Trans_ProductInfo> GetProducts();
        List<Trans_Quantity> GetQuantites();

        List<Trans_Quatation> GetQuatations();
        bool AddQuatation(Trans_Quatation quatation);

        List<Trans_InvoiceInfo> GetInvoices();
        bool AddInvoice(Trans_InvoiceInfo invoice);
    }

    public class InventoryMasterRepository : IInventoryMasterRepository
    {
        private readonly CRMDbContext _dbContext;

        public InventoryMasterRepository()
        {
            _dbContext = new CRMDbContext();
        }

        public List<Trans_ProductInfo> GetProducts()
        {
            return _dbContext.Trans_ProductInfoMaster.ToList();
        }

        public List<Trans_Quatation> GetQuatations()
        {
            return _dbContext.Trans_QuatationMaster.ToList();
        }

        public List<Trans_Quantity> GetQuantites()
        {
            return _dbContext.Trans_QuantityMaster.ToList();
        }

        public bool AddQuatation(Trans_Quatation quatation)
        {
            _dbContext.Trans_QuatationMaster.Add(quatation);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Trans_InvoiceInfo> GetInvoices()
        {
            return _dbContext.Trans_InvoiceInfoMaster.ToList();
        }

        public bool AddInvoice(Trans_InvoiceInfo invoice)
        {
            _dbContext.Trans_InvoiceInfoMaster.Add(invoice);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
