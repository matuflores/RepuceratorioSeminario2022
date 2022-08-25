using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombonesPP2022.Entidades.Entidades
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public Autor AutorId { get; set; }
        public GeneroLiterario GeneroLiterario { get; set; }
        public Idioma Idioma { get; set; }

        public Editorial Editorial { get; set; }
        public double Precio { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
