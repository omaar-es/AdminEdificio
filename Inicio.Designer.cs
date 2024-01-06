namespace AdminEdificio
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.vrInfoEdif = new FontAwesome.Sharp.IconMenuItem();
            this.propietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquilinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vrRecibos = new FontAwesome.Sharp.IconMenuItem();
            this.recibosDeIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosDeEgresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vrEstCuenta = new FontAwesome.Sharp.IconMenuItem();
            this.estadosDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inRecibos = new FontAwesome.Sharp.IconMenuItem();
            this.recibosDeIngresosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosDeEgresosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inEstCuent = new FontAwesome.Sharp.IconMenuItem();
            this.estadosDeCuentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDelEstadoDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Titulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vrInfoEdif,
            this.vrRecibos,
            this.vrEstCuenta,
            this.inRecibos,
            this.inEstCuent});
            this.Menu.Location = new System.Drawing.Point(0, 106);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1082, 76);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // vrInfoEdif
            // 
            this.vrInfoEdif.AutoSize = false;
            this.vrInfoEdif.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propietariosToolStripMenuItem,
            this.inquilinosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.serviciosToolStripMenuItem});
            this.vrInfoEdif.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.vrInfoEdif.IconColor = System.Drawing.Color.Black;
            this.vrInfoEdif.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vrInfoEdif.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vrInfoEdif.Name = "vrInfoEdif";
            this.vrInfoEdif.Size = new System.Drawing.Size(152, 72);
            this.vrInfoEdif.Text = "Info Edificio";
            this.vrInfoEdif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.vrInfoEdif.Click += new System.EventHandler(this.vrInfoEdif_Click);
            // 
            // propietariosToolStripMenuItem
            // 
            this.propietariosToolStripMenuItem.Name = "propietariosToolStripMenuItem";
            this.propietariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.propietariosToolStripMenuItem.Text = "Propietarios";
            this.propietariosToolStripMenuItem.Click += new System.EventHandler(this.propietariosToolStripMenuItem_Click);
            // 
            // inquilinosToolStripMenuItem
            // 
            this.inquilinosToolStripMenuItem.Name = "inquilinosToolStripMenuItem";
            this.inquilinosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inquilinosToolStripMenuItem.Text = "Inquilinos";
            this.inquilinosToolStripMenuItem.Click += new System.EventHandler(this.inquilinosToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // vrRecibos
            // 
            this.vrRecibos.AutoSize = false;
            this.vrRecibos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recibosDeIngresosToolStripMenuItem,
            this.recibosDeEgresosToolStripMenuItem});
            this.vrRecibos.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.vrRecibos.IconColor = System.Drawing.Color.Black;
            this.vrRecibos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vrRecibos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vrRecibos.Name = "vrRecibos";
            this.vrRecibos.Size = new System.Drawing.Size(168, 72);
            this.vrRecibos.Text = "Recibos";
            this.vrRecibos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.vrRecibos.Click += new System.EventHandler(this.vrRecibos_Click);
            // 
            // recibosDeIngresosToolStripMenuItem
            // 
            this.recibosDeIngresosToolStripMenuItem.Name = "recibosDeIngresosToolStripMenuItem";
            this.recibosDeIngresosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recibosDeIngresosToolStripMenuItem.Text = "Recibos de Ingresos";
            this.recibosDeIngresosToolStripMenuItem.Click += new System.EventHandler(this.recibosDeIngresosToolStripMenuItem_Click);
            // 
            // recibosDeEgresosToolStripMenuItem
            // 
            this.recibosDeEgresosToolStripMenuItem.Name = "recibosDeEgresosToolStripMenuItem";
            this.recibosDeEgresosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recibosDeEgresosToolStripMenuItem.Text = "Recibos de Egresos";
            this.recibosDeEgresosToolStripMenuItem.Click += new System.EventHandler(this.recibosDeEgresosToolStripMenuItem_Click);
            // 
            // vrEstCuenta
            // 
            this.vrEstCuenta.AutoSize = false;
            this.vrEstCuenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadosDeCuentaToolStripMenuItem,
            this.deudoresToolStripMenuItem});
            this.vrEstCuenta.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.vrEstCuenta.IconColor = System.Drawing.Color.Black;
            this.vrEstCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vrEstCuenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vrEstCuenta.Name = "vrEstCuenta";
            this.vrEstCuenta.Size = new System.Drawing.Size(175, 72);
            this.vrEstCuenta.Text = "Estados de Cuenta";
            this.vrEstCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.vrEstCuenta.Click += new System.EventHandler(this.vrEstCuenta_Click);
            // 
            // estadosDeCuentaToolStripMenuItem
            // 
            this.estadosDeCuentaToolStripMenuItem.Name = "estadosDeCuentaToolStripMenuItem";
            this.estadosDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.estadosDeCuentaToolStripMenuItem.Text = "Estados de Cuenta";
            this.estadosDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.estadosDeCuentaToolStripMenuItem_Click);
            // 
            // deudoresToolStripMenuItem
            // 
            this.deudoresToolStripMenuItem.Name = "deudoresToolStripMenuItem";
            this.deudoresToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.deudoresToolStripMenuItem.Text = "Deudores";
            this.deudoresToolStripMenuItem.Click += new System.EventHandler(this.deudoresToolStripMenuItem_Click);
            // 
            // inRecibos
            // 
            this.inRecibos.AutoSize = false;
            this.inRecibos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recibosDeIngresosToolStripMenuItem1,
            this.recibosDeEgresosToolStripMenuItem1});
            this.inRecibos.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.inRecibos.IconColor = System.Drawing.Color.Black;
            this.inRecibos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inRecibos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inRecibos.Name = "inRecibos";
            this.inRecibos.Size = new System.Drawing.Size(152, 72);
            this.inRecibos.Text = "Recibos";
            this.inRecibos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.inRecibos.Click += new System.EventHandler(this.inRecibos_Click);
            // 
            // recibosDeIngresosToolStripMenuItem1
            // 
            this.recibosDeIngresosToolStripMenuItem1.Name = "recibosDeIngresosToolStripMenuItem1";
            this.recibosDeIngresosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.recibosDeIngresosToolStripMenuItem1.Text = "Recibos de Ingresos";
            this.recibosDeIngresosToolStripMenuItem1.Click += new System.EventHandler(this.recibosDeIngresosToolStripMenuItem1_Click);
            // 
            // recibosDeEgresosToolStripMenuItem1
            // 
            this.recibosDeEgresosToolStripMenuItem1.Name = "recibosDeEgresosToolStripMenuItem1";
            this.recibosDeEgresosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.recibosDeEgresosToolStripMenuItem1.Text = "Recibos de Egresos";
            this.recibosDeEgresosToolStripMenuItem1.Click += new System.EventHandler(this.recibosDeEgresosToolStripMenuItem1_Click);
            // 
            // inEstCuent
            // 
            this.inEstCuent.AutoSize = false;
            this.inEstCuent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadosDeCuentaToolStripMenuItem1,
            this.cierreDelEstadoDeCuentaToolStripMenuItem});
            this.inEstCuent.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.inEstCuent.IconColor = System.Drawing.Color.Black;
            this.inEstCuent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inEstCuent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inEstCuent.Name = "inEstCuent";
            this.inEstCuent.Size = new System.Drawing.Size(152, 72);
            this.inEstCuent.Text = "Estados de Cuenta";
            this.inEstCuent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.inEstCuent.Click += new System.EventHandler(this.inEstCuent_Click);
            // 
            // estadosDeCuentaToolStripMenuItem1
            // 
            this.estadosDeCuentaToolStripMenuItem1.Name = "estadosDeCuentaToolStripMenuItem1";
            this.estadosDeCuentaToolStripMenuItem1.Size = new System.Drawing.Size(276, 26);
            this.estadosDeCuentaToolStripMenuItem1.Text = "Estados de Cuenta";
            this.estadosDeCuentaToolStripMenuItem1.Click += new System.EventHandler(this.estadosDeCuentaToolStripMenuItem1_Click);
            // 
            // cierreDelEstadoDeCuentaToolStripMenuItem
            // 
            this.cierreDelEstadoDeCuentaToolStripMenuItem.Name = "cierreDelEstadoDeCuentaToolStripMenuItem";
            this.cierreDelEstadoDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.cierreDelEstadoDeCuentaToolStripMenuItem.Text = "Cierre del Estado de Cuenta";
            this.cierreDelEstadoDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.cierreDelEstadoDeCuentaToolStripMenuItem_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = false;
            this.Titulo.BackColor = System.Drawing.Color.OliveDrab;
            this.Titulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Titulo.Size = new System.Drawing.Size(1082, 106);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Administracion del Edificio";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-5, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(524, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ver";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(519, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingresar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 182);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1082, 571);
            this.contenedor.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.pictureBox1.Image = global::AdminEdificio.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion del Edificio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.MenuStrip Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem vrInfoEdif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconMenuItem vrRecibos;
        private FontAwesome.Sharp.IconMenuItem vrEstCuenta;
        private FontAwesome.Sharp.IconMenuItem inRecibos;
        private FontAwesome.Sharp.IconMenuItem inEstCuent;
        private System.Windows.Forms.ToolStripMenuItem propietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquilinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibosDeIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibosDeEgresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibosDeIngresosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recibosDeEgresosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estadosDeCuentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cierreDelEstadoDeCuentaToolStripMenuItem;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
    }
}

