using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using MySql.Data.MySqlClient;
namespace Entidades
{
    public class Departamento:id
    {
        private int numero;
        private bool rentado;
        private double deudaMensual;
        private List<Deuda> deudasTotales;
        private string tipo;
        private Inquilino inq;
        public Departamento(int n, string t)
        {
            numero = n;
            tipo = t;
            deudasTotales = new List<Deuda>();
            rentado = false;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public bool Rentado
        {
            get { return rentado; }
            set { rentado = value; }
        }

        public double DeudaMensual
        {
            get { return deudaMensual; }
            set { deudaMensual = value; }
        }

        public List<Deuda> DeudasTotales
        {
            get { return deudasTotales; }
        }
        public string Tipo { 
            get { return tipo; }
            set { tipo = value; }
        }
        public Inquilino Inq { 
            get { return inq; }
            set { inq = value; }
        }
        public void AsignarInquilino() { 

        }
        public void verificarRentado() {
            if (inq!=null) {
                rentado = true;
            }
        }

    }
}
