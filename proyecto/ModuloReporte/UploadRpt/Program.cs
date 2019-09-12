using System;
using System.Windows.Forms;
using CapaDiseno;

namespace UploadRpt
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new UploadFile());
            //Application.Run(new Frm_ConfiguracionRpt());
            //Application.Run(new Frm_Reporte());
            //Application.Run(new Frm_RptApp());
            //Application.Run(new Frm_RptMdl());
            Application.Run(new Frm_Main());
        }
    }
}
