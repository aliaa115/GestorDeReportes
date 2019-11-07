using System;
using System.Windows.Forms;

namespace CapaDisenoRpt
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
            //Application.Run(new Form1());
            Application.Run(new Mantenimiento.Frm_Reporte("Cristhian"));
            
        }
    }
}
