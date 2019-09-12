using System;
using System.Collections.Generic;
using capaDato.Conexion;
using capaDato.Entity;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControl.Control
{
    public class AplicacionControl
    {
        private Transaccion transaccion = new Transaccion();

        public List<Aplicacion> obtenerAllAplicacionByMdl(int modulo)
        {
            List<Aplicacion> aplicacionList = new List<Aplicacion>();
            ModuloControl moduloControl = new ModuloControl();

            try
            {
                String sComando = String.Format("SELECT PK_ID_APLICACION, PK_ID_MODULO, NOMBRE_APLICACION, " +
                    "DESCRIPCION_APLICACION, ESTADO_APLICACION " +
                    "FROM TBL_APLICACION " +
                    "WHERE PK_ID_MODULO = {0} " +
                    "AND ESTADO_APLICACION <> 0; ",
                    modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Aplicacion aplicacionTmp = new Aplicacion();
                        aplicacionTmp.APLICACION = int.Parse(reader.GetString(0));
                        aplicacionTmp.MODULO = moduloControl.obtenerModulo(int.Parse(reader.GetString(1)));
                        aplicacionTmp.NOMBRE = reader.GetString(2);
                        aplicacionTmp.DESCRIPCION = reader.GetString(3);
                        aplicacionTmp.ESTADO = int.Parse(reader.GetString(4));
                        aplicacionList.Add(aplicacionTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener lista de aplicacion.");
                return null;
            }

            return aplicacionList;
        }

        public Aplicacion obtenerAplicacion(int aplicacion, int modulo)
        {
            Aplicacion aplicacionTmp = new Aplicacion();
            ModuloControl moduloControl = new ModuloControl();

            try
            {
                String sComando = String.Format("SELECT PK_ID_APLICACION, PK_ID_MODULO, NOMBRE_APLICACION, " +
                    "DESCRIPCION_APLICACION, ESTADO_APLICACION " +
                    "FROM TBL_APLICACION " +
                    "WHERE PK_ID_MODULO = {0}" +
                    " AND PK_ID_APLICACION = {1} " +
                    " AND ESTADO_APLICACION <> 0; ",
                    modulo.ToString(), aplicacion.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        aplicacionTmp.APLICACION = int.Parse(reader.GetString(0));
                        aplicacionTmp.MODULO = moduloControl.obtenerModulo(int.Parse(reader.GetString(1)));
                        aplicacionTmp.NOMBRE = reader.GetString(2);
                        aplicacionTmp.DESCRIPCION = reader.GetString(3);
                        aplicacionTmp.ESTADO = int.Parse(reader.GetString(4));
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener lista de aplicacion.");
                return null;
            }

            return aplicacionTmp;
        }
    }
}
