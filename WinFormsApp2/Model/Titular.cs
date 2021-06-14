using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsteaTVInternetCompany
{
    public class Titular
    {
        public string Nombre { get; set; }
        public string Nro { get; set; }
        public string DNI { get; set; }
        public bool Estatus { get; set; }

        public Contacto TContacto { get; set; }

        public Plan TPlan { get; set; }
        public Domicilio TDomicilio { get; set; }

    }
}
