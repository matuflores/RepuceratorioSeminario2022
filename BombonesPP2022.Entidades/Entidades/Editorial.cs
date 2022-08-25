using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombonesPP2022.Entidades.Entidades
{
    public class Editorial:ICloneable
    {
        public int EditorialId { get; set; }
        public string NombreEditorial { get; set; }
        public byte[] RowVersion { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
