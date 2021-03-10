using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MultiSelectDropDown.Models
{
    public class CustomerDBContext  : DbContext
    {
        public DbSet<TblCustomer> TblCustomers { get; set; }
        public DbSet<SelectedCustomer> SelectedCustomers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<MultiSelectDropDown.Models.EmpViewModel> EmpViewModels { get; set; }
    }
}