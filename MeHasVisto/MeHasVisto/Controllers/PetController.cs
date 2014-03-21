using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeHasVisto.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display() //ActionResult
        {
            var name = (string)RouteData.Values["id"];
           // var  accion= (string)RouteData.Values["action"];
           // var control = (string)RouteData.Values["controller"];
           var model = PetManagement.GetByname(name);
             if (model == null)
                return RedirectToAction("NotFound");
             return View(model);
            //return name + accion + control; 
        }

        public ActionResult NotFound()
        {
            return View();
        }

        public FileResult DownLoadPicture()
        {
            var name = (string)RouteData.Values["id"];
            var picture = "/content" + name + ".jpg";
            var contentType = "image/jpg";
            var fileName = name + ".jpg";
            return File(picture, contentType, fileName);
        }

    }
}

