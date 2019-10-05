namespace CapaDisenoRpt.Mantenimiento
{
    partial class Frm_RptMdl
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
            this.Pnl_Nav = new System.Windows.Forms.Panel();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Tbc_RptMdl = new System.Windows.Forms.TabControl();
            this.Tbp_Consulta = new System.Windows.Forms.TabPage();
            this.Dgv_Consulta = new System.Windows.Forms.DataGridView();
            this.ID_REPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MODULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbp_Datos = new System.Windows.Forms.TabPage();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_Reporte = new System.Windows.Forms.ComboBox();
            this.Cmb_Modulo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Nav.SuspendLayout();
            this.Tbc_RptMdl.SuspendLayout();
            this.Tbp_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consulta)).BeginInit();
            this.Tbp_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Nav
            // 
            this.Pnl_Nav.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pnl_Nav.Controls.Add(this.Btn_Cancelar);
            this.Pnl_Nav.Controls.Add(this.Btn_Borrar);
            this.Pnl_Nav.Controls.Add(this.Btn_Guardar);
            this.Pnl_Nav.Controls.Add(this.Btn_Modificar);
            this.Pnl_Nav.Controls.Add(this.Btn_Nuevo);
            this.Pnl_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Nav.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Nav.Name = "Pnl_Nav";
            this.Pnl_Nav.Size = new System.Drawing.Size(904, 100);
            this.Pnl_Nav.TabIndex = 3;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImage = global::CapaDisenoRpt.Properties.Resources.cancel_file;
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cancelar.Location = new System.Drawing.Point(581, 12);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(74, 74);
            this.Btn_Cancelar.TabIndex = 4;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackgroundImage = global::CapaDisenoRpt.Properties.Resources.delete_files;
            this.Btn_Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Borrar.Location = new System.Drawing.Point(500, 12);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(74, 74);
            this.Btn_Borrar.TabIndex = 3;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImage = global::CapaDisenoRpt.Properties.Resources.save_filepng;
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Guardar.Location = new System.Drawing.Point(419, 12);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(74, 74);
            this.Btn_Guardar.TabIndex = 2;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackgroundImage = global::CapaDisenoRpt.Properties.Resources.edit_file;
            this.Btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Modificar.Location = new System.Drawing.Point(338, 12);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(74, 74);
            this.Btn_Modificar.TabIndex = 1;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackgroundImage = global::CapaDisenoRpt.Properties.Resources.add_file;
            this.Btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Nuevo.Location = new System.Drawing.Point(257, 12);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(74, 74);
            this.Btn_Nuevo.TabIndex = 0;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Tbc_RptMdl
            // 
            this.Tbc_RptMdl.Controls.Add(this.Tbp_Consulta);
            this.Tbc_RptMdl.Controls.Add(this.Tbp_Datos);
            this.Tbc_RptMdl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_RptMdl.Location = new System.Drawing.Point(0, 100);
            this.Tbc_RptMdl.Name = "Tbc_RptMdl";
            this.Tbc_RptMdl.SelectedIndex = 0;
            this.Tbc_RptMdl.Size = new System.Drawing.Size(904, 361);
            this.Tbc_RptMdl.TabIndex = 4;
            // 
            // Tbp_Consulta
            // 
            this.Tbp_Consulta.Controls.Add(this.Dgv_Consulta);
            this.Tbp_Consulta.Location = new System.Drawing.Point(4, 22);
            this.Tbp_Consulta.Name = "Tbp_Consulta";
            this.Tbp_Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Consulta.Size = new System.Drawing.Size(896, 335);
            this.Tbp_Consulta.TabIndex = 0;
            this.Tbp_Consulta.Text = "Consulta";
            this.Tbp_Consulta.UseVisualStyleBackColor = true;
            // 
            // Dgv_Consulta
            // 
            this.Dgv_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_REPORTE,
            this.NomReporte,
            this.ID_MODULO,
            this.NomModulo,
            this.Estado});
            this.Dgv_Consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Consulta.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Consulta.Name = "Dgv_Consulta";
            this.Dgv_Consulta.RowHeadersVisible = false;
            this.Dgv_Consulta.RowHeadersWidth = 82;
            this.Dgv_Consulta.Size = new System.Drawing.Size(890, 329);
            this.Dgv_Consulta.TabIndex = 1;
            this.Dgv_Consulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Consulta_CellDoubleClick);
            // 
            // ID_REPORTE
            // 
            this.ID_REPORTE.HeaderText = "Reporte";
            this.ID_REPORTE.Name = "ID_REPORTE";
            // 
            // NomReporte
            // 
            this.NomReporte.HeaderText = "Nombre Reporte";
            this.NomReporte.MinimumWidth = 10;
            this.NomReporte.Name = "NomReporte";
            this.NomReporte.Width = 200;
            // 
            // ID_MODULO
            // 
            this.ID_MODULO.HeaderText = "Modulo";
            this.ID_MODULO.Name = "ID_MODULO";
            // 
            // NomModulo
            // 
            this.NomModulo.HeaderText = "Nombre Modulo";
            this.NomModulo.MinimumWidth = 10;
            this.NomModulo.Name = "NomModulo";
            this.NomModulo.Width = 200;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 10;
            this.Estado.Name = "Estado";
            this.Estado.Width = 200;
            // 
            // Tbp_Datos
            // 
            this.Tbp_Datos.BackColor = System.Drawing.Color.AliceBlue;
            this.Tbp_Datos.Controls.Add(this.Txt_Estado);
            this.Tbp_Datos.Controls.Add(this.label4);
            this.Tbp_Datos.Controls.Add(this.Cmb_Reporte);
            this.Tbp_Datos.Controls.Add(this.Cmb_Modulo);
            this.Tbp_Datos.Controls.Add(this.label2);
            this.Tbp_Datos.Controls.Add(this.label1);
            this.Tbp_Datos.Location = new System.Drawing.Point(4, 22);
            this.Tbp_Datos.Name = "Tbp_Datos";
            this.Tbp_Datos.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Datos.Size = new System.Drawing.Size(896, 335);
            this.Tbp_Datos.TabIndex = 1;
            this.Tbp_Datos.Text = "Datos";
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(253, 150);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(397, 20);
            this.Txt_Estado.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado: ";
            // 
            // Cmb_Reporte
            // 
            this.Cmb_Reporte.FormattingEnabled = true;
            this.Cmb_Reporte.Location = new System.Drawing.Point(253, 96);
            this.Cmb_Reporte.Name = "Cmb_Reporte";
            this.Cmb_Reporte.Size = new System.Drawing.Size(399, 21);
            this.Cmb_Reporte.TabIndex = 1;
            // 
            // Cmb_Modulo
            // 
            this.Cmb_Modulo.FormattingEnabled = true;
            this.Cmb_Modulo.Location = new System.Drawing.Point(253, 123);
            this.Cmb_Modulo.Name = "Cmb_Modulo";
            this.Cmb_Modulo.Size = new System.Drawing.Size(399, 21);
            this.Cmb_Modulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modulo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte: ";
            // 
            // Frm_RptMdl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.Tbc_RptMdl);
            this.Controls.Add(this.Pnl_Nav);
            this.Name = "Frm_RptMdl";
            this.Text = "Asignacion Reporte a Modulo";
            this.Pnl_Nav.ResumeLayout(false);
            this.Tbc_RptMdl.ResumeLayout(false);
            this.Tbp_Consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consulta)).EndInit();
            this.Tbp_Datos.ResumeLayout(false);
            this.Tbp_Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Nav;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.TabControl Tbc_RptMdl;
        private System.Windows.Forms.TabPage Tbp_Consulta;
        private System.Windows.Forms.DataGridView Dgv_Consulta;
        private System.Windows.Forms.TabPage Tbp_Datos;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_Reporte;
        private System.Windows.Forms.ComboBox Cmb_Modulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_REPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MODULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}