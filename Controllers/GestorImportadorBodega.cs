using BomVino_PPAI.Models.DAO;
using BomVino_PPAI.Models.DTO;
using BomVino_PPAI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BomVino_PPAI.Controllers
{
    public class GestorImportadorBodega
    {

        //Facu
        private List<Bodega> listaBodegas = new List<Bodega>();
        private string connectionString = environmentDAO.conexionBD;
        private DateTime fechaActual = new DateTime();

        private BodegaDAO bodegaDAO;
        private PantallaImportadorBodega pantallaImportador;

        public GestorImportadorBodega(PantallaImportadorBodega pantallaImportador)
        {
  
            this.bodegaDAO = new BodegaDAO(connectionString);
            this.listaBodegas = bodegaDAO.getBodegas(); //aca cargamos la lista de bodegas
            this.pantallaImportador = pantallaImportador;
        }
     
        // Métodos
        public void opcionImportarActualizacionVinos()
        {

            //DateTime fechaActual = getFechaActual();
            pantallaImportador.mostarBodegasParaAcutalizar(this.buscarBodegasParaActualizar());
            //---para test despues borrar ---
            //pantallaImportador.mostarBodegasParaAcutalizar(this.listaBodegas);
        }

        private List<Bodega> buscarBodegasParaActualizar()
        {
            List <Bodega> bodegasParaActualizar = new List<Bodega>();
            bool esParaActualizar;
            this.fechaActual = getFechaActual();
  
            foreach (var bodega in listaBodegas)
            {
                esParaActualizar = bodega.estaParaActualizarNovedadesVinos(this.fechaActual);
                if (esParaActualizar)
                {
                    bodega.getNombre();
                    bodegasParaActualizar.Add(bodega);
                }
            }
            return bodegasParaActualizar;

           
        }

        private static DateTime getFechaActual()
        {
            return DateTime.Now;
        }
    }
}

    
