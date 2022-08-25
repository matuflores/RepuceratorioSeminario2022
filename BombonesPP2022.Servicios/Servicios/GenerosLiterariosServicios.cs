using BombonesPP2022.Datos.Repositorios;
using BombonesPP2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombonesPP2022.Servicios.Servicios
{
    public class GenerosLiterariosServicios
    {
        private readonly GenerosLiterariosRepositorio repositorio;

        public GenerosLiterariosServicios()
        {
            repositorio = new GenerosLiterariosRepositorio();
        }

        public List<GeneroLiterario> GetLista()
        {
            try
            {
                return repositorio.GetLista();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
