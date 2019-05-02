using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using azmisahin_software_web_architecture_dotnetcore.Models;
using web;

namespace azmisahin_software_web_architecture_dotnetcore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _db;
        public CustomerController(AppDbContext db)
        {
           _db = db;
        }
        
        public IActionResult Index()
        {
            var customers = _db.Customers.ToList();
            return View(customers);
        }

        public IActionResult Create(){

            return View(new Customer());
        }

        [HttpPost]
        public IActionResult Create(Customer model){

            if(!ModelState.IsValid) return View();

            _db.Customers.Add(model);
            _db.SaveChanges();
            return Redirect("./");
        }
    }
}
