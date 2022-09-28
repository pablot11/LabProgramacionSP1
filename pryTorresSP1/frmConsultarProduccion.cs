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
    public partial class frmConsultarProduccion : Form
    {
        public frmConsultarProduccion()
        {
            InitializeComponent();
        }

        private void frmProduccionVer_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvConsultaCultivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnListar_Click(object sender, EventArgs e)


        {
            //Limpia la grilla
            dgvConsultaCultivos.Rows.Clear();   
            //Se abre el archivo en modo lectura, se inicializa en el archivo especificado
            StreamReader srLeectorProduccion = new StreamReader("./Produccion.txt");
            //Mientras sea distinto a EOF se repite lo siguiente
            while (!srLeectorProduccion.EndOfStream)
            {
                //se crea una variable para asignar un renglon del archivo
                string varProduccion = srLeectorProduccion.ReadLine();
                //se crea un vector para asignar el valor de la variable, el split divide la cadena para la posicion de cada vector
                string[] vecProduccion = varProduccion.Split(',');
                //añade filas a la grilla con las siguientes posiciones del vector
                dgvConsultaCultivos.Rows.Add(vecProduccion[0], vecProduccion[1], vecProduccion[2], vecProduccion[3]);
            }
            srLeectorProduccion.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
