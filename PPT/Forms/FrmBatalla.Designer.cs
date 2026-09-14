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
            this.btnPiedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTijera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.btnPiedra.Location = new System.Drawing.Point(365, 157);
            this.btnPiedra.Name = "button1";
            this.btnPiedra.Size = new System.Drawing.Size(75, 23);
            this.btnPiedra.TabIndex = 1;
            this.btnPiedra.Text = "PIEDRA";
            this.btnPiedra.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.btnPapel.Location = new System.Drawing.Point(365, 201);
            this.btnPapel.Name = "button2";
            this.btnPapel.Size = new System.Drawing.Size(75, 23);
            this.btnPapel.TabIndex = 3;
            this.btnPapel.Text = "PAPEL";
            this.btnPapel.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.btnTijera.Location = new System.Drawing.Point(365, 244);
            this.btnTijera.Name = "button3";
            this.btnTijera.Size = new System.Drawing.Size(75, 23);
            this.btnTijera.TabIndex = 4;
            this.btnTijera.Text = "TIJERA";
            this.btnTijera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTijera);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPiedra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTijera;
    }
}

