using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TercihBilgiPlatformu.Controllers
{
    public class BolumController : Controller
    {
        private BolumManager cm = new BolumManager(new EFBolumRepository());
        public IActionResult Index()
        {
            List<Bolum> BolumListe = cm.GetList();

            return View(BolumListe);
        }
    }
}
