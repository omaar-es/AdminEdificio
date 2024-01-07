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
        private string rfc;
        private string direccion;
        public Persona(string n, string a1, string a2, string rFC, string dir)
        {
            nombre = n;
            app = a1;
            apm = a2;
            rfc = rFC;
            direccion=dir;  
        }
        public Persona(string n, string a1, string a2, string rFC)//CONSTRUCTOS PARA INQUILINOS, NO ES NECESARIO SABER SU DIR
        {
            nombre = n;
            app = a1;
            apm = a2;
            rfc = rFC;
        }

        public Persona()
        {
            nombre = "Juan";
            app = "Perez";
            apm = "Sanchez";
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string App { 
            get { return app; }
            set { app = value; }
        }
        public string Apm { 
            get { return apm; }
            set { apm = value; }
        }
        public string Rfc { 
            get { return rfc; }
            set { rfc = value; }
        }
        public string Direccion { 
            get { return direccion; }
            set { direccion = value; }
        }
        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", IdOb, nombre, app, apm, rfc, direccion);
        }
    }
}
