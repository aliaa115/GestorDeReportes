using System;

namespace capaDatoRpt.Entity
{
    public class ReporteAplicacion
    {
        public Reporte REPORTE { get; set; }
        public Aplicacion APLICACION { get; set; }
        public Modulo MODULO { get; set; }
        public int ESTADO { get; set; }
    }
}
