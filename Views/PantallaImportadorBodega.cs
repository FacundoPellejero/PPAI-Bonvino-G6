using BomVino_PPAI.Controllers;
using BomVino_PPAI.Models.DTO;
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
    public partial class PantallaImportadorBodega : Form
    {
        private GestorImportadorBodega gestor;
        private string nombreBodegaSeleccionada;
        public PantallaImportadorBodega()
        {
            InitializeComponent();
            BodegaDGV.SelectionChanged += BodegaDGV_SelectionChanged;
        }

        public void opcionImportarActualizacionVinos()
        {
            this.gestor = new GestorImportadorBodega(this);
            gestor.opcionImportarActualizacionVinos();
        }

        public void mostarBodegasParaAcutalizar(List<Bodega> bodegas)
        {
            BodegaDGV.Rows.Clear();
            foreach (Bodega bodega in bodegas)
            {
                BodegaDGV.Rows.Add(bodega.id, bodega.Nombre, bodega.Descripcion, bodega.UltimaActualizacion, bodega.PeriodoActualizacion);
            }

        }

        public void tomarSeleccionBodega()
        {
            this.gestor.tomarSeleccionBodega(nombreBodegaSeleccionada);
        }


        private void btnRegistrarVarietal_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void BodegaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureSearch_Click(object sender, EventArgs e)
        {


        }

        private void BodegaDGV_SelectionChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewCell celda in BodegaDGV.SelectedCells)
            //{
            //    Console.WriteLine($"Celda seleccionada en fila {celda.RowIndex}, columna {celda.ColumnIndex}");

            //}

            if (BodegaDGV.SelectedCells.Count > 0)
            {
                DataGridViewCell seleccionado = BodegaDGV.SelectedCells[0];
                int rowIndex = seleccionado.RowIndex;

                DataGridViewRow selectedRow = BodegaDGV.Rows[rowIndex];

                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                this.nombreBodegaSeleccionada = nombre;
                //MessageBox.Show(nombre);
            }
        }


    }
}
