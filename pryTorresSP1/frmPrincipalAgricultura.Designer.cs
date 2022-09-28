namespace pryTorresS1
{
    partial class frmPrincipalAgricultura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalAgricultura));
            this.msMenuCultivos = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cultivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogoCultivos = new System.Windows.Forms.PictureBox();
            this.msMenuCultivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCultivos)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenuCultivos
            // 
            this.msMenuCultivos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuCultivos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.msMenuCultivos.Location = new System.Drawing.Point(0, 0);
            this.msMenuCultivos.Name = "msMenuCultivos";
            this.msMenuCultivos.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msMenuCultivos.Size = new System.Drawing.Size(428, 24);
            this.msMenuCultivos.TabIndex = 0;
            this.msMenuCultivos.Text = "menuStrip1";
            this.msMenuCultivos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msMenuCultivos_ItemClicked);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadesToolStripMenuItem,
            this.cultivosToolStripMenuItem,
            this.produToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // cultivosToolStripMenuItem
            // 
            this.cultivosToolStripMenuItem.Name = "cultivosToolStripMenuItem";
            this.cultivosToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cultivosToolStripMenuItem.Text = "Cultivos";
            this.cultivosToolStripMenuItem.Click += new System.EventHandler(this.cultivosToolStripMenuItem_Click);
            // 
            // produToolStripMenuItem
            // 
            this.produToolStripMenuItem.Name = "produToolStripMenuItem";
            this.produToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.produToolStripMenuItem.Text = "Producción";
            this.produToolStripMenuItem.Click += new System.EventHandler(this.produToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produccionToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // produccionToolStripMenuItem
            // 
            this.produccionToolStripMenuItem.Name = "produccionToolStripMenuItem";
            this.produccionToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.produccionToolStripMenuItem.Text = "Producción";
            this.produccionToolStripMenuItem.Click += new System.EventHandler(this.produccionToolStripMenuItem_Click);
            // 
            // picLogoCultivos
            // 
            this.picLogoCultivos.Image = ((System.Drawing.Image)(resources.GetObject("picLogoCultivos.Image")));
            this.picLogoCultivos.Location = new System.Drawing.Point(31, 25);
            this.picLogoCultivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogoCultivos.Name = "picLogoCultivos";
            this.picLogoCultivos.Size = new System.Drawing.Size(384, 416);
            this.picLogoCultivos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogoCultivos.TabIndex = 1;
            this.picLogoCultivos.TabStop = false;
            // 
            // frmPrincipalAgricultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 514);
            this.Controls.Add(this.picLogoCultivos);
            this.Controls.Add(this.msMenuCultivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuCultivos;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipalAgricultura";
            this.Text = "Agricultura - SP1";
            this.Load += new System.EventHandler(this.frmPrincipalAgricultura_Load);
            this.msMenuCultivos.ResumeLayout(false);
            this.msMenuCultivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCultivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuCultivos;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cultivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produccionToolStripMenuItem;
        private System.Windows.Forms.PictureBox picLogoCultivos;
    }
}

