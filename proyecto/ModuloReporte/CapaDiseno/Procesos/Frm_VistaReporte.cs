using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace CapaDiseno.Procesos
{
    public partial class Frm_VistaReporte : Form
    {
        ReportDocument rptDoc = new ReportDocument();
        public Frm_VistaReporte()
        {
            InitializeComponent();
        }

        public Frm_VistaReporte(string filePath)
        {
            InitializeComponent();
            generarRpt(filePath);   
        }

        private void generarRpt(string filePath)
        {
            rptDoc = new ReportDocument();
            rptDoc.Load(filePath);
            Crv_Reporte.ReportSource = rptDoc;
            Crv_Reporte.Refresh();
        }

        private void Btn_Almacenar_Click(object sender, EventArgs e)
        {
            rptDoc = new ReportDocument();
            DiskFileDestinationOptions dest = new DiskFileDestinationOptions();
            rptDoc.FileName = "pruebas";
            dest.DiskFileName = @"C:\tmp\pruebas.pdf";

            PdfFormatOptions formatOpt = new PdfFormatOptions();
            formatOpt.FirstPageNumber = 0;
            formatOpt.LastPageNumber = 10;
            formatOpt.UsePageRange = false;
            formatOpt.CreateBookmarksFromGroupTree = false;
            formatOpt.PrintOnLoad = false;

            ExportOptions ex = new ExportOptions();
            ex.ExportDestinationType = ExportDestinationType.DiskFile;
            ex.ExportDestinationOptions = dest;
            ex.ExportFormatType = ExportFormatType.PortableDocFormat;
            ex.ExportFormatOptions = formatOpt;
            //rptDoc.Export(ex);
            //rptDoc.ExportToDisk(ExportFormatType.PortableDocFormat, @"D:\tmp\reportes\prueba.pdf");
            MessageBox.Show("Exported");
        }
    }
}   
