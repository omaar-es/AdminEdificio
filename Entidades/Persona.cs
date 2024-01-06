using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona:id
    {
        private string nombre;
        private string app;
        private string apm;
        private string RFC;
        private string direccion;
        public Persona(string n, string a1, string a2, string rFC, string dir)
        {
            nombre = n;
            app = a1;
            apm = a2;
            RFC = rFC;
            direccion=dir;  
        }
        public Persona(string n, string a1, string a2, string rFC)//CONSTRUCTOS PARA INQUILINOS, NO ES NECESARIO SABER SU DIR
        {
            nombre = n;
            app = a1;
            apm = a2;
            RFC = rFC;
        }

        public Persona()
        {
            nombre = "Juan";
            app = "Perez";
            apm = "Sanchez";
        }
    }
}
