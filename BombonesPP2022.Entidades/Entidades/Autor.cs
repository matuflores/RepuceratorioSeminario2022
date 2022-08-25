using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombonesPP2022.Entidades.Entidades
{
    public class Autor:ICloneable
    {
        public int AutorId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public byte[] RowVersion { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
