using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador:Persona
    {
        private Edificio edificio;
        public Administrador(Edificio e) : base()
        {
            edificio = e;
        }
        public Edificio Edificio
        {
            get { return edificio; }
            set { edificio = value; }
        }
        public void PagarServicio(Servicio servicio, Fecha fecha)
        {
            edificio.PagosMensuales.Egresos.Add(new ReciboServicio(fecha, servicio));
        }

        public void RecibirPagoCuota(Departamento departamento, double cantidad, Fecha fecha)
        {
            edificio.PagosMensuales.Ingresos.Add(new ReciboCuota(cantidad, fecha, departamento));
        }

        public void GenerarEstadoDeCuenta(Fecha fechaInicio, double cuotaPropietario)
        {
            edificio.EstadosCuenta.Add(new EstadoCuenta(edificio.PagosMensuales, fechaInicio, cuotaPropietario));
        }
        public void GenerarEstadoDeCuenta(List<Propietario> propietarios, double deuda, FechaTime fecCorte)
        {
            edificio.EstadosCuenta.Add(new EstadoCuenta(edificio.PagosMensuales, propietarios, deuda, fecCorte));
        }
        public void listarDepartamentos()
        {
            try
            {
                conexion oConexion = new conexion();
                string res = " ";
                string query = "select * from Departamento";
                MySqlCommand cmd = new MySqlCommand(query, oConexion.getConection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    edificio.Departamentos.Add(new Departamento()
                    {

                    });

                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
