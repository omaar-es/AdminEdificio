using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReciboCuota:Recibo
    {
        public Departamento departamento;
        public ReciboCuota(double c, Fecha f, Departamento d) : base(c, f)
        {
            departamento = d;
        }

        public Departamento Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
    }
}
