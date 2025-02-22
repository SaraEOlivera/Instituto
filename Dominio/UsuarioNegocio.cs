using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Dominio
{
    public class UsuarioNegocio
    {
        private Usuarios usuarioDatos = new Usuarios();

        public DataTable loginUsuario(string usuario, string clave) 
        {
            return usuarioDatos.LoginUsuario(usuario, clave);
        }
    }
}
