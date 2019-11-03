using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDisenoRpt;
using CapaDatos;
//using CapaLogica;

namespace UploadRpt
{
    public partial class Frm_Bitacora : Form
    {
        string usuario;
        public Frm_Bitacora(string usr)
        {
            InitializeComponent();
            usuario = usr;
        }

        private void Btn_ImpRpt_Click(object sender, EventArgs e)
        {
            ImprimirReporte imprimir = new ImprimirReporte(usuario);
            imprimir.imprimirReporteAplicacion(usuario,1, 1);
        }
    }
}
