using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEdificio
{
    public partial class frmDepartamento : Form
    {
        private static Administrador admin;
        private int id;
        public frmDepartamento(Administrador adminis)
        {
            InitializeComponent();
            admin=adminis;
            id = -1;
        }
        public frmDepartamento(Administrador adminis, int idi)
        {
            InitializeComponent();
            admin = adminis;
            id = idi;
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            //PONER ESTAS ACCIONES COMO UN METODO EN LA CLASE ADMIN. SON UTILIZADAS EN FRMPROPIETARIO
            admin.Edificio.Departamentos.Clear();
            if (id != -1)
            {
                admin.listarDepartamentos(admin.Edificio.Departamentos, id);
            }
            else {
                admin.listarDepartamentos(admin.Edificio.Departamentos);
            }
            admin.asignarDepartamentosInquilinos();
            foreach (Departamento depto in admin.Edificio.Departamentos)
            {
                if (depto.Inq != null)
                {
                    datosDepto.Rows.Add(depto.IdOb, depto.Numero, depto.Tipo, depto.Inq.Nombre + " "+ depto.Inq.App+" "+ depto.Inq.Apm);
                }
                else {
                    datosDepto.Rows.Add(depto.IdOb, depto.Numero, depto.Tipo, "Sin inquilino");
                }
                
            }
        }
    }
}
