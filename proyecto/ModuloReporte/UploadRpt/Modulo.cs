using System;
using System.Windows.Forms;
using CapaDisenoRpt.Procesos;

namespace UploadRpt
{
    public partial class Modulo : Form
    {
        ReportesModulo reportesModulo = new ReportesModulo(1); //Sustituir por el codigo de mdl actual.
        public Modulo()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            foreach(ToolStripMenuItem item in reportesModulo.crearItems())
            {
                Tool_Rpt.DropDownItems.Add(item);
            }
        }
    }
}
