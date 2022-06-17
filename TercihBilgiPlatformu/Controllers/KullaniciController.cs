using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TercihBilgiPlatformu.Controllers
{
    public class KullaniciController : Controller
    {
        private KullaniciManager cm = new KullaniciManager(new EFKullaniciRepository());
        public IActionResult Index()
        {
            var kullanicivalues=cm.GetList();
            return View(kullanicivalues);
        }
    }
}
