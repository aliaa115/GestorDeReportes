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
        ImprimirReporte imprimir = new ImprimirReporte("idusuario");
       // logica l = new logica("idusuario")
        public Frm_Bitacora()
        {
            InitializeComponent();
        }

        private void Btn_ImpRpt_Click(object sender, EventArgs e)
        {
            imprimir.imprimirReporteAplicacion(1,"admin",2, 1);
        }
    }
}
