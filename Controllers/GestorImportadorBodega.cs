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
        private BodegaDAO bodegaDAO;
        private PantallaImportadorBodega pantallaImportador;

        public GestorImportadorBodega(PantallaImportadorBodega pantallaImportador)
        {
            string connectionString = "Server=RODRIGOFRIAS\\SQLEXPRESS; DataBase=Bonvino;Integrated Security=true; TrustServerCertificate=True"; // Define aquí tu cadena de conexión
            this.bodegaDAO = new BodegaDAO(connectionString);
            this.pantallaImportador = pantallaImportador;
        }
     
        // Métodos
        public void opcionImportarActualizacionVinos()
        {
           
            DateTime fechaActual = getFechaActual();
            pantallaImportador.mostarBodegasParaAcutalizar(this.buscarBodegasParaActualizar(fechaActual));    
        }

        private List<Bodega> buscarBodegasParaActualizar(DateTime fechaActual)
        {
            List <Bodega> bodegasParaActualizar = new List<Bodega>();
            // [Bloque IF / WHILE]
            if (bodegaDAO.estaParaActualizarNovedadesVino(fechaActual) == true)
            {
                bodegasParaActualizar = bodegaDAO.getDatos(fechaActual);
                return bodegasParaActualizar;
       
            }

            else 
            {
                // Pero no hay bodegas para mostar
                return bodegasParaActualizar;
            }
           
        }

        private static DateTime getFechaActual()
        {
            return DateTime.Now;
        }
    }
}

    
