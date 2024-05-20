using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BomVino_PPAI.Views
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Validación de las credenciales
            if (ComboRols.SelectedItem != null && ComboRols.SelectedItem.ToString() == "Administrador De Bonvino" && txtContraseña.Text == "123")
            {
                AdministradorDeBonVino administradorDeBonVino = new AdministradorDeBonVino();
                administradorDeBonVino.Show();
                this.Hide(); // Ocultar el formulario actual
            }
            else
            {
                // Mostrar un mensaje de error si las credenciales son incorrectas
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


    }
}
