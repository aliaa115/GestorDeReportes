using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Printing;

//Cristhian de Leon 0901 15 6167

namespace CapaDisenoRpt.Procesos
{
    public partial class Frm_VistaReporte : Form
    {
        ReportDocument rptDoc = new ReportDocument();
        public Frm_VistaReporte()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Frm_VistaReporte(string filePath)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            generarRpt(filePath);
        }

        private void generarRpt(string filePath)
        {
            rptDoc = new ReportDocument();
            rptDoc.Load(filePath);
            Crv_Reporte.ReportSource = rptDoc;
            Crv_Reporte.ShowExportButton = false;
            Crv_Reporte.ShowCopyButton = false;
            Crv_Reporte.ShowParameterPanelButton = false;
            Crv_Reporte.Refresh();
        }

        private void imprimirRpt(string filePath)
        {
            rptDoc = new ReportDocument();
            rptDoc.Load(filePath);
            rptDoc.PrintToPrinter(1,false, 0, 0);
        }
    }
}   
