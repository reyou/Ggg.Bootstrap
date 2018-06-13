using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Web.Controllers
{
    // https://getbootstrap.com/docs/4.0/layout/grid/
    public class GridSystemController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult ThreeEqualWidthColumns()
        {
            return View();
        }

        public IActionResult AutoLayoutColumns()
        {
            return View();
        }

        public IActionResult ResponsiveClasses()
        {
            return View();
        }
    }
}