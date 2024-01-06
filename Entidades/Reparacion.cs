using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reparacion:Recibo
    {
        private string descripcion;
        private List<Material> materiales;
        public Reparacion(string desc, double cantidad, Fecha f) : base(cantidad, f)
        {
            descripcion = desc;
        }
        public string Descripcion { 
            get { return descripcion; }
            set { descripcion = value; }
        }
        public List<Material> Materiales { 
            get { return materiales; }
        }
    }
}
