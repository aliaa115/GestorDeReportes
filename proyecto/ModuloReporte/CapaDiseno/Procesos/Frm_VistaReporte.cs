using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;

namespace CapaDiseno.Procesos
{
    public partial class Frm_VistaReporte : Form
    {
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
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(filePath);
            Crv_Reporte.ReportSource = rptDoc;
            Crv_Reporte.Refresh();
        }
    }
}
