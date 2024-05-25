using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BomVino_PPAI.Models.DTO
{
    internal class Enofilo
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Blob ImagenPerfil { get; set; }
        public List<Siguiendo> Seguido { get; set; }
        public Usuario Usuario { get; set; }
        public List<Vino> Favorito { get; set; }

        public Enofilo(string nombre, string apellido, Blob imagenPerfil, Usuario usuario)
        {
            Nombre = nombre;
            Apellido = apellido;
            ImagenPerfil = imagenPerfil;
            Usuario = usuario;
            Seguido = new List<Siguiendo>();
        }

        public Enofilo(string nombre, string apellido, Blob imagenPerfil, List<Siguiendo> seguido, Usuario usuario, List<Vino> favorito)
        {
            Nombre = nombre;
            Apellido = apellido;
            ImagenPerfil = imagenPerfil;
            Seguido = seguido;
            Usuario = usuario;
            Favorito = favorito;
        }

        public Enofilo() { }
    }
}
