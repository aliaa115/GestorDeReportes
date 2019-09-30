using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDisenoRpt.Mantenimiento;
using CapaDisenoRpt;

namespace CapaDisenoRpt
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Btn_Configuracion_Click(object sender, EventArgs e)
        {
            Frm_ConfiguracionRpt frm_ConfiguracionRpt = new Frm_ConfiguracionRpt();
            frm_ConfiguracionRpt.Show();
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
