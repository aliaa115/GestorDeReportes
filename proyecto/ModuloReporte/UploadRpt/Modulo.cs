using System;
using System.Windows.Forms;
using CapaDiseno.Procesos;

namespace UploadRpt
{
    public partial class Modulo : Form
    {
        ReportesModulo reportesModulo = new ReportesModulo(1);
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
