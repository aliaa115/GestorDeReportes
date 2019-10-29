using System;
using System.Collections.Generic;
using CapaControlRpt.Control;
using capaDatoRpt.Entity;
using CapaDisenoRpt.Dialogos;
using CapaDisenoRpt.Procesos;

namespace CapaDisenoRpt
{
    public class ImprimirReporte
    {
        public void imprimirReporteAplicacion(int Codmodulo, int Codaplicacion)
        {

            ReporteAplicacionControl datos = new ReporteAplicacionControl();

            ReporteAplicacion repApp = datos.obtenerReporteApp(Codaplicacion, Codmodulo);
            Reporte rpt = repApp.REPORTE;

            string pathFile = rpt.CONFIGURACION.RUTA + rpt.NOMBRE_ARCHIVO;
            Frm_VistaReporte frmVistaRpt = new Frm_VistaReporte(pathFile, 0);
            frmVistaRpt.Show();

        }

        public void imprimirReporteModulo(int codModulo, int codReporte)
        {
            ReporteModuloControl reporteMdlControl = new ReporteModuloControl();

            try
            {
                ReporteModulo reporteMdl = reporteMdlControl.obtenerReporteMdl(codModulo, codReporte);
                Reporte rpt = reporteMdl.REPORTE;

                string pathFile = rpt.CONFIGURACION.RUTA + rpt.NOMBRE_ARCHIVO;
                Frm_VistaReporte frmVistaRpt = new Frm_VistaReporte(pathFile, 0);
                frmVistaRpt.Show();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString() + "Error en impresion, no se pudo obtener reporte.");
            }
        }
    }
}
