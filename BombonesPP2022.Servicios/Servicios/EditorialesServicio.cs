using BombonesPP2022.Datos.Repositorios;
using BombonesPP2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombonesPP2022.Servicios.Servicios
{
    public class EditorialesServicio
    {
        private readonly EditorialesRepositorio repositorio;
        public EditorialesServicio()
        {
            repositorio = new EditorialesRepositorio();
        }

        public List<Editorial> GetLista()
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

        public int Agregar(Editorial editorial)
        {
            try
            {
                return repositorio.Agregar(editorial);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int Borrar(Editorial editorial)
        {
            try
            {
                return repositorio.Borrar(editorial);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Editar(Editorial editorial)
        {
            try
            {
                return repositorio.Editar(editorial);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool Existe(Editorial editorial)
        {
            try
            {
                return repositorio.Existe(editorial);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
