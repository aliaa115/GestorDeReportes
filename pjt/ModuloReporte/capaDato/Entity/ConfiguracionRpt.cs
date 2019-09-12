using System;

namespace capaDato.Entity
{
    public class ConfiguracionRpt
    {
        public int ID_CONFIGURACION { get; set; }
        public String NOMBRE { get; set; }
        public String USER { get; set; }
        public String PASSWORD { get; set; }
        public String PUERTO { get; set; }
        public String RUTA { get; set; }
        public int ESTADO { get; set; }
    }
}
