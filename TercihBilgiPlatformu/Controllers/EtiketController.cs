using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace TercihBilgiPlatformu.Controllers
{
    public class EtiketController : Controller
    {
        EtiketManager cm =new EtiketManager(new EFEtiketRepository());
        public IActionResult Index(int page = 1)
        {
            var etiketvalues = cm.GetList().ToPagedList(page,8);
            return View(etiketvalues);
        }
    }
}
