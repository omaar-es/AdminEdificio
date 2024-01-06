using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Edificio:id
    {
        private List<Departamento> departamentos;
        private List<Servicio> servicios;
        private List<Propietario> propietarios;
        private List<EstadoCuenta> estadosCuenta;
        private Balance pagosMensuales;

        public Edificio(List<Departamento> d, List<Servicio> s, List<Propietario> p)
        {
            departamentos = d;
            servicios = s;
            propietarios = p;
            estadosCuenta = new List<EstadoCuenta>();
            pagosMensuales = new Balance();
        }
        public Edificio()
        {
            departamentos = new List<Departamento>();
            servicios = new List<Servicio>();
            propietarios = new List<Propietario>();
            estadosCuenta = new List<EstadoCuenta>();
            pagosMensuales = new Balance();
        }
        public List<Departamento> Departamentos
        {
            get { return departamentos; }
        }

        public List<Servicio> Servicios
        {
            get { return servicios; }
        }

        public List<EstadoCuenta> EstadosCuenta
        {
            get { return estadosCuenta; }
        }

        public Balance PagosMensuales
        {
            get { return pagosMensuales; }
            set { pagosMensuales = value; }
        }
        public List<Propietario> Propietarios{
            get { return propietarios; }
            set { propietarios = value; }
        }
    }
}
