using System;

namespace capaDato.Entity
{
    public class Reporte
    {
        public int REPORTE { get; set; }
        public ConfiguracionRpt CONFIGURACION { get; set; }
        public string NOMBRE { get; set; }
        public string FILENAME { get; set; }
        public int ESTADO { get; set; }
    }
}
