using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaRFC
{
    class Contacto : Persona
    {
        protected string telefono, correo, rfc;

        public string tel { get; set;}
        public string email { get; set; }
        public string RFC {get; set;}

        public void PersonaC(string nombre, string app, string apm, string fecha_nac)
        {
            this.Nombre = nombre;
            this.Apellidop = app;
            this.Apellidom = apm;
            this.Fecha_na = fecha_na;
        }

        public string Recoleccion(string Apellidop, string Apellidom, string Nombre, string Fecha_na)
        {         
            this.Apellidop = Apellidop.Substring(0,2);
            this.Apellidom = Apellidom.Substring(0,1);
            this.Nombre = Nombre.Substring(0, 1);
            this.Fecha_na = Fecha_na.Substring(0,6);

            this.RFC = this.Apellidop + this.Apellidom + this.Nombre  + this.Fecha_na;

            return this.RFC;
        }


    }
}
