using System;
using System.Windows.Forms;
using CapaDisenoRpt.Mantenimiento;

//Cristhian de Leon 0901 15 6167

namespace CapaDisenoRpt
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

      

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte frm_Reporte = new Frm_Reporte();
            frm_Reporte.Show();
        }

        private void Btn_RptApp_Click(object sender, EventArgs e)
        {
            Frm_RptApp frm_RptApp = new Frm_RptApp();
            frm_RptApp.Show();
        }

        private void Btn_RptMdl_Click(object sender, EventArgs e)
        {
            Frm_RptMdl frm_RptMdl = new Frm_RptMdl();
            frm_RptMdl.Show();
        }
    }
}
