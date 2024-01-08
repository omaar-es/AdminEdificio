using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadoCuenta : Balance
    {
        private List<Propietario> deudores;
        private double deudaTotal;
        private Fecha fecIni;
        private DateTime fecCorte;
        private float cuotaPropietario;

        public EstadoCuenta(Balance balanceMensual, Fecha fIni, DateTime fFin, float cP) : base(balanceMensual)
        {
            deudores = new List<Propietario>();
            deudaTotal = 0;
            fecIni = fIni;
            fecCorte = fFin;
            cuotaPropietario = cP;
        }
        public EstadoCuenta(Fecha fIni, DateTime fFin, float cP) : base()
        {
            deudores = new List<Propietario>();
            deudaTotal = 0;
            fecIni = fIni;
            fecCorte=fFin;
            cuotaPropietario = cP;
        }
        public List<Propietario> Deudores
        {
            get { return deudores; }
        }

        public double DeudaTotal
        {
            get { return deudaTotal; }
            set { deudaTotal = value; }
        }
        public Fecha FecIni {
            get { return fecIni; }
            set { fecIni = value; }
        }
        public DateTime FecCorte
        {
            get { return fecCorte; }
            set { fecCorte = value; }
        }
        public float CuotaPropietario { 
            get { return cuotaPropietario; }
            set {cuotaPropietario = value;}
        }
    }
}
