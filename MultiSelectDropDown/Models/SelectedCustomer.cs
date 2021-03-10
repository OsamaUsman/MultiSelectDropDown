using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultiSelectDropDown.Models
{
    public class SelectedCustomer
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(300)]
        public string AllCustomers { get; set; }
    }
}