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
    public partial class frmMantenimiento : Form
    {
        private static Administrador admin;
        public frmMantenimiento(Administrador adminis)
        {
            InitializeComponent();
            admin = adminis;    
        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            admin.Edificio.Mantenimientos.Clear();
            admin.listarMantenimientos();
            foreach (Mantenimiento mant in admin.Edificio.Mantenimientos)
            {
                MessageBox.Show(mant.ToString());
            }
        }
    }
}
