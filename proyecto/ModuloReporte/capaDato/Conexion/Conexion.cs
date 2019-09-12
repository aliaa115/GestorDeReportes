using System;
using System.Data.Odbc;

namespace capaDato.Conexion
{
    public class Conexion
    {
        OdbcConnection conexion;

        public Tuple<OdbcConnection, OdbcTransaction> iniciarConexion()
        {
            conexion = new OdbcConnection("Dsn=moduloseguridad");
            conexion.Open();

            OdbcTransaction transaccion = conexion.BeginTransaction();

            return Tuple.Create(conexion, transaccion);
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
