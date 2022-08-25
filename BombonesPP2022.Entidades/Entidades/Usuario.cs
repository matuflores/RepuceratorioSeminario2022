using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombonesPP2022.Entidades.Entidades
{
    public class Usuario
    {
        public int SocioId { get; set; }

        public int DNI { get; set; }

        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }

        public int CodPostal { get; set; }

        public string Telefono { get; set; }

        public DateTime FechaNac { get; set; }

        public byte Sancionado { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
