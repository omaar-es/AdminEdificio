namespace AdminEdificio
{
    partial class frmInEstCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cuotaMens = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.crearEstCuenta = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.fecFin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fecIni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.slcFecha = new FontAwesome.Sharp.IconButton();
            this.calendarioInEstCuenta = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HoraFin = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear un Estado de Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuota Mensual:";
            // 
            // cuotaMens
            // 
            this.cuotaMens.Location = new System.Drawing.Point(361, 73);
            this.cuotaMens.Name = "cuotaMens";
            this.cuotaMens.Size = new System.Drawing.Size(270, 22);
            this.cuotaMens.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione el rango de días";
            // 
            // crearEstCuenta
            // 
            this.crearEstCuenta.BackColor = System.Drawing.Color.Green;
            this.crearEstCuenta.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearEstCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.crearEstCuenta.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.crearEstCuenta.IconColor = System.Drawing.Color.White;
            this.crearEstCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.crearEstCuenta.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.crearEstCuenta.Location = new System.Drawing.Point(400, 478);
            this.crearEstCuenta.Name = "crearEstCuenta";
            this.crearEstCuenta.Size = new System.Drawing.Size(142, 52);
            this.crearEstCuenta.TabIndex = 5;
            this.crearEstCuenta.Text = "Crear";
            this.crearEstCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.crearEstCuenta.UseVisualStyleBackColor = false;
            this.crearEstCuenta.Click += new System.EventHandler(this.crearEstCuenta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.HoraFin);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUpDownMinute);
            this.panel1.Controls.Add(this.numericUpDownHour);
            this.panel1.Controls.Add(this.fecFin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fecIni);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.slcFecha);
            this.panel1.Controls.Add(this.calendarioInEstCuenta);
            this.panel1.Controls.Add(this.cuotaMens);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(149, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 390);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hora";
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Location = new System.Drawing.Point(464, 356);
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(65, 22);
            this.numericUpDownMinute.TabIndex = 13;
            this.numericUpDownMinute.ValueChanged += new System.EventHandler(this.numericUpDownMinute_ValueChanged);
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(361, 356);
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(78, 22);
            this.numericUpDownHour.TabIndex = 12;
            this.numericUpDownHour.ValueChanged += new System.EventHandler(this.numericUpDownHour_ValueChanged);
            // 
            // fecFin
            // 
            this.fecFin.Location = new System.Drawing.Point(361, 230);
            this.fecFin.Name = "fecFin";
            this.fecFin.Size = new System.Drawing.Size(270, 22);
            this.fecFin.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de fin:";
            // 
            // fecIni
            // 
            this.fecIni.Location = new System.Drawing.Point(361, 150);
            this.fecIni.Name = "fecIni";
            this.fecIni.Size = new System.Drawing.Size(270, 22);
            this.fecIni.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de inicio:";
            // 
            // slcFecha
            // 
            this.slcFecha.BackColor = System.Drawing.Color.SteelBlue;
            this.slcFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slcFecha.ForeColor = System.Drawing.Color.White;
            this.slcFecha.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.slcFecha.IconColor = System.Drawing.Color.White;
            this.slcFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.slcFecha.IconSize = 35;
            this.slcFecha.Location = new System.Drawing.Point(24, 310);
            this.slcFecha.Name = "slcFecha";
            this.slcFecha.Size = new System.Drawing.Size(146, 43);
            this.slcFecha.TabIndex = 6;
            this.slcFecha.Text = "Seleccionar";
            this.slcFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.slcFecha.UseVisualStyleBackColor = false;
            this.slcFecha.Click += new System.EventHandler(this.slcFecha_Click);
            // 
            // calendarioInEstCuenta
            // 
            this.calendarioInEstCuenta.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarioInEstCuenta.Location = new System.Drawing.Point(24, 72);
            this.calendarioInEstCuenta.MaxSelectionCount = 31;
            this.calendarioInEstCuenta.Name = "calendarioInEstCuenta";
            this.calendarioInEstCuenta.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Minutos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "Hora de fin:";
            // 
            // HoraFin
            // 
            this.HoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraFin.Location = new System.Drawing.Point(361, 299);
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Size = new System.Drawing.Size(270, 22);
            this.HoraFin.TabIndex = 17;
            this.HoraFin.ValueChanged += new System.EventHandler(this.HoraFin_ValueChanged);
            // 
            // frmInEstCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crearEstCuenta);
            this.Controls.Add(this.label1);
            this.Name = "frmInEstCuenta";
            this.Text = "frmInEstCuenta";
            this.Load += new System.EventHandler(this.frmInEstCuenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuotaMens;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton crearEstCuenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar calendarioInEstCuenta;
        private FontAwesome.Sharp.IconButton slcFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fecFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fecIni;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker HoraFin;
        private System.Windows.Forms.Label label8;
    }
}