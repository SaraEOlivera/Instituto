using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Usuarios
    {
        public DataTable LoginUsuario(string L_Usu, string P_Usu) 
        {
            SqlDataReader lector;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.getInstancia().crearConexion();

                SqlCommand comando = new SqlCommand("IngresoLogin", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Usu", SqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("@Pass", SqlDbType.VarChar).Value = P_Usu;

                conexion.Open();
                lector = comando.ExecuteReader();
                tabla.Load(lector);

                return tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                if(conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
    }
}
