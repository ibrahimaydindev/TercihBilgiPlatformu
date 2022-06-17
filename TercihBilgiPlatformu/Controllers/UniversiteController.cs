using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TercihBilgiPlatformu.Controllers
{
  public class UniversiteController : Controller
  {
        private UniversiteManager cm = new UniversiteManager(new EFUniversiteRepository());

    public IActionResult Index()
    {

            var universityvalues = cm.GetList();
            return View(universityvalues);
           
    }
       


  }
}
