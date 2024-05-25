using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomVino_PPAI.Models.DTO
{
    internal class Siguiendo
    {


        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public Bodega Bodega { get; set; }

        public Siguiendo(DateTime fechaFin, DateTime fechaInicio, Bodega bodega)
        {
            FechaFin = fechaFin;
            FechaInicio = fechaInicio;
            Bodega = bodega;
        }

        public Siguiendo()
        {
        }
    }
}
