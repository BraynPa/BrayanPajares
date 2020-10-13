using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T1.Models
{
    public class CuentaP
    {
        public int id { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public int Dia { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public int Mes { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public int Year { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Dni { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Password { get; set; }

    }
}
