using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomVino_PPAI.Models.DTO
{
    internal class Maridaje
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Maridaje() { }

        public Maridaje(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
