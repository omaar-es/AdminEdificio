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
        private FechaTime fecCorte;
        private double cuotaPropietario;

        public EstadoCuenta(Balance balanceMensual, List<Propietario> d, double dT, FechaTime fCorte) : base(balanceMensual)
        {
            deudores = d;
            deudaTotal = dT;
            fecCorte = fCorte;
        }

        public EstadoCuenta(Balance balanceMensual, Fecha fIni, double cP) : base(balanceMensual)
        {
            deudores = new List<Propietario>();
            deudaTotal = 0;
            fecIni = fIni;
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
        public FechaTime FecCorte{
            get { return fecCorte; }
            set { fecCorte = value; }
        }
        public double CuotaPropietario { 
            get { return cuotaPropietario; }
            set {cuotaPropietario = value;}
        }
    }
}
