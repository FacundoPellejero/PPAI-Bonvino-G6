using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BomVino_PPAI.Views
{
    public partial class AdministradorDeBonVino : Form
    {
        public AdministradorDeBonVino()
        {
            InitializeComponent();
        }

        private void OpcionImportarActualizacionVinos(object sender, EventArgs e)
        {

            // Crear una instancia del segundo formulario
  
            PantallaImportadorBodega pantallaImportadorBodega = new PantallaImportadorBodega();
            pantallaImportadorBodega.Show();
            pantallaImportadorBodega.opcionImportarActualizacionVinos();
            this.Hide();


        }


    }
}
