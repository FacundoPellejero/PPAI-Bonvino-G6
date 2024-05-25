using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomVino_PPAI.Models.DTO
{
    internal class Usuario
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public bool Premium { get; set; }

        public Usuario() { }

        public Usuario(string nombre, string contraseña, bool premium)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            Premium = premium;
        }
    }
}
