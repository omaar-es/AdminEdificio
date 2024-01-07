using Entidades;
using FontAwesome.Sharp;
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
    public partial class Inicio : Form
    {
        private static IconMenuItem MenuActivo;
        private static Form formActivo;
        private static Administrador admin;
        public Inicio()
        {
            InitializeComponent();
            MenuActivo = null;
            formActivo = null;
            Edificio edif = new Edificio();
            admin = new Administrador(edif);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }
        private void MenuActivoIcono(IconMenuItem menu) {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

        }
        private void AbrirFormulario(Form formulario) {
            
            if (formActivo != null){
                formActivo.Close();
            }
            formActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle= FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.Moccasin;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        //ABRIR FORMULARIOS DEL MENÚ Y VISTA DE MENÚ ACTIVO
        private void propietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPropietario(admin));
        }
        private void vrInfoEdif_Click(object sender, EventArgs e)
        {
            MenuActivoIcono((IconMenuItem)sender);
        }
        private void vrRecibos_Click(object sender, EventArgs e)
        {
            MenuActivoIcono((IconMenuItem)sender);
        }
        private void vrEstCuenta_Click(object sender, EventArgs e)
        {
            MenuActivoIcono((IconMenuItem)sender);
        }
        private void inRecibos_Click(object sender, EventArgs e)
        {
            MenuActivoIcono((IconMenuItem)sender);
        }
        private void inEstCuent_Click(object sender, EventArgs e)
        {
            MenuActivoIcono((IconMenuItem)sender);
        }
        private void inquilinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInquilino(admin));
        }
        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDepartamento(admin));
        }
        private void recibosDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReciboIngreso(admin));
        }
        private void recibosDeEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReciboEgreso(admin));
        }
        private void estadosDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEstCuenta(admin));
        }
        private void deudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDeudores(admin));
        }
        private void recibosDeIngresosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInRecIngreso(admin));
        }
        private void recibosDeEgresosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInRecEgreso(admin));
        }
        private void estadosDeCuentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInEstCuenta(admin));
        }
        private void cierreDelEstadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInCierreEstCuenta(admin));
        }
        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmServicios(admin));
        }

        private void InMantenimiento_Click(object sender, EventArgs e)
        {
            MenuActivoIcono((IconMenuItem)sender);
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmMantenimiento(admin));
        }
    }
}
