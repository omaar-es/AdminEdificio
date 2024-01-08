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
        private void datosPropietario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda de la columna de botones
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && datosPropietario.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                // Obtener los datos de la fila clicada
                DataGridViewRow filaSeleccionada = datosPropietario.Rows[e.RowIndex];
                int id = Convert.ToInt32(filaSeleccionada.Cells["idPropietario"].Value);
                this.Close();
                // Llamar a la función con los datos de la fila
                frmDepartamento formularioNuevo = new frmDepartamento(admin, id);
                formularioNuevo.Show();
            }
        }
    }
}
