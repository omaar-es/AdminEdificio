using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mantenimiento:Servicio
    {
        private List<Material> materiales;
        public Mantenimiento(string n, double g):base(n, g) {
            materiales=new List<Material>();
        }
        public List<Material> Materiales { 
            get { return materiales; }
        }
        /*
        public override string ToString()
        {

        }*/
    }
}
