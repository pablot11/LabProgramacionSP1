namespace pryTorresS1
{
    partial class frmCargarProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarProduccion));
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.lblProduccionToneladas = new System.Windows.Forms.Label();
            this.lblSeleccionarLocalidad = new System.Windows.Forms.Label();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.lstCultivo = new System.Windows.Forms.ComboBox();
            this.lblTipoCultivo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtToneladas
            // 
            this.txtToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToneladas.Location = new System.Drawing.Point(76, 72);
            this.txtToneladas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(92, 21);
            this.txtToneladas.TabIndex = 0;
            this.txtToneladas.TextChanged += new System.EventHandler(this.txtToneladas_TextChanged);
            // 
            // lblProduccionToneladas
            // 
            this.lblProduccionToneladas.AutoSize = true;
            this.lblProduccionToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduccionToneladas.Location = new System.Drawing.Point(9, 72);
            this.lblProduccionToneladas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduccionToneladas.Name = "lblProduccionToneladas";
            this.lblProduccionToneladas.Size = new System.Drawing.Size(65, 15);
            this.lblProduccionToneladas.TabIndex = 1;
            this.lblProduccionToneladas.Text = "Toneladas";
            // 
            // lblSeleccionarLocalidad
            // 
            this.lblSeleccionarLocalidad.AutoSize = true;
            this.lblSeleccionarLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarLocalidad.Location = new System.Drawing.Point(9, 15);
            this.lblSeleccionarLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionarLocalidad.Name = "lblSeleccionarLocalidad";
            this.lblSeleccionarLocalidad.Size = new System.Drawing.Size(61, 15);
            this.lblSeleccionarLocalidad.TabIndex = 2;
            this.lblSeleccionarLocalidad.Text = "Localidad";
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(76, 15);
            this.lstLocalidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(92, 23);
            this.lstLocalidad.TabIndex = 3;
            this.lstLocalidad.SelectedIndexChanged += new System.EventHandler(this.lstLocalidad_SelectedIndexChanged);
            // 
            // lstCultivo
            // 
            this.lstCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(76, 43);
            this.lstCultivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(92, 23);
            this.lstCultivo.TabIndex = 4;
            this.lstCultivo.SelectedIndexChanged += new System.EventHandler(this.lstCultivo_SelectedIndexChanged);
            // 
            // lblTipoCultivo
            // 
            this.lblTipoCultivo.AutoSize = true;
            this.lblTipoCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCultivo.Location = new System.Drawing.Point(9, 43);
            this.lblTipoCultivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCultivo.Name = "lblTipoCultivo";
            this.lblTipoCultivo.Size = new System.Drawing.Size(43, 15);
            this.lblTipoCultivo.TabIndex = 5;
            this.lblTipoCultivo.Text = "Cultivo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(102, 132);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(61, 27);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(9, 100);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(76, 98);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(65, 21);
            this.txtFecha.TabIndex = 9;
            // 
            // mskFecha
            // 
            this.mskFecha.Location = new System.Drawing.Point(76, 100);
            this.mskFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskFecha.Mask = "00/00/0000";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.Size = new System.Drawing.Size(65, 20);
            this.mskFecha.TabIndex = 10;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSalir.Location = new System.Drawing.Point(12, 132);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 27);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCargarProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 167);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTipoCultivo);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.lblSeleccionarLocalidad);
            this.Controls.Add(this.lblProduccionToneladas);
            this.Controls.Add(this.txtToneladas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCargarProduccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.Label lblProduccionToneladas;
        private System.Windows.Forms.Label lblSeleccionarLocalidad;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.ComboBox lstCultivo;
        private System.Windows.Forms.Label lblTipoCultivo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Button btnSalir;
    }
}