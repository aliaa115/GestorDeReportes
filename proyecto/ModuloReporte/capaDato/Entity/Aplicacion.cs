using System;

namespace capaDatoRpt.Entity
{
    public class Aplicacion
    {
        public int APLICACION { get; set; }
        public Modulo MODULO { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public int ESTADO { get; set; }
    }
}
