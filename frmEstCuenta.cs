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
    public partial class frmEstCuenta : Form
    {
        private static Administrador admin;
        public frmEstCuenta(Administrador adminis)
        {
            InitializeComponent();
            admin = adminis;
        }
    }
}
