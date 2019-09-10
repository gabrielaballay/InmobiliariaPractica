using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria.Models
{
    public class Propietario
    {
        public int IdPropietario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        public string Telefono { get; set; }
        [DataType(DataType.Password)]
        public string Clave { get; set; }
    }
}
