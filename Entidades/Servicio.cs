using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicio:id
    {
        private string nombre;
        private double gastoMensual;

        public Servicio(string n, double g)
        {
            nombre = n;
            gastoMensual = g;
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double GastoMensual
        {
            get { return gastoMensual; }
            set { gastoMensual = value; }
        }
    }
}
