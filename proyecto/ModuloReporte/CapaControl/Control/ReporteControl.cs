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
                    reporte.REPORTE.ToString(), reporte.CONFIGURACION.CONFIGURACION.ToString(), reporte.NOMBRE, reporte.FILENAME,
                    reporte.ESTADO.ToString());
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
                    " NOMBRE = '{2}', FILENAME = '{4}', ESTADO = {3}  " +
                    "WHERE ID_REPORTE = {0}; ",
                    reporte.REPORTE.ToString(), reporte.NOMBRE, reporte.ESTADO.ToString(),
                    reporte.FILENAME);

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
                    "WHERE ID_REPORTE = {0}; ",
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
           
            try
            {
                String sComando = String.Format("SELECT ID_REPORTE,NOMBRE, ESTADO, FILENAME " +
                    "FROM TBL_REPORTE " +
                    "WHERE ID_REPORTE = {0}; ",
                    reporte);

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        reporteTmp.REPORTE = reader.GetInt32(0);
                       
                        reporteTmp.NOMBRE = reader.GetString(2);
                        reporteTmp.ESTADO = reader.GetInt32(3);
                        reporteTmp.FILENAME = reader.GetString(4);
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
          
            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_CONFIGURACION, NOMBRE, ESTADO, FILENAME " +
                    "FROM TBL_REPORTE; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Reporte reporteTmp = new Reporte();
                        reporteTmp.REPORTE = reader.GetInt32(0);
                        
                        reporteTmp.NOMBRE = reader.GetString(2);
                        reporteTmp.ESTADO = reader.GetInt32(3);
                        reporteTmp.FILENAME = reader.GetString(4);
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
            
            int rpt = 0;
            try
            {
                String sComando = String.Format("SELECT ID_REPORTE FROM TBL_REPORTE; ");

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
