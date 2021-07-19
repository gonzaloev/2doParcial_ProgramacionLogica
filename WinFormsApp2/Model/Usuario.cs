using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsteaTVInternetCompany
{
    //GAW: No es Cliente, es Usuario de la aplicacion,
    //los clientes no tienen acceso a este aplicativo.
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }

    }
}
