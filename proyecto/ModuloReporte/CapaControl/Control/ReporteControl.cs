using System;
using System.Collections.Generic;
using capaDatoRpt.Conexion;
using capaDatoRpt.Entity;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControlRpt.Control
{
    public class ReporteControl
    {
        private Transaccion transaccion = new Transaccion();

        public void insertarReporte(Reporte reporte)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_REPORTE VALUES ({0}, {1}, '{2}', '{3}', {4}); ",
                    reporte.REPORTE.ToString(), reporte.CONFIGURACION.CONFIGURACION.ToString(), reporte.NOMBRE, reporte.NOMBRE_ARCHIVO,
                    reporte.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch(OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar reporte");
                throw new Exception("No se pudo insertar.");
            }
        }

        public void actualizarReporte(Reporte reporte)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_REPORTE " +
                    "SET PK_id_configuracion  = {1}, NOMBRE = '{2}', nombre_archivo = '{4}', ESTADO = {3}  " +
                    "WHERE PK_id_reporte  = {0}; ",
                    reporte.REPORTE.ToString(), reporte.CONFIGURACION.CONFIGURACION.ToString(), reporte.NOMBRE,
                    reporte.NOMBRE_ARCHIVO, reporte.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch(OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar reporte");
            }
        }

        public void eliminarReporte(int reporte)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_REPORTE " +
                    "SET ESTADO = 0 " +
                    "WHERE PK_id_reporte  = {0}; ",
                    reporte.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch(OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar reporte");
            }
        }
        
        public Reporte obtenerReporte(int reporte)
        {
            Reporte reporteTmp = new Reporte();
            ConfiguracionRptControl confiControl = new ConfiguracionRptControl();
            try
            {
                String sComando = String.Format("SELECT PK_id_reporte , PK_id_configuracion , NOMBRE, ESTADO, nombre_archivo " +
                    "FROM TBL_REPORTE " +
                    "WHERE PK_id_reporte  = {0} " +
                    " AND ESTADO <> 0; ",
                    reporte);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        reporteTmp.REPORTE = reader.GetInt32(0);
                        reporteTmp.CONFIGURACION = confiControl.obtenerConfiguracionRpt(reader.GetInt32(1));
                        reporteTmp.NOMBRE = reader.GetString(2);
                        reporteTmp.ESTADO = reader.GetInt32(3);
                        reporteTmp.NOMBRE_ARCHIVO = reader.GetString(4);
                    }
                }
            }
            catch(OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte");
                return null;
            }

            return reporteTmp;
        }

        public List<Reporte> obtenerAllReporte()
        {
            List<Reporte> reporteList = new List<Reporte>();
            ConfiguracionRptControl confiControl = new ConfiguracionRptControl();
            try
            {
                String sComando = String.Format("SELECT PK_id_reporte , PK_id_configuracion , NOMBRE, nombre_archivo, ESTADO " +
                    "FROM TBL_REPORTE " +
                    "WHERE ESTADO <> 0; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Reporte reporteTmp = new Reporte();
                        reporteTmp.REPORTE = reader.GetInt32(0);
                        reporteTmp.CONFIGURACION = confiControl.obtenerConfiguracionRpt(reader.GetInt32(1));
                        reporteTmp.NOMBRE = reader.GetString(2);
                        reporteTmp.ESTADO = reader.GetInt32(3);
                        reporteTmp.NOMBRE_ARCHIVO = reader.GetString(4);
                        reporteList.Add(reporteTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte");
                return null;
            }

            return reporteList;
        }

        public int obtenerUltimoId()
        {
            List<Reporte> reporteList = new List<Reporte>();
            ConfiguracionRptControl confiControl = new ConfiguracionRptControl();
            int rpt = 0;
            try
            {
                String sComando = String.Format("SELECT PK_id_reporte  FROM TBL_REPORTE; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rpt = reader.GetInt32(0);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte");
                return 0;
            }

            return rpt;
        }

    }
}
