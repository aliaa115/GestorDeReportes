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

namespace UploadRpt
{
    public partial class Frm_Bitacora : Form
    {
        ImprimirReporte imprimir = new ImprimirReporte();
        public Frm_Bitacora()
        {
            InitializeComponent();
        }

        private void Btn_ImpRpt_Click(object sender, EventArgs e)
        {
            imprimir.imprimirReporteAplicacion(2, 1);
        }
    }
}
