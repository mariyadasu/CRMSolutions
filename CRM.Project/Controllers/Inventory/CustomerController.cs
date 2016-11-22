using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM.Project.Models.Inventory;
using CRM.Service.Inventory;
using CRM.Core.Entities;
using CRM.Project.Infrastructure;


namespace CRM.Project.Controllers.Inventory
{
    public class CustomerController : Controller
    {

        private readonly ICustomerService _iCustomerService;

        public CustomerController(ICustomerService iCustomerService)
        {
            _iCustomerService = iCustomerService;
        }

        // GET: Customer
        public ActionResult Add()
        {
            var customer = new CustomerViewModel();

            ViewBag.Customers = _iCustomerService.GetCustomersList();
            return View(customer);
        }

        [HttpPost]
        public ActionResult Add(CustomerViewModel customer)
        {
            ViewBag.Customers = _iCustomerService.GetCustomersList();
            if (!ModelState.IsValid)
            {
                return View(customer);
            }

            var cust = new Trans_CustomerInfo()
            {
                Address = customer.Address,
                CreatedDate = Utility.GetDate(),
                CustomerName = customer.CustomerName,
                Email = customer.Email,
                MobileNo = customer.MobileNo,
                CustmoerCode =string.Format("CUST{0}", ((List<Trans_CustomerInfo>)ViewBag.Customers).Count() + 1),
                Status = 1
            };
            _iCustomerService.InsertCustomer(cust);

            ViewBag.Msg = "Customer Added Successfully!";
            
            return View(new CustomerViewModel());
        }


    }
}