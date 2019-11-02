using System;
using System.Windows.Forms;
using System.Collections.Generic;
using capaDatoRpt.Entity;
using CapaControlRpt.Control;
using CapaDisenoRpt.Dialogos;
using CapaDisenoRpt.Procesos;
using System.Windows.Forms;
using System.Drawing;

namespace CapaDisenoRpt.Mantenimiento
{
    public partial class Frm_Propiedades : Form
    {
        int impresion = 0;
        int estado = 0;
        string usuario;
        public Frm_Propiedades(string usr)
        {
            InitializeComponent();
            usuario = usr;
            Txt_Usuario.Text = usr;
            inicializarComboModulo();
            Modulo mdlTmp = (Modulo)Cmb_Modulo.SelectedItem;
            inicializarComboAplicacion(mdlTmp.MODULO);
            inicializarComboReporte();
            inicializarImprimir();
        }

        private void inicializarImprimir()
        {
            Modulo mdlTmp = (Modulo)Cmb_Modulo.SelectedItem;
            Reporte rptTmp = (Reporte)Cmb_Reporte.SelectedItem;
            Aplicacion appTmp = (Aplicacion)Cmb_Aplicacion.SelectedItem;
            PropiedadReporteControl propiedadControl = new PropiedadReporteControl();
            PropiedadReporte propiedad = 
                propiedadControl.obtenerPropiedadPorUsuarioAplicacion(
                    rptTmp.REPORTE,usuario,appTmp.APLICACION,mdlTmp.MODULO);

            estado = propiedad.ESTADO == 1 ? 1 : 0;
            colorCheck(estado, Chk_Estado);
            impresion = propiedad.IMPRIMIR == 1 ? 1 : 0;
            colorCheck(impresion, Chk_Impresion);
        }

        private void inicializarComboReporte()
        {
            ReporteControl reporteControl = new ReporteControl();
            List<Reporte> reporteList = reporteControl.obtenerAllReporte();

            Cmb_Reporte.ValueMember = "REPORTE";
            Cmb_Reporte.DisplayMember = "NOMBRE";
            Cmb_Reporte.DataSource = reporteList;

        }

        public void inicializarComboModulo()
        {
            ModuloControl moduloControl = new ModuloControl();
            List<Modulo> moduloList = moduloControl.obtenerAllModulo();

            Cmb_Modulo.ValueMember = "MODULO";
            Cmb_Modulo.DisplayMember = "NOMBRE";
            Cmb_Modulo.DataSource = moduloList;
        }

        private void inicializarComboAplicacion(int mdl)
        {
            Modulo mdlTmp = (Modulo)Cmb_Modulo.SelectedItem;
            AplicacionControl aplicacionControl = new AplicacionControl();
            List<Aplicacion> aplicacionList = aplicacionControl.obtenerAllAplicacionByMdl(mdl);

            Cmb_Aplicacion.ValueMember = "APLICACION";
            Cmb_Aplicacion.DisplayMember = "NOMBRE";
            Cmb_Aplicacion.DataSource = aplicacionList;

        }

        private void Cmb_Modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modulo mdlTmp = (Modulo)Cmb_Modulo.SelectedItem;
            inicializarComboAplicacion(mdlTmp.MODULO);
        }

        private void Chk_Impresion_CheckedChanged(object sender, EventArgs e)
        {
            impresion = impresion == 1 ? 0 : 1;
            colorCheck(impresion, Chk_Impresion);
        }

        private void Chk_Estado_CheckedChanged(object sender, EventArgs e)
        {
            estado = estado == 1 ? 0 : 1;
            colorCheck(estado, Chk_Estado);
        }

        private void colorCheck(int indicador, CheckBox checkBox)
        {
            switch (indicador)
            {
                case 0:
                    checkBox.Text = "X";
                    checkBox.TextAlign = ContentAlignment.MiddleCenter;
                    checkBox.BackColor = Color.LightSalmon;
                    break;
                case 1:
                    checkBox.Text = "√";
                    checkBox.TextAlign = ContentAlignment.MiddleCenter;
                    checkBox.BackColor = Color.LightGreen;
                    break;
                default:
                    break;
            }
        }

        private void Cmb_Reporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            inicializarImprimir();
        }
    }
}
