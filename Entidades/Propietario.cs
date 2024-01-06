using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Propietario:Persona
    {
        private double deuda;
        private double cuotaRestante;
        private List<Departamento> departamentos;
        public Propietario(string n, string a1, string a2, string rfc, string dir) : base(n, a1, a2, rfc, dir)
        {
            deuda = 0;
            cuotaRestante = 0;
        }
        public Propietario(string n, string a1, string a2, List<Departamento> d, string rfc, string dir) : base(n, a1, a2, rfc, dir)
        {
            departamentos = d;
            deuda = 0;
            cuotaRestante = 0;
        }

        public List<Departamento> Departamentos
        {
            get { return departamentos; }
        }
        public double Deuda { 
            get { return deuda; }
            set { deuda = value; }
        }
        public double CuotaRestante { 
            get { return cuotaRestante; }
            set { cuotaRestante = value; }
        }
    }
}
