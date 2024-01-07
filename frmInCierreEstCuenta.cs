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
    public partial class frmInCierreEstCuenta : Form
    {
        private static Administrador admin;
        public frmInCierreEstCuenta(Administrador adminis)
        {
            InitializeComponent();
            admin = adminis;
        }
    }
}
