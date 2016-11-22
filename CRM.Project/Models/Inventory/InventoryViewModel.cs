using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRM.Project.Models.Inventory
{
    public class QuatationViewModel
    {
        [Required(ErrorMessage = "Please Enter Customer Code")]
        [Display(Name = "Customer Code")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please Enter Quadation Date")]
        [Display(Name = "Quadation Date")]
        public string QuadationDate { get; set; }

        [Required(ErrorMessage = "Please Enter Product")]
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please Enter Quantity")]
        [Display(Name = "Quantity")]
        public int QuantityId { get; set; }

        [Required(ErrorMessage = "Please Enter Cost")]
        [Display(Name = "Cost")]
        public int Cost { get; set; }

        [Required(ErrorMessage = "Please Enter Tax")]
        [Display(Name = "Tax")]
        public int Tax { get; set; }

    }

    public class InvoiceViewModel
    {
        [Required(ErrorMessage = "Please Enter Customer Code")]
        [Display(Name = "Customer Code")]
        public int CustomerId { get; set; }

        
        [Required(ErrorMessage = "Please Enter Product")]
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please Enter Quantity")]
        [Display(Name = "Quantity")]
        public int QuantityId { get; set; }

        [Required(ErrorMessage = "Please Enter Cost")]
        [Display(Name = "Cost")]
        public int Cost { get; set; }

        [Required(ErrorMessage = "Please Enter Tax")]
        [Display(Name = "Tax")]
        public int Tax { get; set; }

    }
}