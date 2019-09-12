using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDato.Conexion;
using capaDato.Entity;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControl
{
    public class ReporteControl
    {
        private Transaccion transaccion = new Transaccion();

        public void insertarReporte(Reporte reporte)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_REPORTE VALUES ({0}, {1}, '{2}', {3}); ",
                    reporte.ID_REPORTE.ToString(), reporte.ID_CONFIGURACION.ToString(), reporte.NOMBRE, reporte.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch(OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar reporte");
            }
        }

        public void actualizarReporte(Reporte reporte)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_REPORTE " +
                    "SET ID_CONFIGURACION = {1}, NOMBRE = '{2}', ESTADO = {3} " +
                    "WHERE ID_REPORTE = {0};",
                    reporte.ID_REPORTE.ToString(), reporte.ID_CONFIGURACION.ToString(), reporte.NOMBRE, reporte.ESTADO.ToString());

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
        /*
        public Reporte obtenerReporte(int reporte)
        {
            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_CONFIGURACION, NOMBRE, ESTADO " +
                    "FROM TBL_REPORTE " +
                    "WHERE ID_REPORTE = {0}",
                    reporte.ToString());

                OdbcDataReader reader = transaccion.
            }
            catch(OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte");
            }
        }
        */
    }
}
