using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CRM.Data.Concrete;
using CRM.Service.Authentication;
using CRM.Service.HR;
using CRM.Service;
using CRM.Service.Inventory;

namespace CRM.Project.Infrastructure
{
    public class DependencyInjection : DefaultControllerFactory
    {
        private IKernel ninjectKernal;

        public DependencyInjection()
        {
            ninjectKernal = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernal.Get(controllerType);
        }

        private void AddBindings()
        {
            //Data
            ninjectKernal.Bind<ITrans_UserInfoMasterRepository>().To<Trans_UserInfoMasterRepository>();
            ninjectKernal.Bind<ITrans_EmployeeMasterRepository>().To<Trans_EmployeeMasterRepository>();
            ninjectKernal.Bind<ILokps_MasterRepository>().To<Lokps_MasterRepository>();

            ninjectKernal.Bind<ITrans_CustomerMasterRepository>().To<Trans_CustomerMasterRepository>();
            ninjectKernal.Bind<IInventoryMasterRepository>().To<InventoryMasterRepository>();

            //Services
            ninjectKernal.Bind<IAuthenticationService>().To<AuthenticationService>();
            ninjectKernal.Bind<IEmployeeService>().To<EmployeeService>();
            ninjectKernal.Bind<ILokpsService>().To<LokpsService>();

            ninjectKernal.Bind<ICustomerService>().To<CustomerService>();
            ninjectKernal.Bind<IInventoryService>().To<InventoryService>();
        }
    }
}