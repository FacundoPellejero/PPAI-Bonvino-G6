using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BomVino_PPAI.Models.DTO
{
    internal class Vino
    {
        public int Añada { get; set; }
        public Blob imagenEtiqueta { get; set; }
        public string Nombre { get; set; }
        public string NotaDeCataBodega { get; set; }
        public int PrecioARS { get; set; }

        public Vino() { }

        public Vino(int añada, Blob imagenEtiqueta, string nombre, string notaDeCataBodega, int precioARS)
        {
            Añada = añada;
            this.imagenEtiqueta = imagenEtiqueta;
            Nombre = nombre;
            NotaDeCataBodega = notaDeCataBodega;
            PrecioARS = precioARS;
        }
    }
}
