﻿using BomVino_PPAI.Controllers;
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
            foreach (DataGridViewCell celda in BodegaDGV.SelectedCells)
            {
                Console.WriteLine($"Celda seleccionada en fila {celda.RowIndex}, columna {celda.ColumnIndex}");

            }
        }
    }
}
