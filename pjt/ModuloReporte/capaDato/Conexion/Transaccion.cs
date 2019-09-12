using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace capaDato.Conexion
{
    public class Transaccion
    {
        Conexion conexion = new Conexion();

        public void insertarDatos(params string[] sSentencia)
        {
            
            var resultado = conexion.iniciarConexion();
            OdbcCommand comando = resultado.Item1.CreateCommand();
            OdbcTransaction transaccion = resultado.Item2;
            comando.Transaction = transaccion;

            try
            {
                foreach (string sentencia in sSentencia)
                {
                    comando.CommandText = sentencia;
                    comando.ExecuteNonQuery();
                }
            }
            catch (OdbcException ex)
            {
                transaccion.Rollback();
                MessageBox.Show(ex.Message, "Error en sentencia");
            }
        }
    }
}
