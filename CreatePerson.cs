using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapt2App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chapt2App.Controllers
{
    public class CreatePersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        

                            

        [HttpPost]
        public IActionResult Index(CreatePersonController model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");

        }
    }
    

}