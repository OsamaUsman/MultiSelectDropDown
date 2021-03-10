using MultiSelectDropDown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiSelectDropDown.Controllers
{
    public class CutomersController : Controller
    {
        // GET: Cutomers
        CustomerDBContext db = new CustomerDBContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChosenDropDown()
        {
            CustomerDBContext db = new CustomerDBContext();
            Customers objCus = new Customers();
            
            objCus.GetCustomersList = db.TblCustomers.Select(s => 
            new Customers { CustomerId = s.Id, CustomerName = s.Name }).ToList();

            return View(objCus);
        }
        [HttpPost]
        public ActionResult ChosenDropDown(Customers cus)
        {
            SelectedCustomer sc = new SelectedCustomer();
            string con = string.Join(",", cus.CustomersArray.ToArray());
            sc.AllCustomers = con;
            db.SelectedCustomers.Add(sc);
            db.SaveChanges();
            return RedirectToAction("ChosenDropDown");
        }
    }
}