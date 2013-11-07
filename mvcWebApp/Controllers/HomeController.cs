using mvcWebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace mvcWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IList<Thumbnail> GetThumbnails()
        {
            Thumbnail t;
            IList<Thumbnail> list;
            string windowsDir;

            windowsDir = "Images\\Thumbnails";
            windowsDir = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, windowsDir);

            list = new List<Thumbnail>();
            foreach (string file in Directory.EnumerateFiles(windowsDir))
            {
                t = new Thumbnail();
                t.Name = Path.GetFileNameWithoutExtension(file);
                t.ImagePath = file.Remove(0, HostingEnvironment.ApplicationPhysicalPath.Length).Replace("\\", "/");
                list.Add(t);

            }

            return list;
        }

        private IList<Progression> GetProgressions()
        {
            Progression p;
            IList<Progression> list;
            string windowsDir;

            windowsDir = "Images\\Progressions";
            windowsDir = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, windowsDir);

            list = new List<Progression>();
            foreach (string dir in Directory.EnumerateDirectories(windowsDir))
            {
                p = new Progression();
                p.Name = "TODO" + dir.Substring(dir.Length - 1, 1);
                p.ImagePaths = Directory.EnumerateFiles(dir).Select(path => path.Remove(0, HostingEnvironment.ApplicationPhysicalPath.Length).Replace("\\", "/")).ToArray();
                list.Add(p);

            }

            return list;
        }
        public ActionResult Index()
        {
            Gallery gallery;          
            gallery = new Gallery() { Progressions = GetProgressions(), Thumbnails = GetThumbnails() };
            return View(gallery);
        }
    }
}
