using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Web.Controllers
{
    public class ComponentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Navs()
        {
            return View();
        }
        public IActionResult Navbar()
        {
            return View();
        }
        public IActionResult Modal()
        {
            return View();
        }
        /// <summary>
        /// https://getbootstrap.com/docs/4.0/components/navs/#javascript-behavior
        /// </summary>
        /// <returns></returns>
        public IActionResult JavaScriptBehavior()
        {
            return View();
        }
    }
}