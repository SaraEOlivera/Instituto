using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion con = null;

        private Conexion() 
        {
            this.baseDatos = "Instituto_DB";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "OliSQL2024";
        }

        public SqlConnection crearConexion() 
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = $"Server =   { this.servidor};  Database = {this.baseDatos}; User Id = {this.usuario} ; Password = {this.clave};";

            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia() 
        {
            if (con == null) 
            {
                con = new Conexion();
            }
            return con;
        }

    }
}
