using System;
using System;
using System.Collections.Generic;
using capaDatoRpt.Conexion;
using capaDatoRpt.Entity;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControlRpt.Control
{
    public class ConfiguracionRptControl
    {
        private Transaccion transaccion = new Transaccion();
        public void insertarConfiguracionRpt(ConfiguracionRpt configuracionRpt)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_CONFIGURACION_RPT VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', {6}); ",
                    configuracionRpt.CONFIGURACION.ToString(), configuracionRpt.NOMBRE, configuracionRpt.USER, configuracionRpt.PASSWORD,
                    configuracionRpt.PUERTO, configuracionRpt.RUTA, configuracionRpt.ESTADO.ToString());
                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar configuracion para reporte.");
            }
        }

        public void actualizarConfiguracionRpt(ConfiguracionRpt configuracionRpt)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_CONFIGURACION_RPT " +
                    "SET NOMBRE = '{1}', USER = '{2}', PASSWORD = '{3}', PUERTO = '{4}', RUTA = '{5}', ESTADO = {6} " +
                    "WHERE PK_id_configuracion  = {0}; ",
                    configuracionRpt.CONFIGURACION.ToString(), configuracionRpt.NOMBRE, configuracionRpt.USER, configuracionRpt.PASSWORD,
                    configuracionRpt.PUERTO, configuracionRpt.RUTA, configuracionRpt.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar configuracion para reporte.");
            }
        }

        public void eliminarConfiguracionRpt(int configuracionRpt)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_CONFIGURACION_RPT " +
                    "SET ESTADO = 0 " +
                    "WHERE PK_id_configuracion  = {0}; ",
                    configuracionRpt.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar configuracion para reporte.");
            }
        }

        public ConfiguracionRpt obtenerConfiguracionRpt(int configuracionRpt)
        {
            ConfiguracionRpt configuracionRptTmp = new ConfiguracionRpt();
            try
            {
                String sComando = String.Format("SELECT PK_id_configuracion , NOMBRE, USER, PASSWORD, PUERTO, RUTA, ESTADO " +
                    "FROM TBL_CONFIGURACION_RPT " +
                    "WHERE PK_id_configuracion  = {0} " +
                    "AND ESTADO <> 0; ",
                    configuracionRpt.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        configuracionRptTmp.CONFIGURACION = reader.GetInt32(0);
                        configuracionRptTmp.NOMBRE = reader.GetString(1);
                        configuracionRptTmp.USER = reader.GetString(2);
                        configuracionRptTmp.PASSWORD = reader.GetString(3);
                        configuracionRptTmp.PUERTO = reader.GetString(4);
                        configuracionRptTmp.RUTA = reader.GetString(5);
                        configuracionRptTmp.ESTADO = reader.GetInt32(6);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte");
                return null;
            }

            return configuracionRptTmp;
        }

        public List<ConfiguracionRpt> obtenerAllConfiguracionRpt()
        {
            List<ConfiguracionRpt> configuracionRptList = new List<ConfiguracionRpt>();
            try
            {
                String sComando = String.Format("SELECT PK_id_configuracion , NOMBRE, USER, PASSWORD, PUERTO, RUTA, ESTADO " +
                    "FROM TBL_CONFIGURACION_RPT " +
                    "WHERE ESTADO <> 0; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ConfiguracionRpt configuracionRptTmp = new ConfiguracionRpt();
                        configuracionRptTmp.CONFIGURACION = reader.GetInt32(0);
                        configuracionRptTmp.NOMBRE = reader.GetString(1);
                        configuracionRptTmp.USER = reader.GetString(2);
                        configuracionRptTmp.PASSWORD = reader.GetString(3);
                        configuracionRptTmp.PUERTO = reader.GetString(4);
                        configuracionRptTmp.RUTA = reader.GetString(5);
                        configuracionRptTmp.ESTADO = reader.GetInt32(6);
                        configuracionRptList.Add(configuracionRptTmp);
                    }
                }
                //else
                //{
                //    reader.Close();
                //    throw new Exception("No se recupero ningun registro de configuracion carpeta.");
                //}

                reader.Close();
                return configuracionRptList;
            }
            catch (OdbcException ex)
            {
                throw new Exception("Error de conexion a base de datos. /n" + ex.ToString());
            }
        }
    }
}
