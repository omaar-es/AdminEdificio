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
    public partial class frmInquilino : Form
    {
        private static Administrador admin;
        public frmInquilino(Administrador adminis)
        {
            InitializeComponent();
            admin = adminis;
        }

        private void frmInquilino_Load(object sender, EventArgs e)
        {
            admin.Edificio.Departamentos.Clear();
            admin.listarDepartamentos(admin.Edificio.Departamentos);
            admin.asignarDepartamentosInquilinos();
            foreach (Departamento depto in admin.Edificio.Departamentos)
            {
                if (depto.Inq != null) {
                    MessageBox.Show(depto.Inq.ToString());
                }
            }
        }
    }
}
