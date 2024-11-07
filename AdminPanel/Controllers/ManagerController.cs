using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class ManagerController : Controller
    {
        // GET: ManagerController
        public ActionResult Categories()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult Brands()
        {
            return View();
        }
    }
}
