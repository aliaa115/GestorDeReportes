using System;

namespace capaDatoRpt.Entity
{
    public class Reporte
    {
        public int REPORTE { get; set; }
        public ConfiguracionRpt CONFIGURACION { get; set; }
        public string NOMBRE { get; set; }
        public string NOMBRE_ARCHIVO { get; set; }
        public int ESTADO { get; set; }
    }
}
