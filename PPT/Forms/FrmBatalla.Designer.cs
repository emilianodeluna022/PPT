namespace PPT
{
    partial class FrmBatalla
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
            this.components = new System.ComponentModel.Container();
            this.tmrRonda = new System.Windows.Forms.Timer(this.components);
            this.pnlEscena = new System.Windows.Forms.Panel();
            this.picSeleccionIA = new System.Windows.Forms.PictureBox();
            this.picZonaSalir = new System.Windows.Forms.PictureBox();
            this.picZonaPlanta = new System.Windows.Forms.PictureBox();
            this.picZonaAgua = new System.Windows.Forms.PictureBox();
            this.picZonaFuego = new System.Windows.Forms.PictureBox();
            this.picResultadoRonda = new System.Windows.Forms.PictureBox();
            this.pnlEscena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeleccionIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaAgua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaFuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultadoRonda)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrRonda
            // 
            this.tmrRonda.Interval = 2500;
            this.tmrRonda.Tick += new System.EventHandler(this.tmrRonda_Tick);
            // 
            // pnlEscena
            // 
            this.pnlEscena.BackgroundImage = global::PPT.Properties.Resources.BatallaJuegoSeleccion;
            this.pnlEscena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEscena.Controls.Add(this.picResultadoRonda);
            this.pnlEscena.Controls.Add(this.picSeleccionIA);
            this.pnlEscena.Controls.Add(this.picZonaSalir);
            this.pnlEscena.Controls.Add(this.picZonaPlanta);
            this.pnlEscena.Controls.Add(this.picZonaAgua);
            this.pnlEscena.Controls.Add(this.picZonaFuego);
            this.pnlEscena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEscena.Location = new System.Drawing.Point(0, 0);
            this.pnlEscena.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEscena.Name = "pnlEscena";
            this.pnlEscena.Size = new System.Drawing.Size(884, 511);
            this.pnlEscena.TabIndex = 5;
            // 
            // picSeleccionIA
            // 
            this.picSeleccionIA.BackColor = System.Drawing.Color.Transparent;
            this.picSeleccionIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSeleccionIA.Location = new System.Drawing.Point(302, 404);
            this.picSeleccionIA.Name = "picSeleccionIA";
            this.picSeleccionIA.Size = new System.Drawing.Size(70, 70);
            this.picSeleccionIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSeleccionIA.TabIndex = 4;
            this.picSeleccionIA.TabStop = false;
            this.picSeleccionIA.Visible = false;
            // 
            // picZonaSalir
            // 
            this.picZonaSalir.BackColor = System.Drawing.Color.Transparent;
            this.picZonaSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picZonaSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaSalir.Location = new System.Drawing.Point(447, 386);
            this.picZonaSalir.Name = "picZonaSalir";
            this.picZonaSalir.Size = new System.Drawing.Size(201, 50);
            this.picZonaSalir.TabIndex = 3;
            this.picZonaSalir.TabStop = false;
            // 
            // picZonaPlanta
            // 
            this.picZonaPlanta.BackColor = System.Drawing.Color.Transparent;
            this.picZonaPlanta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picZonaPlanta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaPlanta.Location = new System.Drawing.Point(447, 449);
            this.picZonaPlanta.Name = "picZonaPlanta";
            this.picZonaPlanta.Size = new System.Drawing.Size(201, 50);
            this.picZonaPlanta.TabIndex = 2;
            this.picZonaPlanta.TabStop = false;
            // 
            // picZonaAgua
            // 
            this.picZonaAgua.BackColor = System.Drawing.Color.Transparent;
            this.picZonaAgua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picZonaAgua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaAgua.Location = new System.Drawing.Point(665, 449);
            this.picZonaAgua.Name = "picZonaAgua";
            this.picZonaAgua.Size = new System.Drawing.Size(195, 50);
            this.picZonaAgua.TabIndex = 1;
            this.picZonaAgua.TabStop = false;
            // 
            // picZonaFuego
            // 
            this.picZonaFuego.BackColor = System.Drawing.Color.Transparent;
            this.picZonaFuego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picZonaFuego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaFuego.Location = new System.Drawing.Point(665, 386);
            this.picZonaFuego.Name = "picZonaFuego";
            this.picZonaFuego.Size = new System.Drawing.Size(195, 50);
            this.picZonaFuego.TabIndex = 0;
            this.picZonaFuego.TabStop = false;
            // 
            // picResultadoRonda
            // 
            this.picResultadoRonda.BackColor = System.Drawing.Color.Transparent;
            this.picResultadoRonda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picResultadoRonda.Location = new System.Drawing.Point(210, 182);
            this.picResultadoRonda.Name = "picResultadoRonda";
            this.picResultadoRonda.Size = new System.Drawing.Size(464, 94);
            this.picResultadoRonda.TabIndex = 5;
            this.picResultadoRonda.TabStop = false;
            this.picResultadoRonda.Visible = false;
            // 
            // FrmBatalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.pnlEscena);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FrmBatalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBatalla";
            this.pnlEscena.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSeleccionIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaAgua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaFuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultadoRonda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEscena;
        private System.Windows.Forms.PictureBox picZonaSalir;
        private System.Windows.Forms.PictureBox picZonaPlanta;
        private System.Windows.Forms.PictureBox picZonaAgua;
        private System.Windows.Forms.PictureBox picZonaFuego;
        private System.Windows.Forms.PictureBox picSeleccionIA;
        private System.Windows.Forms.Timer tmrRonda;
        private System.Windows.Forms.PictureBox picResultadoRonda;
    }
}

