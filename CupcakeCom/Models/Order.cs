using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cupcakecom.Models
{
    public class Order
    {

        public Order()
        {
            OrderDetails=new List<OrderDetails>();
        }
        public int Id { get; set; }
        [Display(Name = "Order No")]
        public string OrderNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        
        public DateTime OrderDate { get; set; }

        public virtual List<OrderDetails> OrderDetails { get; set; }

        [Display(Name = "Application User Id")]
        [Required]
        public Guid ApplicationUserId { get; set; }
        [ForeignKey("Application User")]
        public virtual ApplicationUser User { get; set; }
    }
}
