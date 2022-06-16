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

    public IActionResult Index()
    {
      return View();
    }


  }
}
