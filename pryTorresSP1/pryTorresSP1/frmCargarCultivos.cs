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
    public partial class frmCargarCultivos : Form
    {
        public frmCargarCultivos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Si los controles estan vacios no entra al if
            if (txtNombreCultivo.Text != "" && mskNumeroCultivo.Text != "")
            {
                //Variable booleana se le asigna el valor false
                bool bandera = false;
                //El streamreader nos permite leer un archivo, se inicializa el streamreader para el archivo
                StreamReader srControladorCultivos = new StreamReader("./Cultivos.txt");
                //Mientras sea final de archivo 
                while (!srControladorCultivos.EndOfStream)
                {
                    //creo una variable para asignarle un registro del archivo
                    string auxCodigo = srControladorCultivos.ReadLine();
                    //el registro se carga en el vector, el split lo separa en cada posicion de memoria
                    string[] vecLocalidades = auxCodigo.Split(',');
                    //Compara si lo que esta en la mask es igual a la posicion del vector
                    if (mskNumeroCultivo.Text == vecLocalidades[0])
                    {
                        
                        MessageBox.Show("Numero Repetido");
                        //el booleano se le asigna true 
                        bandera = true;
                    }
                }
                srControladorCultivos.Close();

                // si el booleano es false entra al if
                if (bandera == false)
                {
                    //Streamwriter es para abrir un archivo en escritura, el true quiere dcir que si existe el archivo lo abre y edita, si no lo crea
                    StreamWriter cultivos = new StreamWriter("./Cultivos.txt", true);
                    //Crea un renglon con los siguientes controles
                    cultivos.WriteLine(mskNumeroCultivo.Text + "," + txtNombreCultivo.Text);
                    MessageBox.Show("Cultivo cargado con éxito.");
                    cultivos.Close();
                    txtNombreCultivo.Text = "";
                    mskNumeroCultivo.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            
        }

        private void txtNumeroCultivo_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void txtNombreCultivo_TextChanged(object sender, EventArgs e)
        {
            ControlControles();
        }

        private void mskNumeroCultivo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ControlControles();
        }
        // Procedimiento del programador para controlar que esten los campos completos

        private void ControlControles()
        {
            if (txtNombreCultivo.Text != "" && mskNumeroCultivo.Text != "")
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

        private void frmCargarCultivos_Load(object sender, EventArgs e)
        {

        }
    }
}
