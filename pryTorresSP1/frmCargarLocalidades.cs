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
    public partial class frmCargarLocalidades : Form
    {
        public frmCargarLocalidades()
        {
            InitializeComponent();
        }

        private void txtNombreLocalidad_TextChanged(object sender, EventArgs e)
        {
            ControlControles();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Si los controles estan vacios no entra al if
            if (mskNumeroLocalidad.Text != "" && txtNombreLocalidad.Text != "")
            {
                //Variable booleana se le asigna el valor false
                bool bandera = false;
                //El streamreader nos permite leer un archivo, se inicializa el streamreader para el archivo
                StreamReader srControladorLocalidades = new StreamReader("./Localidades.txt");
                //Mientras sea final de archivo 
                while (!srControladorLocalidades.EndOfStream)
                {
                    //Se crea una variable que se le asigna un registro o renglo del archivo
                    string auxCodigo = srControladorLocalidades.ReadLine();
                    //Se asigna al vector la variable, el slit separa la cadena para cada posicion del vector
                    string[] vecLocalidades = auxCodigo.Split(',');
                    //Si la masked es igual a la posicion del vector entra, si no,no
                    if (mskNumeroLocalidad.Text == auxCodigo.Substring(0, 5))
                    {
                        MessageBox.Show("Numero Repetido");
                        //el booleano retoma el valor true
                        bandera = true;
                    }
                }
                srControladorLocalidades.Close();
                // Si es false el booleano pasa
                if (bandera == false)
                {
                    //Streamwriter es para abrir un archivo en escritura, el true quiere dcir que si existe el archivo lo abre y edita, si no lo crea
                    StreamWriter localidades = new StreamWriter("./Localidades.txt", true);
                    //Crea un renglon con los siguientes controles
                    localidades.WriteLine(mskNumeroLocalidad.Text + "," + txtNombreLocalidad.Text);
                    MessageBox.Show("Localidad cargado con éxito.");
                    localidades.Close();
                    txtNombreLocalidad.Text = "";
                    mskNumeroLocalidad.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
      
           
        }
           
      
        private void frmLocalidades_Load(object sender, EventArgs e)
        {
            txtNombreLocalidad.Focus();
        }

        private void mskNumeroLocalidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            ControlControles();

        }

        private void txtNumeroLocalidad_TextChanged(object sender, EventArgs e)
        {
            
        }
    
        private void ControlControles()
        {
            if (txtNombreLocalidad.Text != "" && mskNumeroLocalidad.Text != "")
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
