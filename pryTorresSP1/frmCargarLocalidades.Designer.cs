namespace pryTorresS1
{
    partial class frmCargarLocalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarLocalidades));
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.lblNumeroLocalidad = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mskNumeroLocalidad = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroLocalidad = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLocalidad.Location = new System.Drawing.Point(89, 7);
            this.txtNombreLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreLocalidad.MaxLength = 0;
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(76, 21);
            this.txtNombreLocalidad.TabIndex = 0;
            this.txtNombreLocalidad.TextChanged += new System.EventHandler(this.txtNombreLocalidad_TextChanged);
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLocalidad.Location = new System.Drawing.Point(9, 7);
            this.lblNombreLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(75, 29);
            this.lblNombreLocalidad.TabIndex = 1;
            this.lblNombreLocalidad.Text = "Localidad:\r\n";
            // 
            // lblNumeroLocalidad
            // 
            this.lblNumeroLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroLocalidad.Location = new System.Drawing.Point(9, 37);
            this.lblNumeroLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroLocalidad.Name = "lblNumeroLocalidad";
            this.lblNumeroLocalidad.Size = new System.Drawing.Size(75, 29);
            this.lblNumeroLocalidad.TabIndex = 3;
            this.lblNumeroLocalidad.Text = "Numero\r\n";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(108, 67);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(61, 26);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mskNumeroLocalidad
            // 
            this.mskNumeroLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNumeroLocalidad.Location = new System.Drawing.Point(89, 37);
            this.mskNumeroLocalidad.Mask = "99999";
            this.mskNumeroLocalidad.Name = "mskNumeroLocalidad";
            this.mskNumeroLocalidad.Size = new System.Drawing.Size(61, 21);
            this.mskNumeroLocalidad.TabIndex = 8;
            this.mskNumeroLocalidad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskNumeroLocalidad_MaskInputRejected);
            // 
            // txtNumeroLocalidad
            // 
            this.txtNumeroLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroLocalidad.Location = new System.Drawing.Point(89, 37);
            this.txtNumeroLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroLocalidad.Name = "txtNumeroLocalidad";
            this.txtNumeroLocalidad.Size = new System.Drawing.Size(61, 21);
            this.txtNumeroLocalidad.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSalir.Location = new System.Drawing.Point(12, 68);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 26);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCargarLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 102);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mskNumeroLocalidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNumeroLocalidad);
            this.Controls.Add(this.txtNumeroLocalidad);
            this.Controls.Add(this.lblNombreLocalidad);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCargarLocalidades";
            this.Text = "Localidades";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLocalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.Label lblNumeroLocalidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MaskedTextBox mskNumeroLocalidad;
        private System.Windows.Forms.TextBox txtNumeroLocalidad;
        private System.Windows.Forms.Button btnSalir;
    }
}