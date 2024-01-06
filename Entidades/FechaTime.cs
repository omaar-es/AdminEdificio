using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FechaTime:Fecha
    {
        private int hora;
        private int minutos;
        private int segundos;
        public FechaTime(int h, int m, int s, int mes, int anio) : base(mes, anio) {
            hora = h;
            minutos = m;
            segundos=s;
        }
        public int Hora { 
            get { return hora; }
            set { hora = value; }
        }
        public int Minutos { 
            get { return minutos; }
            set { minutos = value; }
        }
        public int Segundos { 
            get { return segundos; }
            set { segundos = value; }
        }
    }
}
