using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultiSelectDropDown.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        
        public DateTime JoinDate { get; set; }
        
        public Gender  Gender { get; set; }
        
        public int Age  { get; set; }
        
        public bool IsActive  { get; set; }
        
        [StringLength(500)]
        public string Country  { get; set; }

    }
   public enum Gender
    {
        Male ,
        Female
    } 
}