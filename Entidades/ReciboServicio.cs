using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReciboServicio:Recibo
    {
        private Servicio servicio;
        public ReciboServicio(Fecha f, Servicio s) : base(s.GastoMensual, f)
        {
            servicio = s;
        }

        public Servicio Servicio
        {
            get { return servicio; }
            set { servicio = value; }
        }
    }
}
