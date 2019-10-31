using System;
namespace capaDatoRpt.Entity
{
    public class PropiedadReporte
    {
        public Reporte REPORTE { get; set; }
        public Usuario USUARIO { get; set; }
        public Aplicacion APLICACION { get; set; }
        public Modulo MODULO { get; set; }
        public int IMPRIMIR { get; set; }
        public int ESTADO { get; set; }
    }
}
