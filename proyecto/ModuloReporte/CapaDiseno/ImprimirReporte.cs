using CapaControlRpt.Control;
using capaDatoRpt.Entity;
using CapaDisenoRpt.Procesos;
using System;

namespace CapaDisenoRpt
{
    public class ImprimirReporte
    {
        public string sIdUsuario;

        public ImprimirReporte(string sIdUsuario)
        {
            this.sIdUsuario = sIdUsuario;
        }

        public void imprimirReporteAplicacion(int Reporte, string usuario, int Modulo, int Aplicacion)
        {
            PropiedadReporteControl propiedadReporteControl = new PropiedadReporteControl();
            PropiedadReporte propiedadReporte =
                propiedadReporteControl.obtenerPropiedadPorUsuarioAplicacion(Reporte, usuario, Aplicacion, Modulo);

            ReporteAplicacionControl datos = new ReporteAplicacionControl();

            ReporteAplicacion repApp = datos.obtenerReporteApp(Aplicacion, Modulo);
            Reporte rpt = repApp.REPORTE;

            string pathFile = rpt.CONFIGURACION.RUTA + rpt.NOMBRE_ARCHIVO;
            Frm_VistaReporte frmVistaRpt;
            switch (propiedadReporte.IMPRIMIR)
            {
                case 0:
                    frmVistaRpt = new Frm_VistaReporte(pathFile, 0);
                    frmVistaRpt.Show();
                    break;
                case 1:
                    frmVistaRpt = new Frm_VistaReporte(pathFile, 1);
                    frmVistaRpt.Show();
                    break;
                default:
                    break;
            }


        }

        public void imprimirReporteModulo(int Reporte, string usuario, int Modulo)
        {
            PropiedadReporteControl propiedadReporteControl = new PropiedadReporteControl();
            PropiedadReporte propiedadReporte =
                propiedadReporteControl.obtenerPropiedadPorUsuarioModulo(Reporte, usuario, Modulo);

            ReporteModuloControl reporteMdlControl = new ReporteModuloControl();

            try
            {
                ReporteModulo reporteMdl = reporteMdlControl.obtenerReporteMdl(Modulo, Reporte);
                Reporte rpt = reporteMdl.REPORTE;

                string pathFile = rpt.CONFIGURACION.RUTA + rpt.NOMBRE_ARCHIVO;
                Frm_VistaReporte frmVistaRpt;
                switch (propiedadReporte.IMPRIMIR)
                {
                    case 0:
                        frmVistaRpt = new Frm_VistaReporte(pathFile, 0);
                        frmVistaRpt.Show();
                        break;
                    case 1:
                        frmVistaRpt = new Frm_VistaReporte(pathFile, 1);
                        //frmVistaRpt.Show();
                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString() + "Error en impresion, no se pudo obtener reporte.");
            }
        }
    }
}
