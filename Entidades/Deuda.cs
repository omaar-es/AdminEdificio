using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deuda:id
    {
        private double monto;
        private EstadoCuenta estadoCuenta;
        public Deuda(double m, EstadoCuenta e)
        {
            monto = m;
            estadoCuenta = e;
        }
        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public EstadoCuenta EstadoCuenta
        {
            get { return estadoCuenta; }
            set { estadoCuenta = value; }
        }
    }
}
