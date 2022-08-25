using BombonesPP2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombonesPP2022.Datos.Repositorios
{
    public class GenerosLiterariosRepositorio
    {
        private readonly ConexionBD conexionBd;

        public GenerosLiterariosRepositorio()
        {
            conexionBd = new ConexionBD();
        }

        public List<GeneroLiterario> GetLista()
        {
            List<GeneroLiterario> lista = new List<GeneroLiterario>();
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "SELECT GeneroLiterarioId, Descripcion, RowVersion FROM GenerosLiterarios";
                    var comando = new SqlCommand(cadenaComando, cn);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GeneroLiterario genero = ConstruirGenero(reader);
                            lista.Add(genero);
                        }
                    }
                }

                return lista;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        private GeneroLiterario ConstruirGenero(SqlDataReader reader)
        {
            return new GeneroLiterario()
            {
                GeneroLiterarioId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                RowVersion = (byte[])reader[2]

            };
        }

        
    }
}
