using System;
using System.Collections.Generic;
using System.Windows.Forms;
using capaDatoRpt.Entity;
using CapaControlRpt.Control;

/**Cristhian de Leon 0901 15 6167
 * 
 * Clase para impresion de reportes desde app y mdl.
*/
namespace CapaDisenoRpt.Procesos
{
    public class ReportesModulo
    {
        private int codModulo;
        private ReporteModuloControl reporteMdlControl = new ReporteModuloControl();
        private string usuario;

        public ReportesModulo(int codModulo, string usu)
        {
            this.codModulo = codModulo;
            this.usuario = usu;
        }

        public List<ToolStripMenuItem> llenarListaRpt(int mdl)
        {
            List<ToolStripMenuItem> itemList = new List<ToolStripMenuItem>();

            try
            {
                List<ReporteModulo> reporteMdlList = reporteMdlControl.obtenerAllReporteMdlByMdl(mdl);

                foreach (ReporteModulo rptMdl in reporteMdlList) 
                {
                    ToolStripMenuItem itemTmp = new ToolStripMenuItem();
                    itemTmp.Name = rptMdl.REPORTE.REPORTE.ToString();
                    itemTmp.Text = rptMdl.REPORTE.NOMBRE;
                    itemTmp.Click += new EventHandler(Item_Rpt_Click);

                    itemList.Add(itemTmp);
                }

                return itemList;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString() + "Error al obtener lista de reportes.");
            }
        }

        //Metodo click para items de reportes
        private void Item_Rpt_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            try
            {
                ImprimirReporte imprimir = new ImprimirReporte(usuario);
                imprimir.imprimirReporteModulo( Int32.Parse(item.Name), usuario, codModulo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex+"");
                //throw new Exception(ex.ToString() + "Error en impresion, no se obtuvo reporte asociado.");
            }
        }

        public List<ToolStripMenuItem> crearItems()
        {
            List<ToolStripMenuItem> itemList = new List<ToolStripMenuItem>();
            
            //Llenar items reportes
            var itemListaRpt = new ToolStripMenuItem()
            {
                Name = "Tli_ListaRpt",
                Text = "Lista de Reportes"
            };

            foreach (ToolStripMenuItem rptItem in llenarListaRpt(codModulo))
            {
                itemListaRpt.DropDownItems.Add(rptItem);
            }
            
            itemList.Add(itemListaRpt);

            //Agregar item de configuracion
            var itemListaConfig = new ToolStripMenuItem()
            {
                Name = "Tli_ListaConfig",
                Text = "Configuracion de Reportes"
                
            };
            itemListaConfig.Click += new EventHandler(Item_Confi_Click);
            itemList.Add(itemListaConfig);

            return itemList;
        }

        private void Item_Confi_Click(object sender, EventArgs e)
        {
            Frm_Main frm_Main = new Frm_Main();
            frm_Main.Show();
        }
    }
}
