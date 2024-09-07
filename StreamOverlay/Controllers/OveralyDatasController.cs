using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StreamOverlay.Models;

namespace StreamOverlay.Controllers
{
    public class OveralyDatasController : Controller
    {
        private StreamOverlayEntities db = new StreamOverlayEntities();

        // GET: OveralyDatas
        public ActionResult Index()
        {
            var test = db.OveralyDatas.Find(1);
            ViewBag.JSONData = test.jsonData;
            return View();
        }
    }

}
