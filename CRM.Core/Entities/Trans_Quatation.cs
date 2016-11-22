using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.Entities
{
    public class Trans_Quatation
    {
        [Key]
        public int Id { get; set; }

        public string RefNo { get; set; }
        public DateTime QuateDate { get; set; }

        public int CustomerId { get; set; }
        public virtual Trans_CustomerInfo Customer { get; set; }

        public int ProductId { get; set; }
        public virtual Trans_ProductInfo Product { get; set; }

        public int QuantityId { get; set; }
        public virtual Trans_Quantity Quantity { get; set; }

        public int Cost { get; set; }
        public int Tax { get; set; }
        public int Total { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
