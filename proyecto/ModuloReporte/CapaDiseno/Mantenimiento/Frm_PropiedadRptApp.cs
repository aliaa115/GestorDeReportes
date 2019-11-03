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
    public partial class Frm_PropiedadRptApp : Form
    {
        int impresion = 0;
        int estado = 0;
        string usuario;
        int inicial = 0;
        PropiedadReporteControl propiedadControl = new PropiedadReporteControl();
        PropiedadReporte propiedadReporte = new PropiedadReporte();
        public Frm_PropiedadRptApp(string usr)
        {
            InitializeComponent();
            usuario = usr;
            llenarDgv();
            llenarTbpDato();
        }

        private void llenarDgv()
        {
            int fila = 0;
            Dgv_Consulta.Rows.Clear();
            foreach (PropiedadReporte propiedadTmp in propiedadControl.obtenerAllPropiedad())
            {
                Dgv_Consulta.Rows.Add();
                Dgv_Consulta.Rows[fila].Cells[0].Value = propiedadTmp.REPORTE.REPORTE.ToString();
                Dgv_Consulta.Rows[fila].Cells[1].Value = propiedadTmp.REPORTE.NOMBRE.ToString();
                Dgv_Consulta.Rows[fila].Cells[2].Value = propiedadTmp.USUARIO.USUARIO.ToString();
                Dgv_Consulta.Rows[fila].Cells[3].Value = propiedadTmp.APLICACION.APLICACION;
                Dgv_Consulta.Rows[fila].Cells[4].Value = propiedadTmp.APLICACION.NOMBRE;
                Dgv_Consulta.Rows[fila].Cells[5].Value = propiedadTmp.MODULO.MODULO;
                Dgv_Consulta.Rows[fila].Cells[6].Value = propiedadTmp.MODULO.NOMBRE;
                Dgv_Consulta.Rows[fila].Cells[7].Value = propiedadTmp.IMPRIMIR;
                Dgv_Consulta.Rows[fila].Cells[8].Value = propiedadTmp.ESTADO;
                fila++;
            }
        }

        private void inicializarImprimir()
        {
            Modulo mdlTmp = (Modulo)Cmb_Modulo.SelectedItem;
            Reporte rptTmp = (Reporte)Cmb_Reporte.SelectedItem;
            Aplicacion appTmp = (Aplicacion)Cmb_Aplicacion.SelectedItem;
            PropiedadReporteControl propiedadControl = new PropiedadReporteControl();
            PropiedadReporte propiedad =
                propiedadControl.obtenerPropiedadPorUsuarioAplicacion(
                    rptTmp.REPORTE, usuario, appTmp.APLICACION, mdlTmp.MODULO);

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

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            PropiedadReporte propiedad = new PropiedadReporte();
            PropiedadReporteControl propiedadControl = new PropiedadReporteControl();
            UsuarioControl usuario = new UsuarioControl();

            propiedad.MODULO = (Modulo)Cmb_Modulo.SelectedItem;
            propiedad.REPORTE = (Reporte)Cmb_Reporte.SelectedItem;
            propiedad.APLICACION = (Aplicacion)Cmb_Aplicacion.SelectedItem;
            propiedad.USUARIO = usuario.SetUsuario(this.usuario);
            propiedad.ESTADO = estado == 1 ? 1 : 0;
            propiedad.IMPRIMIR = impresion == 1 ? 1 : 0;

            propiedadControl.insertarPropiedadReporte(propiedad);

            MessageBox.Show("Se ha actualizado la propiedad");

            inicializarImprimir();
        }

        private void Cmb_Aplicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicial == 1)
            {
                inicializarImprimir();
            }
            inicial = 1;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            inicializarImprimir();
            Tbc_Reporte.SelectedTab = Tbp_Consulta;
            llenarDgv();
        }

        private void deshabilitarCampos()
        {
            Txt_Usuario.Enabled = false;
            Cmb_Aplicacion.Enabled = false;
            Cmb_Modulo.Enabled = false;
            Cmb_Reporte.Enabled = false;
            Chk_Estado.Enabled = false;
            Chk_Impresion.Enabled = false;
        }
        private void habilitarCampos()
        {
            Txt_Usuario.Enabled = false;
            Cmb_Aplicacion.Enabled = true;
            Cmb_Modulo.Enabled = true;
            Cmb_Reporte.Enabled = true;
            Chk_Estado.Enabled = true;
            Chk_Impresion.Enabled = true;
        }

        private void llenarTbpDato()
        {
            Txt_Usuario.Text = this.usuario;
            inicializarComboModulo();
            Modulo mdlTmp = (Modulo)Cmb_Modulo.SelectedItem;
            inicializarComboAplicacion(mdlTmp.MODULO);
            inicializarComboReporte();
            inicializarImprimir();

        }

        private void Dgv_Consulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Dgv_Consulta.CurrentCell.RowIndex;

            string reporte = Dgv_Consulta.Rows[fila].Cells[0].Value.ToString();
            string aplicacion = Dgv_Consulta.Rows[fila].Cells[3].Value.ToString();
            string modulo = Dgv_Consulta.Rows[fila].Cells[5].Value.ToString();

            int mdl = int.Parse(modulo);
            int app = int.Parse(aplicacion);
            int rpt = int.Parse(reporte);

            Frm_PropiedadesApp propiedades = new Frm_PropiedadesApp(usuario,mdl,app, rpt);
            propiedades.Show();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            Tbc_Reporte.SelectedTab = Tbp_Datos;
        }

        private void Dgv_Consulta_CellDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
