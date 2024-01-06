using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Material:id
    {
        private double costo;
        private string nombre;
        public Material(double c, string n) {
            costo = c;
            nombre=n;
        }
        public double Costo { 
            get { return costo; }
            set { costo = value; }
        }
        public string Nombre { 
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
