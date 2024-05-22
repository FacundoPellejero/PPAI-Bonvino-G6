using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomVino_PPAI.Models.DTO
{
    internal class TipoUva
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }



        public TipoUva() { }

        public TipoUva(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
