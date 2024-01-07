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
    public partial class frmServicios : Form
    {
        private static Administrador admin;
        public frmServicios(Administrador adminis)
        {
            InitializeComponent();
            admin = adminis;
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            admin.Edificio.Servicios.Clear();
            admin.listarServicios();
            foreach (Servicio serv in admin.Edificio.Servicios)
            {
                MessageBox.Show(serv.ToString());
            }
        }
    }
}
