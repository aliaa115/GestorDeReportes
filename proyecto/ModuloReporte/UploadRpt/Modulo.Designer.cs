namespace UploadRpt
{
    partial class Modulo
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
            this.Mst_Menu = new System.Windows.Forms.MenuStrip();
            this.Tool_Rpt = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mst_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mst_Menu
            // 
            this.Mst_Menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Mst_Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Mst_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Rpt,
            this.aplicacionToolStripMenuItem});
            this.Mst_Menu.Location = new System.Drawing.Point(0, 0);
            this.Mst_Menu.Name = "Mst_Menu";
            this.Mst_Menu.Size = new System.Drawing.Size(1608, 42);
            this.Mst_Menu.TabIndex = 0;
            this.Mst_Menu.Text = "menuStrip1";
            // 
            // Tool_Rpt
            // 
            this.Tool_Rpt.Name = "Tool_Rpt";
            this.Tool_Rpt.Size = new System.Drawing.Size(128, 38);
            this.Tool_Rpt.Text = "Reportes";
            // 
            // aplicacionToolStripMenuItem
            // 
            this.aplicacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitacoraToolStripMenuItem});
            this.aplicacionToolStripMenuItem.Name = "aplicacionToolStripMenuItem";
            this.aplicacionToolStripMenuItem.Size = new System.Drawing.Size(144, 38);
            this.aplicacionToolStripMenuItem.Text = "Aplicacion";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // Modulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 877);
            this.Controls.Add(this.Mst_Menu);
            this.MainMenuStrip = this.Mst_Menu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Modulo";
            this.Text = "Modulo";
            this.Mst_Menu.ResumeLayout(false);
            this.Mst_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mst_Menu;
        private System.Windows.Forms.ToolStripMenuItem Tool_Rpt;
        private System.Windows.Forms.ToolStripMenuItem aplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
    }
}