namespace PPT.Forms
{
    partial class FrmMenuPrincipal
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picZonaSalirMenu = new System.Windows.Forms.PictureBox();
            this.picZonaResultados = new System.Windows.Forms.PictureBox();
            this.picZonaJugar = new System.Windows.Forms.PictureBox();
            this.picZonaEntrenar = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaSalirMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaJugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaEntrenar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = global::PPT.Properties.Resources.MenuPrincipal;
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.picZonaSalirMenu);
            this.pnlMenu.Controls.Add(this.picZonaResultados);
            this.pnlMenu.Controls.Add(this.picZonaJugar);
            this.pnlMenu.Controls.Add(this.picZonaEntrenar);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(884, 511);
            this.pnlMenu.TabIndex = 0;
            // 
            // picZonaSalirMenu
            // 
            this.picZonaSalirMenu.BackColor = System.Drawing.Color.Transparent;
            this.picZonaSalirMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaSalirMenu.Location = new System.Drawing.Point(815, 22);
            this.picZonaSalirMenu.Name = "picZonaSalirMenu";
            this.picZonaSalirMenu.Size = new System.Drawing.Size(43, 37);
            this.picZonaSalirMenu.TabIndex = 3;
            this.picZonaSalirMenu.TabStop = false;
            // 
            // picZonaResultados
            // 
            this.picZonaResultados.BackColor = System.Drawing.Color.Transparent;
            this.picZonaResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaResultados.Location = new System.Drawing.Point(203, 393);
            this.picZonaResultados.Name = "picZonaResultados";
            this.picZonaResultados.Size = new System.Drawing.Size(480, 67);
            this.picZonaResultados.TabIndex = 2;
            this.picZonaResultados.TabStop = false;
            // 
            // picZonaJugar
            // 
            this.picZonaJugar.BackColor = System.Drawing.Color.Transparent;
            this.picZonaJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaJugar.Location = new System.Drawing.Point(203, 292);
            this.picZonaJugar.Name = "picZonaJugar";
            this.picZonaJugar.Size = new System.Drawing.Size(480, 67);
            this.picZonaJugar.TabIndex = 1;
            this.picZonaJugar.TabStop = false;
            // 
            // picZonaEntrenar
            // 
            this.picZonaEntrenar.BackColor = System.Drawing.Color.Transparent;
            this.picZonaEntrenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZonaEntrenar.Location = new System.Drawing.Point(203, 191);
            this.picZonaEntrenar.Name = "picZonaEntrenar";
            this.picZonaEntrenar.Size = new System.Drawing.Size(480, 67);
            this.picZonaEntrenar.TabIndex = 0;
            this.picZonaEntrenar.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picZonaSalirMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaJugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZonaEntrenar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox picZonaResultados;
        private System.Windows.Forms.PictureBox picZonaJugar;
        private System.Windows.Forms.PictureBox picZonaEntrenar;
        private System.Windows.Forms.PictureBox picZonaSalirMenu;
    }
}