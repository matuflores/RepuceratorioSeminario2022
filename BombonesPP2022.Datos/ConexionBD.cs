using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BombonesPP2022.Datos
{
    public class ConexionBD
    {
        private readonly string cadenaConexion;
        private SqlConnection cn;

        public ConexionBD()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                cn = new SqlConnection(cadenaConexion);
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo establecer la conexión");
            }
        }

        public void CerrarConexion()
        {
            if (cn.State == ConnectionState.Open) //using .data
            {
                cn.Close();
            }
        }
    }
}
