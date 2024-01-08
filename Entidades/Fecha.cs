using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fecha:id
    {
        private int mes;
        private int anio;
        private int dia;

        public Fecha()
        {
            mes = 1;
            anio = 2000;
            dia = 1;
        }
        public Fecha(int d, int m, int a)
        {
            mes = m;
            anio = a;
            dia = d;
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        public int Dia { 
            get { return dia; }
            set { dia = value; }
        }
    }
}
