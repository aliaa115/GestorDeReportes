namespace CapaDiseno.Procesos
{
    partial class Frm_VistaReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Crv_Reporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Crv_Reporte
            // 
            this.Crv_Reporte.ActiveViewIndex = -1;
            this.Crv_Reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_Reporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_Reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_Reporte.Location = new System.Drawing.Point(0, 0);
            this.Crv_Reporte.Margin = new System.Windows.Forms.Padding(6);
            this.Crv_Reporte.Name = "Crv_Reporte";
            this.Crv_Reporte.Size = new System.Drawing.Size(2016, 1156);
            this.Crv_Reporte.TabIndex = 0;
            this.Crv_Reporte.ToolPanelWidth = 400;
            // 
            // Frm_VistaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2016, 1156);
            this.Controls.Add(this.Crv_Reporte);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_VistaReporte";
            this.Text = "Frm_VistaReporte";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_Reporte;
    }
}