using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Core.Entities;

namespace CRM.Core.ORM
{

    public class CRMDbContext : DbContext
    {
        public DbSet<Trans_UserInfo> Trans_UserInfoMaster { get; set; }

        //HR
        public DbSet<Trans_EmployeeInfo> Trans_EmployeeInfoMaster { get; set; }
        public DbSet<Trans_EmployeeSalaryInfo> Trans_EmployeeSalaryInfoMaster { get; set; }


        //Inventory
        public DbSet<Trans_CustomerInfo> Trans_CustomerInfoMaster { get; set; }
        public DbSet<Trans_Quantity> Trans_QuantityMaster { get; set; }
        public DbSet<Trans_ProductInfo> Trans_ProductInfoMaster { get; set; }
        public DbSet<Trans_Quatation> Trans_QuatationMaster { get; set; }
        public DbSet<Trans_InvoiceInfo> Trans_InvoiceInfoMaster { get; set; }

        //Lookps
        public DbSet<Lkp_Branche> Lkp_BrancheMaster { get; set; }
        public DbSet<Lkp_Department> Lkp_DepartmentMaster { get; set; }
        public DbSet<Lkp_Designation> Lkp_DesignationMaster { get; set; }
        public DbSet<Lkp_Gender> Lkp_GenderMaster { get; set; }
        public DbSet<Lkp_Shift> Lkp_ShiftsMaster { get; set; }

    }
}
