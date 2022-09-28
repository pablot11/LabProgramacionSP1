using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryTorresS1
{
    public partial class frmCargarProduccion : Form
    {

        public frmCargarProduccion()
        {
            InitializeComponent();
        }




        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtToneladas.Text != "" && lstCultivo.SelectedIndex != -1 && lstLocalidad.SelectedIndex != -1 && mskFecha.Text != "")
            {
                StreamWriter produccion = new StreamWriter("./Produccion.txt", true);
                produccion.WriteLine(lstCultivo.Text + "," + lstLocalidad.Text + "," + txtToneladas.Text + "," + mskFecha.Text);
                MessageBox.Show("Toneladas cargadas con éxito.");
                produccion.Close();
                lstCultivo.SelectedIndex = -1;
                lstLocalidad.SelectedIndex = -1;
                txtToneladas.Text = "";
                mskFecha.Text = "";

            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }

            

        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
           
          
            StreamReader lectorLocalidad = new StreamReader("./Localidades.txt");
            StreamReader lectorCultivos = new StreamReader("./Cultivos.txt");
            char varSeparador = Convert.ToChar(",");

            while (!lectorCultivos.EndOfStream)
            {
                string[] vecnombreCultivos = lectorCultivos.ReadLine().Split(varSeparador);
                lstCultivo.Items.Add(vecnombreCultivos[1]);
            }

            lectorCultivos.Close();

            while (!lectorLocalidad.EndOfStream)
            {
                string[] vecnombreLocalidad = lectorLocalidad.ReadLine().Split(varSeparador);
                lstLocalidad.Items.Add(vecnombreLocalidad[1]);
            }
            lectorLocalidad.Close();

        }

        private void lstLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlControles();
        }

        private void lstCultivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlControles();
        }

        private void txtToneladas_TextChanged(object sender, EventArgs e)
        {
            ControlControles();
        }
        private void ControlControles()
        {
            if (lstLocalidad.SelectedIndex != -1 && lstCultivo.SelectedIndex != -1 && txtToneladas.Text != "" && mskFecha.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
