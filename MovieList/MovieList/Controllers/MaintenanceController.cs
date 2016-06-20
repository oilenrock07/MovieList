using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieList.Models.Maintenance;

namespace MovieList.Controllers
{
    public class MaintenanceController : Controller
    {
        public ActionResult Index()
        {
            return View(new MaintenanceViewModel());
        }

        [HttpPost]
        public JsonResult GetHtmlString(string imdbId)
        {
            var downloadedString = "";
            var url = String.Format("http://www.imdb.com/title/{0}", imdbId);

            using (var client = new WebClient())
            {
                downloadedString = client.DownloadString(url);
            }

            return Json(downloadedString);
        }
    }
}