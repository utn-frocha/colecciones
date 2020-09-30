using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion
{
    class Persona
    {
        string cedula;
        string nombre;

        public Persona()
        {

        }

        public Persona(string cedula, string nombre)
        {
            this.cedula = cedula;
            this.nombre = nombre;
        }

    }
}
