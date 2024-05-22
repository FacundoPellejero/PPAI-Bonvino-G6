using BomVino_PPAI.Models.DAO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomVino_PPAI.Models.DTO
{
    public class Bodega
    {
        // Atributos
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CoordenadasUbicacion { get; set; }
        public DateTime UltimaActualizacion { get; set; }
        public int PeriodoActualizacion { get; set; } // En meses

        // Constructor
        public Bodega(int id,string nombre, string descripcion, string coordenadasUbicacion, DateTime ultimaActualizacion, int periodoActualizacion)
        {
            this.id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            CoordenadasUbicacion = coordenadasUbicacion;
            UltimaActualizacion = ultimaActualizacion;
            PeriodoActualizacion = periodoActualizacion;
        }

        // Construcor Vacio
        public Bodega()
        {
        }
        public static void test()
        {
            
        }


        public bool estaParaActualizarNovedadesVinos(DateTime fechaActual)
        {
            if ((fechaActual - this.UltimaActualizacion).TotalDays >= this.PeriodoActualizacion * 30)
            {
                return true;
            }
                return false;
        }

        public string getNombre()
        {
            return this.Nombre;
        }

    }
}
