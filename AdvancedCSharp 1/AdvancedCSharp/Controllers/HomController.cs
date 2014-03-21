using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdvancedCSharp.Models;

namespace AdvancedCSharp.Controllers
{
    public class HomController : Controller
    {
        //
        // GET: /Hom/

        public string Index()
        {
            return "Navegar a una URL para mostrar un ejemplo";
        }

        public ViewResult AutoProperty() 
        {
            //crear un nuevo objeto
            //De la clase producto
            Product myProduct = new Product
            {

                ProductID = 12,
                Name= "Kayak",
                Description ="Kiosteca Blue",
                Category = "SPORTS",
                Price = 12.5f
            };


            //Establecer el valor de la propiedad
            myProduct.ProductID = 12;
            myProduct.Name = "Kayak";
            myProduct.Description = "Kiosteca Blue";
            myProduct.Category = "Sports";
            myProduct.Price = 12.5f;

            //obtiene la propiedad 
            string salida =
                String.Format("{0}-{2}-{3}-{4:C0}",
                myProduct.ProductID,
                myProduct.Name,
                myProduct.Description,
                myProduct.Category,
                myProduct.Price);

            //genera la vista
            return View("Result", 
                (object)salida);

        }

    }
}
