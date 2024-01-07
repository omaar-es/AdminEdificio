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
            departamentos=new List<Departamento>();
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
        public override string ToString()
        {
            if (departamentos != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Id: {0}\nNombre: {1}\nApellido Paterno: {2}\nApellido Materno: {3}\nRFC: {4}\n {5}\n",
                                 IdOb, Nombre, App, Apm, Rfc, Direccion);
                sb.AppendLine("Departamentos:\n");
                foreach (var departamento in Departamentos)
                {
                    sb.AppendLine($" {departamento}");
                }
                return sb.ToString();
            }
            else {
                return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", IdOb, Nombre, App, Apm, Rfc, Direccion);
            }
            
        }

    }
}
