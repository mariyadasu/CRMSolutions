using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.Entities
{
    public class Trans_CustomerInfo
    {
        [Key]
        public int Id { get; set; }

        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int Status { get; set; }
        public string CustmoerCode { get; set; }

        public virtual ICollection<Trans_Quatation> Quatations { get; set; }
        public virtual ICollection<Trans_InvoiceInfo> Invoices { get; set; }
    }
}
