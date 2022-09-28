namespace pryTorresS1
{
    partial class frmCargarCultivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarCultivos));
            this.lblNumeroCultivo = new System.Windows.Forms.Label();
            this.txtNumeroCultivo = new System.Windows.Forms.TextBox();
            this.lblNombreCultivo = new System.Windows.Forms.Label();
            this.txtNombreCultivo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mskNumeroCultivo = new System.Windows.Forms.MaskedTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroCultivo
            // 
            this.lblNumeroCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNumeroCultivo.Location = new System.Drawing.Point(12, 48);
            this.lblNumeroCultivo.Name = "lblNumeroCultivo";
            this.lblNumeroCultivo.Size = new System.Drawing.Size(100, 39);
            this.lblNumeroCultivo.TabIndex = 7;
            this.lblNumeroCultivo.Text = "Numero\r\n\r\n\r\n";
            // 
            // txtNumeroCultivo
            // 
            this.txtNumeroCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNumeroCultivo.Location = new System.Drawing.Point(99, 48);
            this.txtNumeroCultivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroCultivo.Name = "txtNumeroCultivo";
            this.txtNumeroCultivo.Size = new System.Drawing.Size(75, 21);
            this.txtNumeroCultivo.TabIndex = 6;
            this.txtNumeroCultivo.TextChanged += new System.EventHandler(this.txtNumeroCultivo_TextChanged);
            // 
            // lblNombreCultivo
            // 
            this.lblNombreCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNombreCultivo.Location = new System.Drawing.Point(12, 9);
            this.lblNombreCultivo.Name = "lblNombreCultivo";
            this.lblNombreCultivo.Size = new System.Drawing.Size(61, 39);
            this.lblNombreCultivo.TabIndex = 5;
            this.lblNombreCultivo.Text = "Cultivo";
            // 
            // txtNombreCultivo
            // 
            this.txtNombreCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNombreCultivo.Location = new System.Drawing.Point(99, 9);
            this.txtNombreCultivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCultivo.MaxLength = 40;
            this.txtNombreCultivo.Name = "txtNombreCultivo";
            this.txtNombreCultivo.Size = new System.Drawing.Size(100, 21);
            this.txtNombreCultivo.TabIndex = 4;
            this.txtNombreCultivo.TextChanged += new System.EventHandler(this.txtNombreCultivo_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAceptar.Location = new System.Drawing.Point(117, 85);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 33);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mskNumeroCultivo
            // 
            this.mskNumeroCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mskNumeroCultivo.Location = new System.Drawing.Point(99, 48);
            this.mskNumeroCultivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskNumeroCultivo.Mask = "99999";
            this.mskNumeroCultivo.Name = "mskNumeroCultivo";
            this.mskNumeroCultivo.Size = new System.Drawing.Size(75, 21);
            this.mskNumeroCultivo.TabIndex = 9;
            this.mskNumeroCultivo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskNumeroCultivo_MaskInputRejected);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSalir.Location = new System.Drawing.Point(15, 85);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 33);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCargarCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 126);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mskNumeroCultivo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNumeroCultivo);
            this.Controls.Add(this.txtNumeroCultivo);
            this.Controls.Add(this.lblNombreCultivo);
            this.Controls.Add(this.txtNombreCultivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCargarCultivos";
            this.Text = "Cultivos";
            this.Load += new System.EventHandler(this.frmCargarCultivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroCultivo;
        private System.Windows.Forms.TextBox txtNumeroCultivo;
        private System.Windows.Forms.Label lblNombreCultivo;
        private System.Windows.Forms.TextBox txtNombreCultivo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MaskedTextBox mskNumeroCultivo;
        private System.Windows.Forms.Button btnSalir;
    }
}