using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiSelectDropDown.Models
{
    public class EmpViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public DateTime JoinDate { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public bool IsActive { get; set; }

        public string Country { get; set; }

        public string[] CountryArr { get; set; }
        

    }
   

}