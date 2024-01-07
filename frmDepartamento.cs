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
        public frmDepartamento(Administrador adminis)
        {
            InitializeComponent();
            admin=adminis; 
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            //PONER ESTAS ACCIONES COMO UN METODO EN LA CLASE ADMIN. SON UTILIZADAS EN FRMPROPIETARIO
            admin.Edificio.Departamentos.Clear();
            admin.listarDepartamentos(admin.Edificio.Departamentos);
            admin.asignarDepartamentosInquilinos();
            foreach (Departamento depto in admin.Edificio.Departamentos)
            {
                MessageBox.Show(depto.ToString());
            }
            
        }
    }
}
