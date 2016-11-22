using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM.Service.Inventory;
using CRM.Project.Models.Inventory;
using CRM.Core.Entities;
using CRM.Project.Infrastructure;
namespace CRM.Project.Controllers.Inventory
{
    public class InvoiceController : Controller
    {
        private readonly IInventoryService _iInventoryService;
        private readonly ICustomerService _iCustomerService;

        public InvoiceController(IInventoryService iInventoryService, ICustomerService iCustomerService)
        {
            _iInventoryService = iInventoryService;
            _iCustomerService = iCustomerService;
        }

        // GET: Quatation
        public ActionResult Add()
        {
            ViewBag.Customers = new SelectList(_iCustomerService.GetCustomersList(), "Id", "CustmoerCode");
            ViewBag.Products = new SelectList(_iInventoryService.GetProductsList(), "Id", "Name");
            ViewBag.Quantites = new SelectList(_iInventoryService.GetQuantitesList(), "Id", "Name");

            ViewBag.Invoices = _iInventoryService.GetInvoicesList();

            var model = new InvoiceViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(InvoiceViewModel invoice)
        {
            ViewBag.Customers = new SelectList(_iCustomerService.GetCustomersList(), "Id", "CustmoerCode");
            ViewBag.Products = new SelectList(_iInventoryService.GetProductsList(), "Id", "Name");
            ViewBag.Quantites = new SelectList(_iInventoryService.GetQuantitesList(), "Id", "Name");

            ViewBag.Invoices = _iInventoryService.GetInvoicesList();

            if (!ModelState.IsValid)
            {

                return View(invoice);
            }

            var inv = new Trans_InvoiceInfo()
            {
                Cost = invoice.Cost,
                CustomerId = invoice.CustomerId,
                ProductId = invoice.ProductId,
                QuantityId = invoice.QuantityId,
                Tax = invoice.Tax,
                Total = invoice.Cost + invoice.Tax,
                InvoiceNo = string.Format("INVOICE-{0}", ((List<Trans_InvoiceInfo>)ViewBag.Invoices).Count() + 1),
                CreatedDate = Utility.GetDate()
            };

            _iInventoryService.InsertInvoice(inv);
            ViewBag.Invoices = _iInventoryService.GetInvoicesList();
            ViewBag.Msg = "Invoice Added Successfully!";
            return View(new InvoiceViewModel());
        }
    }
}