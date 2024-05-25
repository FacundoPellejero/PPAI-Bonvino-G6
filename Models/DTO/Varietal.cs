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
        public TipoUva TipoUva { get; set; }

        public Varietal(string nombre, int porcentajeComposicion, TipoUva tipoUva)
        {
            Nombre = nombre;
            PorcentajeComposicion = porcentajeComposicion;
            TipoUva = tipoUva;
        }

        public Varietal()
        {
        }
    }
}
