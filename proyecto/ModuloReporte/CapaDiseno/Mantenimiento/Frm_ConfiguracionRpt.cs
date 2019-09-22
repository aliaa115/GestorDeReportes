using System;
using System.Windows.Forms;
using capaDato.Entity;
using CapaControl.Control;
using CapaDiseno.Dialogos;

namespace CapaDiseno.Mantenimiento
{
    public partial class Frm_ConfiguracionRpt : Form
    {
        private ConfiguracionRptControl configuracionRptControl = new ConfiguracionRptControl();
        private ConfiguracionRpt configuracionRpt;
        private string accion;
        
        public Frm_ConfiguracionRpt()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            llenarDgv();
        }

        private void llenarDgv()
        {
            int fila = 0;
            Dgv_Consulta.Rows.Clear();
            foreach (ConfiguracionRpt configuracionRptTmp in configuracionRptControl.obtenerAllConfiguracionRpt())
            {
                Dgv_Consulta.Rows.Add();
                Dgv_Consulta.Rows[fila].Cells[0].Value = configuracionRptTmp.CONFIGURACION.ToString();
                Dgv_Consulta.Rows[fila].Cells[1].Value = configuracionRptTmp.NOMBRE;
                Dgv_Consulta.Rows[fila].Cells[2].Value = configuracionRptTmp.USER;
                Dgv_Consulta.Rows[fila].Cells[3].Value = configuracionRptTmp.RUTA;
                Dgv_Consulta.Rows[fila].Cells[4].Value = configuracionRptTmp.ESTADO.ToString();
                fila++;
            }
        }

        private void iniciazliarTbpConsulta()
        {
            habilitarCampos();

            Txt_Codigo.Text = "";
            Txt_Nombre.Text = "";
            Txt_Usuario.Text = "";
            Txt_Contrasena.Text = "";
            Txt_Puerto.Text = "";
            Txt_Ruta.Text = "";
            Txt_Estado.Text = "1";
        }

        private ConfiguracionRpt llenarConfiguracion()
        {
            ConfiguracionRpt confTmp = new ConfiguracionRpt();
            confTmp.CONFIGURACION = int.Parse(Txt_Codigo.Text);
            confTmp.NOMBRE = Txt_Nombre.Text;
            confTmp.USER = Txt_Usuario.Text;
            confTmp.PASSWORD = Txt_Contrasena.Text;
            confTmp.PUERTO = Txt_Puerto.Text;
            confTmp.RUTA = Txt_Ruta.Text;
            confTmp.ESTADO = int.Parse(Txt_Estado.Text);

            return confTmp;
        }

        private void deshabilitarCampos()
        {
            Txt_Codigo.Enabled = false;
            Txt_Nombre.Enabled = false;
            Txt_Usuario.Enabled = false;
            Txt_Contrasena.Enabled = false;
            Txt_Puerto.Enabled = false;
            Txt_Ruta.Enabled = false;
            Txt_Estado.Enabled = false;
        }

        private void habilitarCampos()
        {
            Txt_Codigo.Enabled = true;
            Txt_Nombre.Enabled = true;
            Txt_Usuario.Enabled = true;
            Txt_Contrasena.Enabled = true;
            Txt_Puerto.Enabled = true;
            Txt_Ruta.Enabled = true;
            Txt_Estado.Enabled = true;
        }

        private void llenarTbpDato(ConfiguracionRpt configuracion)
        {
            deshabilitarCampos();
            Txt_Codigo.Text = configuracion.CONFIGURACION.ToString();
            Txt_Nombre.Text = configuracion.NOMBRE;
            Txt_Usuario.Text = configuracion.USER;
            Txt_Contrasena.Text = configuracion.PASSWORD;
            Txt_Puerto.Text = configuracion.PUERTO;
            Txt_Ruta.Text = configuracion.RUTA;
            Txt_Estado.Text = configuracion.ESTADO.ToString();
        }

        /*
         * Programacion botones.
         */

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            iniciazliarTbpConsulta();
            this.configuracionRpt = new ConfiguracionRpt();
            Tbc_Configuracion.SelectedTab = Tbp_Datos;
            this.accion = "nuevo";
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            iniciazliarTbpConsulta();
            Tbc_Configuracion.SelectedTab = Tbp_Consulta;
            this.configuracionRpt = new ConfiguracionRpt();
            llenarDgv();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            this.configuracionRpt = llenarConfiguracion();

            Dialogo dialogo = new Dialogo();
            bool confirmacion = dialogo.dialogoSiNo("Confirmacion", "Desea guardar?");
            if (confirmacion)
            {
                if (this.accion == "nuevo")
                {
                    configuracionRptControl.insertarConfiguracionRpt(this.configuracionRpt);
                }
                else if (this.accion == "modificar")
                {
                    configuracionRptControl.actualizarConfiguracionRpt(this.configuracionRpt);
                }

                iniciazliarTbpConsulta();
                Tbc_Configuracion.SelectedTab = Tbp_Consulta;
                this.configuracionRpt = new ConfiguracionRpt();
                llenarDgv();
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            this.configuracionRpt = llenarConfiguracion();
            this.accion = "modificar";
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            this.accion = null;
            Dialogo dialogo = new Dialogo();
            bool confirmacion = dialogo.dialogoSiNo("Confirmacion", "Desea eliminar?");

            if (confirmacion)
            {
                configuracionRptControl.eliminarConfiguracionRpt(this.configuracionRpt.CONFIGURACION);
                this.configuracionRpt = new ConfiguracionRpt();

                iniciazliarTbpConsulta();
                Tbc_Configuracion.SelectedTab = Tbp_Consulta;
                llenarDgv();
            }
        }

        /*
         * Seleccionar registro.
         */

        private void seleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Dgv_Consulta.CurrentCell.RowIndex;
            String codigoConfig = Dgv_Consulta.Rows[fila].Cells[0].Value.ToString();
            this.configuracionRpt = configuracionRptControl.obtenerConfiguracionRpt(Int32.Parse(codigoConfig));
            llenarTbpDato(this.configuracionRpt);
            Tbc_Configuracion.SelectedTab = Tbp_Datos;
        }

    }
}
 