using System;
using System.Collections.Generic;
using capaDato.Conexion;
using capaDato.Entity;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControl.Control
{
    public class ReporteModuloControl
    {
        private Transaccion transaccion = new Transaccion();

        public void insertarReporteMdl(ReporteModulo reporteMdl)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_RPT_MDL VALUES ({0}, {1}, {2}); ",
                    reporteMdl.REPORTE.REPORTE.ToString(), reporteMdl.MODULO.MODULO.ToString(), reporteMdl.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al asociar reporte a modulo.");
            }
        }

        public void actualizarReporteMdl(ReporteModulo reporteMdl)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_RPT_MDL " +
                    "SET ID_REPORTE = {0}, ESTADO = {2} " +
                    "WHERE ID_MODULO = {1}; ",
                    reporteMdl.REPORTE.REPORTE.ToString(), reporteMdl.MODULO.MODULO.ToString(), reporteMdl.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar reporte modulo.");
            }
        }

        public void eliminarReporteMdl(int modulo)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_RPT_MDL " +
                    "SET ID_REPORTE = 0, ESTADO = 0 " +
                    "WHERE ID_MODULO = {0}; ",
                    modulo.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar reporte de modulo.");
            }
        }

        public ReporteModulo obtenerReporteMdl(int modulo, int reporte)
        {
            ReporteModulo reporteMdlTmp = new ReporteModulo();
            ModuloControl moduloControl = new ModuloControl();
            ReporteControl reporteControl = new ReporteControl();

            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_MODULO, ESTADO " +
                    "FROM TBL_RPT_MDL " +
                    "WHERE ID_MODULO = {0} " +
                    " AND ID_REPORTE = {1} " +
                    " AND ESTADO <> 0; ",
                    modulo.ToString(), reporte.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        reporteMdlTmp.REPORTE = reporteControl.obtenerReporte(reader.GetInt32(0));
                        reporteMdlTmp.MODULO = moduloControl.obtenerModulo(reader.GetInt32(1));
                        reporteMdlTmp.ESTADO = reader.GetInt32(2);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte modulo.");
                return null;
            }

            return reporteMdlTmp;
        }

        public List<ReporteModulo> obtenerAllReporteMdl()
        {
            List<ReporteModulo> reporteMdlList = new List<ReporteModulo>();
            ModuloControl moduloControl = new ModuloControl();
            ReporteControl reporteControl = new ReporteControl();

            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_MODULO, ESTADO " +
                    "FROM TBL_RPT_MDL " +
                    "WHERE ESTADO <> 0; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ReporteModulo reporteMdlTmp = new ReporteModulo();
                        reporteMdlTmp.REPORTE = reporteControl.obtenerReporte(reader.GetInt32(0));
                        reporteMdlTmp.MODULO = moduloControl.obtenerModulo(reader.GetInt32(1));
                        reporteMdlTmp.ESTADO = reader.GetInt32(2);
                        reporteMdlList.Add(reporteMdlTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte modulo.");
                return null;
            }

            return reporteMdlList;
        }
    }
}
