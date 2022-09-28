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
    public partial class frmPrincipalAgricultura : Form
    {
        public frmPrincipalAgricultura()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarLocalidades objLocalidades = new frmCargarLocalidades();
            objLocalidades.ShowDialog();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarCultivos objCultivos = new frmCargarCultivos();
            objCultivos.ShowDialog();
        }

        private void produToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarProduccion objProduccion = new frmCargarProduccion();
            objProduccion.ShowDialog();
        }

        private void frmPrincipalAgricultura_Load(object sender, EventArgs e)
        {
            if (File.Exists("./Localidades.txt"))
            {

            }
            else
            {
                File.Create("./Localidades.txt");
            }
            if (File.Exists("./Cultivos.txt"))
            {

            }
            else
            {
                File.Create("./Cultivos.txt");
            }
            if (File.Exists("./Produccion.txt"))
            {

            }
            else
            {
                File.Create("./Produccion.txt");
            }
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmConsultarProduccion objVentanaVerProduccion = new frmConsultarProduccion();
            objVentanaVerProduccion.ShowDialog();
        }

        private void msMenuCultivos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
