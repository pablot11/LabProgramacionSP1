namespace pryTorresS1
{
    partial class frmConsultarProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarProduccion));
            this.dgvConsultaCultivos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.columnaUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCultivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaCultivos
            // 
            this.dgvConsultaCultivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCultivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaUno,
            this.columnaDos,
            this.columnaTres,
            this.columnaCuatro});
            this.dgvConsultaCultivos.Location = new System.Drawing.Point(9, 10);
            this.dgvConsultaCultivos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsultaCultivos.Name = "dgvConsultaCultivos";
            this.dgvConsultaCultivos.RowHeadersWidth = 51;
            this.dgvConsultaCultivos.RowTemplate.Height = 24;
            this.dgvConsultaCultivos.Size = new System.Drawing.Size(556, 122);
            this.dgvConsultaCultivos.TabIndex = 0;
            this.dgvConsultaCultivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaCultivos_CellContentClick);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(492, 138);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(73, 27);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSalir.Location = new System.Drawing.Point(9, 138);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 27);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // columnaUno
            // 
            this.columnaUno.HeaderText = "Cultivo";
            this.columnaUno.MinimumWidth = 6;
            this.columnaUno.Name = "columnaUno";
            this.columnaUno.ReadOnly = true;
            this.columnaUno.Width = 125;
            // 
            // columnaDos
            // 
            this.columnaDos.HeaderText = "Localidad";
            this.columnaDos.MinimumWidth = 6;
            this.columnaDos.Name = "columnaDos";
            this.columnaDos.ReadOnly = true;
            this.columnaDos.Width = 125;
            // 
            // columnaTres
            // 
            this.columnaTres.HeaderText = "Toneladas";
            this.columnaTres.MinimumWidth = 6;
            this.columnaTres.Name = "columnaTres";
            this.columnaTres.ReadOnly = true;
            this.columnaTres.Width = 125;
            // 
            // columnaCuatro
            // 
            this.columnaCuatro.HeaderText = "Fecha";
            this.columnaCuatro.MinimumWidth = 6;
            this.columnaCuatro.Name = "columnaCuatro";
            this.columnaCuatro.ReadOnly = true;
            this.columnaCuatro.Width = 125;
            // 
            // frmConsultarProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 176);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvConsultaCultivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultarProduccion";
            this.Text = "Producción";
            this.Load += new System.EventHandler(this.frmProduccionVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCultivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaCultivos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTres;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCuatro;
    }
}