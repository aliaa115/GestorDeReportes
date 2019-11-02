using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatoRpt.Entity;
using CapaControlRpt.Control;

namespace CapaDisenoRpt.Mantenimiento
{
    public partial class Frm_PropiedadRptMdl : Form
    {
        PropiedadReporteControl propiedadControl = new PropiedadReporteControl();
        public Frm_PropiedadRptMdl()
        {
            InitializeComponent();
            llenarDgv();
        }

        private void llenarDgv()
        {
            int fila = 0;
            Dgv_Consulta.Rows.Clear();
            foreach (PropiedadReporte propiedadTmp in propiedadControl.obtenerAllPropiedad())
            {
                Dgv_Consulta.Rows.Add();
                Dgv_Consulta.Rows[fila].Cells[0].Value = propiedadTmp.REPORTE.REPORTE.ToString();
                Dgv_Consulta.Rows[fila].Cells[1].Value = propiedadTmp.USUARIO.USUARIO.ToString();
                Dgv_Consulta.Rows[fila].Cells[2].Value = propiedadTmp.APLICACION.NOMBRE;
                Dgv_Consulta.Rows[fila].Cells[3].Value = propiedadTmp.MODULO.MODULO;
                if (propiedadTmp.IMPRIMIR == 1) { Dgv_Consulta.Rows[fila].Cells[4].Value = true; }
                                        else    { Dgv_Consulta.Rows[fila].Cells[4].Value = false; }
                if (propiedadTmp.ESTADO == 1) { Dgv_Consulta.Rows[fila].Cells[5].Value = true; }
                                        else    { Dgv_Consulta.Rows[fila].Cells[5].Value = false; }
                fila++;
            }
        }
    }
}
