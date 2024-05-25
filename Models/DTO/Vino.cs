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
        public Blob ImagenEtiqueta { get; set; }
        public string Nombre { get; set; }
        public string NotaDeCataBodega { get; set; }
        public double PrecioARS { get; set; }
        public Bodega Bodega { get; set; }
        public List<Varietal> Varietales { get; set; }
        public List<Maridaje> Maridaje { get; set; }


        public Vino() { }

        public Vino(int añada, Blob imagenEtiqueta, string nombre, string notaDeCataBodega, double precioARS, Bodega bodega, List<Varietal> varietales)
        {
            Añada = añada;
            ImagenEtiqueta = imagenEtiqueta;
            Nombre = nombre;
            NotaDeCataBodega = notaDeCataBodega;
            PrecioARS = precioARS;
            Bodega = bodega;
            Varietales = varietales;
        }

        public Vino(int añada, Blob imagenEtiqueta, string nombre, string notaDeCataBodega, double precioARS, Bodega bodega, List<Varietal> varietales, List<Maridaje> maridaje) : this(añada, imagenEtiqueta, nombre, notaDeCataBodega, precioARS, bodega, varietales)
        {
            Añada = añada;
            ImagenEtiqueta = imagenEtiqueta;
            Nombre = nombre;
            NotaDeCataBodega = notaDeCataBodega;
            PrecioARS = precioARS;
            Bodega = bodega;
            Varietales = varietales;
            Maridaje = maridaje;
        }
    }
}
