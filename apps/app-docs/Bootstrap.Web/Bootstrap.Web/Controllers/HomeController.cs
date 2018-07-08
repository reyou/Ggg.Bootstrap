using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Bootstrap.Web.Models;
using Microsoft.AspNetCore.Hosting;

namespace Bootstrap.Web.Controllers
{
    public class HomeController : Controller
    {
        // https://blog.mariusschulz.com/2016/05/22/getting-the-web-root-path-and-the-content-root-path-in-asp-net-core
        private readonly IHostingEnvironment _hostingEnvironment;
        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            string applicationName = _hostingEnvironment.ApplicationName;
            string[] dir = Directory.GetFiles(contentRootPath,
                "*.cshtml", SearchOption.AllDirectories);
            List<string> filterList = new List<string>();
            filterList.Add("_ViewImports.cshtml");
            filterList.Add("_ViewStart.cshtml");
            filterList.Add(@"Shared\Error.cshtml");
            filterList.Add(@"Shared\_Layout.cshtml");
            filterList.Add(@"Shared\_ValidationScriptsPartial.cshtml");
            List<ViewItem> items = new List<ViewItem>();
            foreach (string path in dir)
            {
                bool any = filterList.Any(q => path.Contains(q));
                if (!any)
                {
                    FileInfo fileInfo = new FileInfo(path);
                    string directoryName = fileInfo.Directory.Name;
                    string fileInfoName = fileInfo.Name;
                    items.Add(new ViewItem
                    {
                        DirectoryName = directoryName,
                        FileInfoName = fileInfoName,
                        ApplicationName = applicationName
                    });
                }
            }
            return View(items);
        }

        // https://getbootstrap.com/docs/4.0/layout/overview/
        public IActionResult Containers()
        {
            return View("Containers");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
