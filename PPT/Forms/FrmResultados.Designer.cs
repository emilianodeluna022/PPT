namespace PPT.Forms
{
    partial class FrmResultados
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
            this.pnlMarkov = new System.Windows.Forms.Panel();
            this.lblPlantaPlanta = new System.Windows.Forms.Label();
            this.lblPlantaAgua = new System.Windows.Forms.Label();
            this.lblPlantaFuego = new System.Windows.Forms.Label();
            this.lblAguaPlanta = new System.Windows.Forms.Label();
            this.lblAguaAgua = new System.Windows.Forms.Label();
            this.lblAguaFuego = new System.Windows.Forms.Label();
            this.lblFuegoPlanta = new System.Windows.Forms.Label();
            this.lblFuegoAgua = new System.Windows.Forms.Label();
            this.lblFuegoFuego = new System.Windows.Forms.Label();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.picZonaVolverResumen = new System.Windows.Forms.PictureBox();
            this.picZonaSalirMarkov = new System.Windows.Forms.PictureBox();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.flpVector = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVictorias = new System.Windows.Forms.Label();
            this.lblDerrotas = new System.Windows.Forms.Label();
            this.lblEmpates = new System.Windows.Forms.Label();
            this.lblEntrenamientos = new System.Windows.Forms.Label();
            this.lblJuego = new System.Windows.Forms.Label();
            this.picZonaMarkov = new System.Windows.Forms.PictureBox();
            this.picZonaSalirResultados = new System.Windows.Forms.PictureBox();
            this.pnlMarkov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaVolverResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaSalirMarkov)).BeginInit();
            this.pnlResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaMarkov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaSalirResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMarkov
            // 
            this.pnlMarkov.BackgroundImage = global::PPT.Properties.Resources.ResultadosMarkov;
            this.pnlMarkov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMarkov.Controls.Add(this.lblPlantaPlanta);
            this.pnlMarkov.Controls.Add(this.lblPlantaAgua);
            this.pnlMarkov.Controls.Add(this.lblPlantaFuego);
            this.pnlMarkov.Controls.Add(this.lblAguaPlanta);
            this.pnlMarkov.Controls.Add(this.lblAguaAgua);
            this.pnlMarkov.Controls.Add(this.lblAguaFuego);
            this.pnlMarkov.Controls.Add(this.lblFuegoPlanta);
            this.pnlMarkov.Controls.Add(this.lblFuegoAgua);
            this.pnlMarkov.Controls.Add(this.lblFuegoFuego);
            this.pnlMarkov.Controls.Add(this.dgvMatriz);
            this.pnlMarkov.Controls.Add(this.picZonaVolverResumen);
            this.pnlMarkov.Controls.Add(this.picZonaSalirMarkov);
            this.pnlMarkov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMarkov.Location = new System.Drawing.Point(0, 0);
            this.pnlMarkov.Name = "pnlMarkov";
            this.pnlMarkov.Size = new System.Drawing.Size(884, 561);
            this.pnlMarkov.TabIndex = 0;
            this.pnlMarkov.Visible = false;
            // 
            // lblPlantaPlanta
            // 
            this.lblPlantaPlanta.BackColor = System.Drawing.Color.Transparent;
            this.lblPlantaPlanta.Location = new System.Drawing.Point(653, 415);
            this.lblPlantaPlanta.Name = "lblPlantaPlanta";
            this.lblPlantaPlanta.Size = new System.Drawing.Size(170, 45);
            this.lblPlantaPlanta.TabIndex = 16;
            this.lblPlantaPlanta.Text = "label9";
            this.lblPlantaPlanta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlantaAgua
            // 
            this.lblPlantaAgua.BackColor = System.Drawing.Color.Transparent;
            this.lblPlantaAgua.Location = new System.Drawing.Point(457, 415);
            this.lblPlantaAgua.Name = "lblPlantaAgua";
            this.lblPlantaAgua.Size = new System.Drawing.Size(170, 45);
            this.lblPlantaAgua.TabIndex = 15;
            this.lblPlantaAgua.Text = "label8";
            this.lblPlantaAgua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlantaFuego
            // 
            this.lblPlantaFuego.BackColor = System.Drawing.Color.Transparent;
            this.lblPlantaFuego.Location = new System.Drawing.Point(261, 415);
            this.lblPlantaFuego.Name = "lblPlantaFuego";
            this.lblPlantaFuego.Size = new System.Drawing.Size(170, 45);
            this.lblPlantaFuego.TabIndex = 14;
            this.lblPlantaFuego.Text = "label7";
            this.lblPlantaFuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAguaPlanta
            // 
            this.lblAguaPlanta.BackColor = System.Drawing.Color.Transparent;
            this.lblAguaPlanta.Location = new System.Drawing.Point(653, 339);
            this.lblAguaPlanta.Name = "lblAguaPlanta";
            this.lblAguaPlanta.Size = new System.Drawing.Size(170, 45);
            this.lblAguaPlanta.TabIndex = 13;
            this.lblAguaPlanta.Text = "label6";
            this.lblAguaPlanta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAguaAgua
            // 
            this.lblAguaAgua.BackColor = System.Drawing.Color.Transparent;
            this.lblAguaAgua.Location = new System.Drawing.Point(457, 339);
            this.lblAguaAgua.Name = "lblAguaAgua";
            this.lblAguaAgua.Size = new System.Drawing.Size(170, 45);
            this.lblAguaAgua.TabIndex = 12;
            this.lblAguaAgua.Text = "label5";
            this.lblAguaAgua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAguaFuego
            // 
            this.lblAguaFuego.BackColor = System.Drawing.Color.Transparent;
            this.lblAguaFuego.Location = new System.Drawing.Point(261, 339);
            this.lblAguaFuego.Name = "lblAguaFuego";
            this.lblAguaFuego.Size = new System.Drawing.Size(170, 45);
            this.lblAguaFuego.TabIndex = 11;
            this.lblAguaFuego.Text = "label4";
            this.lblAguaFuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFuegoPlanta
            // 
            this.lblFuegoPlanta.BackColor = System.Drawing.Color.Transparent;
            this.lblFuegoPlanta.Location = new System.Drawing.Point(653, 258);
            this.lblFuegoPlanta.Name = "lblFuegoPlanta";
            this.lblFuegoPlanta.Size = new System.Drawing.Size(170, 45);
            this.lblFuegoPlanta.TabIndex = 10;
            this.lblFuegoPlanta.Text = "label3";
            this.lblFuegoPlanta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFuegoAgua
            // 
            this.lblFuegoAgua.BackColor = System.Drawing.Color.Transparent;
            this.lblFuegoAgua.Location = new System.Drawing.Point(457, 258);
            this.lblFuegoAgua.Name = "lblFuegoAgua";
            this.lblFuegoAgua.Size = new System.Drawing.Size(170, 45);
            this.lblFuegoAgua.TabIndex = 9;
            this.lblFuegoAgua.Text = "label2";
            this.lblFuegoAgua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFuegoFuego
            // 
            this.lblFuegoFuego.BackColor = System.Drawing.Color.Transparent;
            this.lblFuegoFuego.Location = new System.Drawing.Point(261, 253);
            this.lblFuegoFuego.Name = "lblFuegoFuego";
            this.lblFuegoFuego.Size = new System.Drawing.Size(170, 55);
            this.lblFuegoFuego.TabIndex = 8;
            this.lblFuegoFuego.Text = "label1";
            this.lblFuegoFuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(12, 3);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(240, 150);
            this.dgvMatriz.TabIndex = 7;
            this.dgvMatriz.Visible = false;
            // 
            // picZonaVolverResumen
            // 
            this.picZonaVolverResumen.BackColor = System.Drawing.Color.Transparent;
            this.picZonaVolverResumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaVolverResumen.Location = new System.Drawing.Point(388, 505);
            this.picZonaVolverResumen.Name = "picZonaVolverResumen";
            this.picZonaVolverResumen.Size = new System.Drawing.Size(108, 44);
            this.picZonaVolverResumen.TabIndex = 1;
            this.picZonaVolverResumen.TabStop = false;
            // 
            // picZonaSalirMarkov
            // 
            this.picZonaSalirMarkov.BackColor = System.Drawing.Color.Transparent;
            this.picZonaSalirMarkov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaSalirMarkov.Location = new System.Drawing.Point(810, 13);
            this.picZonaSalirMarkov.Name = "picZonaSalirMarkov";
            this.picZonaSalirMarkov.Size = new System.Drawing.Size(62, 56);
            this.picZonaSalirMarkov.TabIndex = 0;
            this.picZonaSalirMarkov.TabStop = false;
            // 
            // pnlResumen
            // 
            this.pnlResumen.BackgroundImage = global::PPT.Properties.Resources.ResultadosResumen;
            this.pnlResumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlResumen.Controls.Add(this.flpVector);
            this.pnlResumen.Controls.Add(this.lblTotal);
            this.pnlResumen.Controls.Add(this.lblVictorias);
            this.pnlResumen.Controls.Add(this.lblDerrotas);
            this.pnlResumen.Controls.Add(this.lblEmpates);
            this.pnlResumen.Controls.Add(this.lblEntrenamientos);
            this.pnlResumen.Controls.Add(this.lblJuego);
            this.pnlResumen.Controls.Add(this.picZonaMarkov);
            this.pnlResumen.Controls.Add(this.picZonaSalirResultados);
            this.pnlResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResumen.Location = new System.Drawing.Point(0, 0);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(884, 561);
            this.pnlResumen.TabIndex = 9;
            // 
            // flpVector
            // 
            this.flpVector.BackColor = System.Drawing.Color.Transparent;
            this.flpVector.Location = new System.Drawing.Point(404, 421);
            this.flpVector.Name = "flpVector";
            this.flpVector.Size = new System.Drawing.Size(430, 60);
            this.flpVector.TabIndex = 6;
            this.flpVector.WrapContents = false;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(243, 227);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 23);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "label1";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVictorias
            // 
            this.lblVictorias.BackColor = System.Drawing.Color.Transparent;
            this.lblVictorias.Location = new System.Drawing.Point(426, 233);
            this.lblVictorias.Name = "lblVictorias";
            this.lblVictorias.Size = new System.Drawing.Size(35, 13);
            this.lblVictorias.TabIndex = 3;
            this.lblVictorias.Text = "label1";
            this.lblVictorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDerrotas
            // 
            this.lblDerrotas.BackColor = System.Drawing.Color.Transparent;
            this.lblDerrotas.Location = new System.Drawing.Point(607, 233);
            this.lblDerrotas.Name = "lblDerrotas";
            this.lblDerrotas.Size = new System.Drawing.Size(35, 13);
            this.lblDerrotas.TabIndex = 4;
            this.lblDerrotas.Text = "label1";
            this.lblDerrotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpates
            // 
            this.lblEmpates.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpates.Location = new System.Drawing.Point(243, 361);
            this.lblEmpates.Name = "lblEmpates";
            this.lblEmpates.Size = new System.Drawing.Size(35, 13);
            this.lblEmpates.TabIndex = 5;
            this.lblEmpates.Text = "label1";
            this.lblEmpates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrenamientos
            // 
            this.lblEntrenamientos.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrenamientos.Location = new System.Drawing.Point(421, 361);
            this.lblEntrenamientos.Name = "lblEntrenamientos";
            this.lblEntrenamientos.Size = new System.Drawing.Size(35, 13);
            this.lblEntrenamientos.TabIndex = 1;
            this.lblEntrenamientos.Text = "label1";
            this.lblEntrenamientos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJuego
            // 
            this.lblJuego.BackColor = System.Drawing.Color.Transparent;
            this.lblJuego.Location = new System.Drawing.Point(606, 361);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(35, 13);
            this.lblJuego.TabIndex = 2;
            this.lblJuego.Text = "label1";
            this.lblJuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picZonaMarkov
            // 
            this.picZonaMarkov.BackColor = System.Drawing.Color.Transparent;
            this.picZonaMarkov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaMarkov.Location = new System.Drawing.Point(388, 505);
            this.picZonaMarkov.Name = "picZonaMarkov";
            this.picZonaMarkov.Size = new System.Drawing.Size(108, 44);
            this.picZonaMarkov.TabIndex = 1;
            this.picZonaMarkov.TabStop = false;
            // 
            // picZonaSalirResultados
            // 
            this.picZonaSalirResultados.BackColor = System.Drawing.Color.Transparent;
            this.picZonaSalirResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaSalirResultados.Location = new System.Drawing.Point(820, 26);
            this.picZonaSalirResultados.Name = "picZonaSalirResultados";
            this.picZonaSalirResultados.Size = new System.Drawing.Size(37, 31);
            this.picZonaSalirResultados.TabIndex = 0;
            this.picZonaSalirResultados.TabStop = false;
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.pnlMarkov);
            this.Name = "FrmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.pnlMarkov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaVolverResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaSalirMarkov)).EndInit();
            this.pnlResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picZonaMarkov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaSalirResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEntrenamientos;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.Label lblVictorias;
        private System.Windows.Forms.Label lblDerrotas;
        private System.Windows.Forms.Label lblEmpates;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Panel pnlMarkov;
        private System.Windows.Forms.PictureBox picZonaVolverResumen;
        private System.Windows.Forms.PictureBox picZonaSalirMarkov;
        private System.Windows.Forms.PictureBox picZonaMarkov;
        private System.Windows.Forms.PictureBox picZonaSalirResultados;
        private System.Windows.Forms.FlowLayoutPanel flpVector;
        private System.Windows.Forms.Label lblFuegoFuego;
        private System.Windows.Forms.Label lblPlantaPlanta;
        private System.Windows.Forms.Label lblPlantaAgua;
        private System.Windows.Forms.Label lblPlantaFuego;
        private System.Windows.Forms.Label lblAguaPlanta;
        private System.Windows.Forms.Label lblAguaAgua;
        private System.Windows.Forms.Label lblAguaFuego;
        private System.Windows.Forms.Label lblFuegoPlanta;
        private System.Windows.Forms.Label lblFuegoAgua;
    }
}