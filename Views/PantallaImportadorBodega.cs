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
        public PantallaImportadorBodega()
        {
            InitializeComponent();
        }

        public void opcionImportarActualizacionVinos() 
        {
            GestorImportadorBodega gestor = new GestorImportadorBodega(this);
            gestor.opcionImportarActualizacionVinos();
        }

        public void mostarBodegasParaAcutalizar(List<Bodega> bodegas) 
        {
            BodegaDGV.Rows.Clear();
            foreach (Bodega bodega in bodegas)
            {
                BodegaDGV.Rows.Add(bodega.id,bodega.Nombre, bodega.CoordenadasUbicacion, bodega.UltimaActualizacion, bodega.PeriodoActualizacion);
            }

        }

    }
}
