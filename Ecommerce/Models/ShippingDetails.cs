using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class ShippingDetails
    {
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please eneter your city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your province.")]
        public string Province { get; set; }

        [Required(ErrorMessage ="Please enter your postal code.")]
        public string PostalCode { get; set; }
    }
}