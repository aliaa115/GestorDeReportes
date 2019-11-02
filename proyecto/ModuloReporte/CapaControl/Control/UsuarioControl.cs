using System;
using System.Collections.Generic;
using capaDatoRpt.Conexion;
using capaDatoRpt.Entity;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControlRpt.Control
{
    public class UsuarioControl
    {
        private Transaccion transaccion = new Transaccion();

        public Usuario SetUsuario(string usuario)
        {
            Usuario usu = new Usuario();
            usu.USUARIO = usuario;
            return usu;
        }

    }
}
