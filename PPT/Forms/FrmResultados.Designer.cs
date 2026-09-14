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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEntrenamientos = new System.Windows.Forms.Label();
            this.lblJuego = new System.Windows.Forms.Label();
            this.lblVictorias = new System.Windows.Forms.Label();
            this.lblDerrotas = new System.Windows.Forms.Label();
            this.lblEmpates = new System.Windows.Forms.Label();
            this.txtVector = new System.Windows.Forms.TextBox();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnSalirResultados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(27, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "label1";
            // 
            // lblEntrenamientos
            // 
            this.lblEntrenamientos.AutoSize = true;
            this.lblEntrenamientos.Location = new System.Drawing.Point(27, 73);
            this.lblEntrenamientos.Name = "lblEntrenamientos";
            this.lblEntrenamientos.Size = new System.Drawing.Size(35, 13);
            this.lblEntrenamientos.TabIndex = 1;
            this.lblEntrenamientos.Text = "label1";
            // 
            // lblJuego
            // 
            this.lblJuego.AutoSize = true;
            this.lblJuego.Location = new System.Drawing.Point(27, 109);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(35, 13);
            this.lblJuego.TabIndex = 2;
            this.lblJuego.Text = "label1";
            // 
            // lblVictorias
            // 
            this.lblVictorias.AutoSize = true;
            this.lblVictorias.Location = new System.Drawing.Point(27, 148);
            this.lblVictorias.Name = "lblVictorias";
            this.lblVictorias.Size = new System.Drawing.Size(35, 13);
            this.lblVictorias.TabIndex = 3;
            this.lblVictorias.Text = "label1";
            // 
            // lblDerrotas
            // 
            this.lblDerrotas.AutoSize = true;
            this.lblDerrotas.Location = new System.Drawing.Point(27, 181);
            this.lblDerrotas.Name = "lblDerrotas";
            this.lblDerrotas.Size = new System.Drawing.Size(35, 13);
            this.lblDerrotas.TabIndex = 4;
            this.lblDerrotas.Text = "label1";
            // 
            // lblEmpates
            // 
            this.lblEmpates.AutoSize = true;
            this.lblEmpates.Location = new System.Drawing.Point(27, 216);
            this.lblEmpates.Name = "lblEmpates";
            this.lblEmpates.Size = new System.Drawing.Size(35, 13);
            this.lblEmpates.TabIndex = 5;
            this.lblEmpates.Text = "label1";
            // 
            // txtVector
            // 
            this.txtVector.Location = new System.Drawing.Point(30, 248);
            this.txtVector.Multiline = true;
            this.txtVector.Name = "txtVector";
            this.txtVector.ReadOnly = true;
            this.txtVector.Size = new System.Drawing.Size(100, 20);
            this.txtVector.TabIndex = 6;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(470, 117);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(240, 150);
            this.dgvMatriz.TabIndex = 7;
            // 
            // btnSalirResultados
            // 
            this.btnSalirResultados.Location = new System.Drawing.Point(496, 342);
            this.btnSalirResultados.Name = "btnSalirResultados";
            this.btnSalirResultados.Size = new System.Drawing.Size(75, 23);
            this.btnSalirResultados.TabIndex = 8;
            this.btnSalirResultados.Text = "button1";
            this.btnSalirResultados.UseVisualStyleBackColor = true;
            this.btnSalirResultados.Click += new System.EventHandler(this.btnSalirResultados_Click);
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.btnSalirResultados);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.txtVector);
            this.Controls.Add(this.lblEmpates);
            this.Controls.Add(this.lblDerrotas);
            this.Controls.Add(this.lblVictorias);
            this.Controls.Add(this.lblJuego);
            this.Controls.Add(this.lblEntrenamientos);
            this.Controls.Add(this.lblTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEntrenamientos;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.Label lblVictorias;
        private System.Windows.Forms.Label lblDerrotas;
        private System.Windows.Forms.Label lblEmpates;
        private System.Windows.Forms.TextBox txtVector;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnSalirResultados;
    }
}