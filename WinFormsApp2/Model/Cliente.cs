using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsteaTVInternetCompany
{
    //GAW:Este si es Cliente
    //Titular vuela
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Nro { get; set; }
        public string DNI { get; set; }
        public bool Estatus { get; set; }

        //GAW: Las T no son necesarias.
        public Contacto Contacto { get; set; }

        public Plan Plan { get; set; }
        public Domicilio Domicilio { get; set; }

    }
}
