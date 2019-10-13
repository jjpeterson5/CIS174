using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapt2App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chapt2App.Controllers
{
    public class SelectListsController : Controller
    {
        public IActionResult Index()
        {
            return View(new SelectListsViewModel());
        }
        

                            

        [HttpPost]
        public IActionResult Index(SelectListsViewModel viewModel)
        {
           
            return View("Results", viewModel);

        }
    }
    

}