using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDisenoRpt.Mantenimiento
{
    public partial class Frm_Propiedades : Form
    {
        string usuario;
        public Frm_Propiedades()
        {
            InitializeComponent();
            inicializarNavegador();
        }

        private void inicializarNavegador()
        {
            //incializacion de navegador
            usuario = "admin";
            string[] alias = { "Reporte", "Usuario", "Aplicacion", "Modulo", "Desa que se imprima sin previsualizar?", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarComboConTabla("tbl_reporte", "nombre", 1);
            navegador1.asignarComboConTabla("tbl_usuario", "PK_id_usuario", 0);
            navegador1.asignarComboConTabla("tbl_aplicacion", "nombre_aplicacion", 1);
            navegador1.asignarComboConTabla("tbl_modulo", "nombre_modulo", 1);
            navegador1.asignarComboConLista(2, "si|no");
            navegador1.asignarTabla("Tbl_propiedad_Rpt");
            navegador1.asignarNombreForm("PROPIEDADES");
            navegador1.ObtenerIdAplicacion("1");
        }

        private void Navegador1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
