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
    public class QuatationController : Controller
    {

        private readonly IInventoryService _iInventoryService;
        private readonly ICustomerService _iCustomerService;

        public QuatationController(IInventoryService iInventoryService, ICustomerService iCustomerService)
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

            ViewBag.Quatations = _iInventoryService.GetQuatationsList();

            var model = new QuatationViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(QuatationViewModel quatation)
        {
            ViewBag.Customers = new SelectList(_iCustomerService.GetCustomersList(), "Id", "CustmoerCode");
            ViewBag.Products = new SelectList(_iInventoryService.GetProductsList(), "Id", "Name");
            ViewBag.Quantites = new SelectList(_iInventoryService.GetQuantitesList(), "Id", "Name");

            ViewBag.Quatations = _iInventoryService.GetQuatationsList();

            if (!ModelState.IsValid)
            {
                
                return View(quatation);
            }

            var quat = new Trans_Quatation()
            {
                Cost = quatation.Cost,
                CustomerId = quatation.CustomerId,
                QuateDate = Utility.ConvertStringToDate(quatation.QuadationDate),
                ProductId = quatation.ProductId,
                QuantityId = quatation.QuantityId,
                Tax = quatation.Tax,
                Total = quatation.Cost + quatation.Tax,
                RefNo = string.Format("REF-{0}", ((List<Trans_Quatation>)ViewBag.Quatations).Count() + 1),
                CreatedDate = Utility.GetDate()
            };

            _iInventoryService.InsertQuatation(quat);
            ViewBag.Quatations = _iInventoryService.GetQuatationsList();
            ViewBag.Msg = "Quatation Added Successfully!";
            return View(new QuatationViewModel());
        }
    }
}