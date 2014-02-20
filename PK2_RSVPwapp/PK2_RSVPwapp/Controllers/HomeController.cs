using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PK2_RSVPwapp.Models;

namespace PK2_RSVPwapp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ?
                "Buenos Dias!!" : "Buenas Tardes!!";
            return View();
        }
        //Get: /Home/RvspForm
        //Renderea el link de la forma del Rsvp
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        //Responde a un POST: //Home/RVSPForm
        [HttpPost]
        public ViewResult RsvpForm(GuestRespoonse guestResponse)
        {
            //verificar errores de validacion
            if (ModelState.IsValid)
            {

                //TODO: Enviar respuesta al correo del organizador
                return View("Agradecimientos", guestResponse);
            }
            else {

                //Hay un problema en la validaciion
                return View();
            }
        }
    }
}
