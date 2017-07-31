using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFoundation.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        [MinLength(5)]
        public string FirstName { get; set; }

        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }

    }
}