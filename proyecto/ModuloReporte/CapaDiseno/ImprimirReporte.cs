using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControl.Control;
using capaDato.Entity;
using CapaDiseno.Dialogos;
using CapaDiseno.Procesos;

namespace CapaDiseno
{
    public class ImplrimirReporte
    {
        public ImplrimirReporte(int Codmodulo, int Codaplicacion)
        {

            ReporteAplicacionControl datos = new ReporteAplicacionControl();
            ReporteControl reporteControl = new ReporteControl();

            ReporteAplicacion repApp = datos.obtenerReporteApp(Codmodulo, Codaplicacion);
            Reporte rpt = repApp.REPORTE;

            string pathFile = rpt.CONFIGURACION.RUTA + rpt.FILENAME;
            Frm_VistaReporte frmVistaRpt = new Frm_VistaReporte(pathFile);
            frmVistaRpt.Show();

        }
    }
}
