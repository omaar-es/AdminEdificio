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
    public partial class frmInEstCuenta : Form
    {
        private static Administrador admin;
        public frmInEstCuenta(Administrador adminis)
        {
            InitializeComponent();
            admin = adminis;
        }

        private void slcFecha_Click(object sender, EventArgs e)
        {
            DateTime inicio = calendarioInEstCuenta.SelectionStart;
            DateTime final = calendarioInEstCuenta.SelectionEnd;
            fecIni.Text= inicio.ToString("dd / MM / yyyy");
            fecFin.Text= final.ToString("dd / MM / yyyy");
        }

        private void frmInEstCuenta_Load(object sender, EventArgs e)
        {
            // Configurar DateTimePicker para mostrar solo la hora
            HoraFin.Format = DateTimePickerFormat.Custom;
            HoraFin.CustomFormat = "HH:mm";

            // Configurar rango para horas y minutos (puedes ajustar estos rangos según tus necesidades)
            numericUpDownHour.Minimum = 0;
            numericUpDownHour.Maximum = 23;
            numericUpDownMinute.Minimum = 0;
            numericUpDownMinute.Maximum = 59;
        }
        private void HoraFin_ValueChanged(object sender, EventArgs e)
        {
            // Actualizar los controles NumericUpDown cuando cambia el valor del DateTimePicker
            numericUpDownHour.Value = HoraFin.Value.Hour;
            numericUpDownMinute.Value = HoraFin.Value.Minute;
        }
        private void numericUpDownHour_ValueChanged(object sender, EventArgs e)
        {
            // Actualizar el valor del DateTimePicker cuando cambia el valor de NumericUpDown para la hora
            HoraFin.Value = new DateTime(HoraFin.Value.Year, HoraFin.Value.Month, HoraFin.Value.Day,
                                                 (int)numericUpDownHour.Value, HoraFin.Value.Minute, 0);
        }
        private void numericUpDownMinute_ValueChanged(object sender, EventArgs e)
        {
            // Actualizar el valor del DateTimePicker cuando cambia el valor de NumericUpDown para los minutos
            HoraFin.Value = new DateTime(HoraFin.Value.Year, HoraFin.Value.Month, HoraFin.Value.Day,
                                                 HoraFin.Value.Hour, (int)numericUpDownMinute.Value, 0);
        }

        private void crearEstCuenta_Click(object sender, EventArgs e)
        {
            DateTime inicio = calendarioInEstCuenta.SelectionStart;
            DateTime final = calendarioInEstCuenta.SelectionEnd;
            final = new DateTime(final.Year, final.Month, final.Day, HoraFin.Value.Hour, HoraFin.Value.Minute, 0);
            Fecha fecha = new Fecha(inicio.Day, inicio.Month, inicio.Year);
            float cuota;
            float.TryParse(cuotaMens.Text, out cuota);
            int cantidadEstados = admin.Edificio.EstadosCuenta.Count();
            admin.GenerarEstadoDeCuenta(fecha, final, cuota);
            int cantidadEstadosdespues = admin.Edificio.EstadosCuenta.Count();
            if (cantidadEstados != cantidadEstadosdespues)
            {
                MessageBox.Show("Datos insertados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("No se pudieron insertar los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            limpiar();

        }
        private void limpiar() {
            cuotaMens.Text = "0";
            fecIni.Text = "";
            fecFin.Text = "";
            HoraFin.Text = "";
            
        }
    }
}
