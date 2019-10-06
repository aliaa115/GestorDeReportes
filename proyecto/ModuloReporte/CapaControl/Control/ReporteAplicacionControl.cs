using System;
using System.Collections.Generic;
using capaDatoRpt.Conexion;
using capaDatoRpt.Entity;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControlRpt.Control
{
    public class ReporteAplicacionControl
    {
        private Transaccion transaccion = new Transaccion();
        private ReporteControl rep = new ReporteControl();
        private AplicacionControl app = new AplicacionControl();
        private ModuloControl mod = new ModuloControl();

        public void insertarReporteApp(ReporteAplicacion reporteApp)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_RPT_APP VALUES ({0}, {1}, {2}, {3}); ",
                    reporteApp.REPORTE.REPORTE.ToString(), reporteApp.APLICACION.APLICACION.ToString(), 
                    reporteApp.MODULO.MODULO.ToString(), reporteApp.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al asociar reporte a aplicacion.");
            }
        }

        public void actualizarReporteApp(ReporteAplicacion reporteApp)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_RPT_APP " +
                    "SET ID_REPORTE = {0}, ESTADO = {3} " +
                    "WHERE ID_APLICACION = {1} " +
                    " AND ID_MODULO = {2}; ",
                    reporteApp.REPORTE.REPORTE.ToString(), reporteApp.APLICACION.APLICACION.ToString(),
                    reporteApp.MODULO.MODULO.ToString(), reporteApp.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar reporte aplicacion.");
            }
        }

        public void eliminarReporteApp(int app, int modulo)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_RPT_APP " +
                    "SET ID_REPORTE = 0, ESTADO = 0 " +
                    "WHERE ID_APLICACION = {0} " +
                    " AND ID_MODULO = {1}; ",
                    app.ToString(), modulo.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar reporte de aplicacion.");
            }
        }

        public ReporteAplicacion obtenerReporteApp(int app, int modulo)
        {
            ReporteAplicacion reporteAppTmp = new ReporteAplicacion();
            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_APLICACION, ID_MODULO, ESTADO " +
                    "FROM TBL_RPT_APP " +
                    "WHERE ID_APLICACION = {0} " +
                    " AND ID_MODULO = {1}" +
                    " AND ESTADO <> 0; ",
                    app.ToString(), modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        reporteAppTmp.REPORTE = rep.obtenerReporte(reader.GetInt32(0));
                        reporteAppTmp.APLICACION = this.app.obtenerAplicacion( reader.GetInt32(1), reader.GetInt32(2));
                        reporteAppTmp.MODULO = mod.obtenerModulo(reader.GetInt32(2));
                        reporteAppTmp.ESTADO = reader.GetInt32(3);
                    }
                }
            }
            catch (OdbcException ex)
            {
                throw new Exception("No se obtuvieron registros." + ex.ToString());
            }

            return reporteAppTmp;
        }

        public List<ReporteAplicacion> obtenerAllReporteAppByMdl(int modulo)
        {
            List<ReporteAplicacion> reporteAppList = new List<ReporteAplicacion>();
            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_APLICACION, ID_MODULO, ESTADO " +
                    "FROM TBL_RPT_APP" +
                    "WHERE ID_MODULO = {0} " +
                    " AND ESTADO <> 0; ",
                    modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ReporteAplicacion reporteAppTmp = new ReporteAplicacion();
                        reporteAppTmp.REPORTE.REPORTE = reader.GetInt32(0);
                        reporteAppTmp.APLICACION.APLICACION = reader.GetInt32(1);
                        reporteAppTmp.MODULO.MODULO = reader.GetInt32(2);
                        reporteAppTmp.ESTADO = reader.GetInt32(3);
                        reporteAppList.Add(reporteAppTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte aplicacion.");
                return null;
            }

            return reporteAppList;
        }
        public List<ReporteAplicacion> obtenerAllReporteApp()
        {
            List<ReporteAplicacion> reporteAppList = new List<ReporteAplicacion>();
            ReporteControl reporteControl = new ReporteControl();
            ModuloControl moduloControl = new ModuloControl();
            AplicacionControl aplicacionControl = new AplicacionControl();

            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_APLICACION, ID_MODULO, ESTADO " +
                    "FROM TBL_RPT_APP " +
                    "WHERE ESTADO <> 0; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ReporteAplicacion reporteAppTmp = new ReporteAplicacion();
                        reporteAppTmp.REPORTE = reporteControl.obtenerReporte(reader.GetInt32(0));
                        reporteAppTmp.MODULO = moduloControl.obtenerModulo(reader.GetInt32(2));
                        reporteAppTmp.APLICACION = aplicacionControl.obtenerAplicacion(reader.GetInt32(1),
                            reporteAppTmp.MODULO.MODULO);
                        reporteAppTmp.ESTADO = int.Parse(reader.GetString(3));
                        reporteAppList.Add(reporteAppTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte aplicacion.");
                return null;
            }

            return reporteAppList;
        }

    }
}
