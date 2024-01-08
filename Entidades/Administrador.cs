using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
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
        public void GenerarEstadoDeCuenta(Fecha fechaInicio, DateTime fechaFinal, float cuotaPropietario)
        {
            try
            {
                string fechaInsertar = $"{fechaInicio.Anio:D4}-{fechaInicio.Mes:D2}-{fechaInicio.Dia:D2}";
                conexion oConexion = new conexion();
                string query = "INSERT INTO EstadoCuenta (fecInicio, fecCorte, cuota) VALUES (@fecI, @fecF, @c)";
                MySqlCommand cmd = new MySqlCommand(query, oConexion.getConection());
                cmd.Parameters.AddWithValue("@fecI", fechaInsertar);
                cmd.Parameters.AddWithValue("@fecF", fechaFinal);
                cmd.Parameters.AddWithValue("@c", cuotaPropietario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la sentencia SQL: {ex.Message}");
                
            }
            edificio.EstadosCuenta.Add(new EstadoCuenta(fechaInicio, fechaFinal, cuotaPropietario));
        }

        public void asignarDepartamentosInquilinos() {
            foreach (Departamento depto in edificio.Departamentos)
            {
                depto.Inq = listarInquilino(depto.IdOb);
            }
        }
        //ASIGNACIÓN DE CIERTOS DEPARTAMENTOS
        public void asignarDepartamentosInquilinos(Departamento depto)
        {
                depto.Inq = listarInquilino(depto.IdOb);
        }
        public void asignarDepartamentosPropietarios()
        {
            foreach (Propietario prop in edificio.Propietarios)
            {
                listarDepartamentos(prop.Departamentos, prop.IdOb);
                if (prop.Departamentos != null)
                {
                    foreach (Departamento departamento in prop.Departamentos) {
                        if (departamento.Inq == null) {
                            asignarDepartamentosInquilinos(departamento);
                        }
                    }
                }
            }
        }
        
        public Inquilino listarInquilino(int idI)
        {
            try
            {
                conexion oConexion = new conexion();
                string query = "SELECT * FROM Inquilino WHERE idDepartamento = @IdInquilino";
                MySqlCommand cmd = new MySqlCommand(query, oConexion.getConection());
                cmd.Parameters.AddWithValue("@IdInquilino", idI);

                MySqlDataReader reader = cmd.ExecuteReader();
                Inquilino inq;
                    while (reader.Read())
                    {
                        inq = new Inquilino(
                        reader["nombre"].ToString(),
                        reader["appat"].ToString(),
                        reader["apmat"].ToString(),
                        reader["RFC"].ToString()
                        );

                        inq.IdOb = Convert.ToInt32(reader["idInquilino"]);
                        return inq;
                    }
                return null; // Puedes considerar devolver null si no se encuentra ningún inquilino con ese id
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la sentencia SQL: {ex.Message}");
                return null;
            }
        }

        public void listarDepartamentos(List<Departamento> listaDepartamentos)
        {
            try
            {
                conexion oConexion = new conexion();
                string query = "select * from Departamento";
                MySqlCommand cmd = new MySqlCommand(query, oConexion.getConection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaDepartamentos.Add(new Departamento(Convert.ToInt32(reader["numero"]), reader["tipo"].ToString())
                    {
                        IdOb = Convert.ToInt32(reader["idDepartamento"])

                    });

                }
            }
            catch (Exception ex)
            {
                listaDepartamentos.Add(new Departamento());
            }
        }

        public void listarDepartamentos(List<Departamento> listaDepartamentos, int idD)
        {
            try
            {

                   conexion oConexion = new conexion();
                   string query = "SELECT * FROM Departamento WHERE idPropietario = @Id";
                   MySqlCommand cmd = new MySqlCommand(query, oConexion.getConection());
                   cmd.Parameters.AddWithValue("@Id", idD);
                   MySqlDataReader reader = cmd.ExecuteReader();
                   while (reader.Read())
                   {
                       listaDepartamentos.Add(new Departamento(Convert.ToInt32(reader["numero"]), reader["tipo"].ToString())
                       {
                           IdOb = Convert.ToInt32(reader["idDepartamento"])

                       });
                   } 
            }
            catch (Exception ex)
            {
                listaDepartamentos.Add(new Departamento());
            }
        }
        public void listarPropietarios(List<Propietario> listaPropietarios) {
            try
            {
                conexion oConexion = new conexion();
                string query = "select * from Propietario";
                MySqlCommand cmd = new MySqlCommand(query, oConexion.getConection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaPropietarios.Add(new Propietario(
                        reader["nombre"].ToString(),
                        reader["appat"].ToString(),
                        reader["apmat"].ToString(),
                        reader["RFC"].ToString(),
                        reader["direccion"].ToString()
                        )
                    {
                        IdOb = Convert.ToInt32(reader["idPropietario"])
                    });

                }
            }
            catch (Exception ex)
            {
                listaPropietarios.Add(null);
            }
        }

        public void listarServicios() {
            try
            {
                conexion oConexion = new conexion();
                string query = "select * from Servicio";
                MySqlCommand cmd = new MySqlCommand(query, oConexion.getConection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    edificio.Servicios.Add(new Servicio(
                        reader["tipo"].ToString(),
                        Convert.ToDouble(reader["gastoMensual"])
                        )
                    {
                        IdOb = Convert.ToInt32(reader["idServicio"])
                    });

                }
            }
            catch (Exception ex)
            {
                edificio.Servicios.Add(null);
            }
        }
        public void listarMantenimientos()
        {
            try
            {
                conexion oConexion = new conexion();
                string query = "select * from Mantenimiento";
                MySqlCommand cmd = new MySqlCommand(query, oConexion.getConection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    edificio.Mantenimientos.Add(new Mantenimiento(
                        reader["nombre"].ToString(),
                        Convert.ToDouble(reader["costo"])
                        )
                    {
                        IdOb = Convert.ToInt32(reader["idMantenimiento"])
                    });

                }
            }
            catch (Exception ex)
            {
                edificio.Servicios.Add(null);
            }
        }



    }
}
