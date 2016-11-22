using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Core.Entities
{
     public class Trans_ProductInfo
    {
        [Key]
        public int Id { get; set; }
        public string  Name { get; set; }

        public virtual ICollection<Trans_Quantity> Quantites { get; set; }
        public virtual ICollection<Trans_Quatation> Quatations { get; set; }

    }
}
