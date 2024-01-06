using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Balance:id
    {
        private List<ReciboCuota> ingresos;
        private List<ReciboServicio> egresos;
        public Balance()
        {
            ingresos = new List<ReciboCuota>();
            egresos = new List<ReciboServicio>();
        }

        public Balance(Balance bMensual)
        {
            ingresos = bMensual.Ingresos;
            egresos = bMensual.Egresos;
        }

        public List<ReciboCuota> Ingresos
        {
            get { return ingresos; }
        }

        public List<ReciboServicio> Egresos
        {
            get { return egresos; }
        }
    }
}
