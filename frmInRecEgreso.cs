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
    public partial class frmInRecEgreso : Form
    {
        private static Administrador admin;
        public frmInRecEgreso(Administrador adminis)
        {
            InitializeComponent();
            admin = adminis;
        }
    }
}
