using BombonesPP2022.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombonesPP2022.Datos.Repositorios
{
    public class AutoresRepositorio
    {
        private readonly ConexionBD conexionBd;

        public AutoresRepositorio()
        {
            conexionBd = new ConexionBD();
        }

        public List<Autor> GetLista()
        {
            List<Autor> lista = new List<Autor>();
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "SELECT AutorId, Apellido, Nombre, Nacionalidad, RowVersion FROM Autores";
                    var comando = new SqlCommand(cadenaComando, cn);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Autor autor = ConstruirAutor(reader);
                            lista.Add(autor);
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

        private Autor ConstruirAutor(SqlDataReader reader)
        {
            return new Autor()
            {//si no pongo los valores que pueden ser nulos como tales, no me aparecian los datos en grilla
                AutorId = reader.GetInt32(0),
                Apellido = reader.GetString(1),
                Nombre = reader[2] != DBNull.Value ? reader.GetString(2) : string.Empty,
                Nacionalidad = reader[3] != DBNull.Value ? reader.GetString(3) : string.Empty,
                RowVersion = (byte[])reader[4]

            };
        }
    }
}
