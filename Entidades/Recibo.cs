using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recibo:id
    {
        private double cantidad;
        private Fecha fecha;

        public Recibo(double c, Fecha f)
        {
            cantidad = c;
            fecha = f;
        }


        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Fecha Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
