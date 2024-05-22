using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomVino_PPAI.Models.DTO
{
    internal class Varietal
    {
        public string Nombre { get; set; }
        public int PorcentajeComposicion { get; set; }

        public Varietal(string nombre, int porcentajeComposicion)
        {
            Nombre = nombre;
            PorcentajeComposicion = porcentajeComposicion;
        }

        public Varietal()
        {
        }
    }
}
