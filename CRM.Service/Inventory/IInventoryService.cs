using CRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Data.Concrete;

namespace CRM.Service.Inventory
{
    public interface IInventoryService
    {
        List<Trans_ProductInfo> GetProductsList();
        List<Trans_Quantity> GetQuantitesList();

        List<Trans_Quatation> GetQuatationsList();
        bool InsertQuatation(Trans_Quatation quatation);

        List<Trans_InvoiceInfo> GetInvoicesList();
        bool InsertInvoice(Trans_InvoiceInfo quatation);
    }

    public class InventoryService : IInventoryService
    {
        private readonly IInventoryMasterRepository _iInventoryMasterRepository;
        public InventoryService(IInventoryMasterRepository iInventoryMasterRepository)
        {
            _iInventoryMasterRepository = iInventoryMasterRepository;
        }

        public bool InsertQuatation(Trans_Quatation quatation)
        {
           return _iInventoryMasterRepository.AddQuatation(quatation);
        }

        public List<Trans_ProductInfo> GetProductsList()
        {
            return _iInventoryMasterRepository.GetProducts();
        }

        public List<Trans_Quantity> GetQuantitesList()
        {
            return _iInventoryMasterRepository.GetQuantites();
        }

        public List<Trans_Quatation> GetQuatationsList()
        {
            return _iInventoryMasterRepository.GetQuatations();
        }

        public List<Trans_InvoiceInfo> GetInvoicesList()
        {
            return _iInventoryMasterRepository.GetInvoices();
        }

        public bool InsertInvoice(Trans_InvoiceInfo invoice)
        {
            return _iInventoryMasterRepository.AddInvoice(invoice);
        }
    }
    }
