using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoDataServiceClient.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            var svc = new ChinookDataSvc.Container(new Uri("http://localhost:15576/odata", UriKind.Absolute));
            var qry = from it in svc.Albums
                      where it.AlbumId < 10
                      select it;
            IEnumerable<ChinookDataSvc.Album> albums = qry.ToList();
            return View(albums);
        }
    }
}