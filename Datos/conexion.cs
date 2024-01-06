using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Datos
{
    public class conexion
    {
        private string server = "127.0.0.1";
        private string db = "Edificio";
        private string user = "root";
        private string pass = "root";
        private string cadenaConexion;
        private string port = "3306";
        private MySqlConnection conection;

        public conexion()
        {
            cadenaConexion = "datasource=" + server +
                "; port=" + port + "; username=" + user +
                "; password=" + pass + "; database=" + db;
        }

        public MySqlConnection getConection()
        {
            conection = new MySqlConnection(cadenaConexion);
            conection.Open();
            return conection;
        }
    }
}
