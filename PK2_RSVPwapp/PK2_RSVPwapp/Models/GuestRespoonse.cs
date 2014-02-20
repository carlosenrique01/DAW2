using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//usando para validar campos
using System.ComponentModel.DataAnnotations;

namespace PK2_RSVPwapp.Models
{
    public class GuestRespoonse
    {
        [Required(ErrorMessage = "Por Favor Ingrese Su Nombre.")]
        public string Name { get; set;}

        [Required(ErrorMessage = "Por Favor Ingrese Su Correo Electronico.")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Favor De Ingresar Una Cuenta De Correo Valida")]
        public string Email { get; set;}

        [Required(ErrorMessage = "Por Favor Ingrese Su Numero Telefonico.")]
        public string Phone { get; set;}

        [Required(ErrorMessage = "Por Favor Especifique Si Asistira o No.")]
        public bool? WillAttend { get; set;} //propiedades auto incrementadas y on tipos 


    }
}