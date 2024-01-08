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
    public partial class frmPropietario : Form
    {
        private static Administrador admin;
        public frmPropietario(Administrador adminis)
        {
            InitializeComponent();
            admin = adminis;
        }

        private void frmPropietario_Load(object sender, EventArgs e)
        {
            admin.Edificio.Propietarios.Clear();
            admin.listarPropietarios(admin.Edificio.Propietarios);
            admin.asignarDepartamentosPropietarios();
            foreach (Propietario prop in admin.Edificio.Propietarios)
            {
                datosPropietario.Rows.Add("", prop.IdOb, prop.Nombre, prop.App, prop.Apm, prop.Rfc, prop.Direccion);
            }
            
        }
    }
}
