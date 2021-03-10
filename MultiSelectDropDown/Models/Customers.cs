using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiSelectDropDown.Models
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<Customers> GetCustomersList { get; set; }
        public string[] CustomersArray { get; set; }


    }
}