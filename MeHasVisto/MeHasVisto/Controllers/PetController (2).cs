﻿using System;
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
        public ActionResult Display()
        {
            var name = (string)RouteData.Values["id"];
            object model = null;
           /* var model = PetManagemet.GetByBame(name);*/
            if (model == null)
                return RedirectToAction("NotFound");
            return View(model);
        }
        //public ActionResult NotFound()
        //{
          //  return View();
        //}
        public FileResult DownLoadPicture()
        {
            var name = (string)RouteData.Values["id"];
            var picture = @"C:\Users\cypher\Documents\" + ".jpg";
            var contentType = "image/jpg";
            var fileName = name = ".jpg";
            return File(picture, contentType, fileName);
        }
        public HttpStatusCodeResult UnanuthorizedError()
        {
            return new HttpUnauthorizedResult("Error de acceso no autorizado");
        }
        public ActionResult NotFoundError()
        {
            return HttpNotFound("nada por aqui ...");
        }
        public ActionResult NotFound()
        {
            ViewBag.ErrorCode = "NFE0001";
            ViewBag.Description = "La mascota no se encuentra" + "En la base de datos";
            return View();
        }
        
    }
}
