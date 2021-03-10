using MultiSelectDropDown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiSelectDropDown.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            
             var list = new List<string>() {"Pakistan","India","USA","UK" ,"Malaysia"};
            
            ViewBag.list = list;
             
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmpViewModel emp)
        {
            return View();
        }



    }
}