namespace CapaDisenoRpt.Mantenimiento
{
    partial class Frm_PropiedadRptMdl
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
            this.Tbc_Reporte = new System.Windows.Forms.TabControl();
            this.Tbp_Consulta = new System.Windows.Forms.TabPage();
            this.Dgv_Consulta = new System.Windows.Forms.DataGridView();
            this.CodReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbp_Datos = new System.Windows.Forms.TabPage();
            this.Chk_Estado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Chk_Impresion = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_Modulo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_Aplicacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_Reporte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Nav = new System.Windows.Forms.Panel();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Tbc_Reporte.SuspendLayout();
            this.Tbp_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consulta)).BeginInit();
            this.Tbp_Datos.SuspendLayout();
            this.Pnl_Nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_Reporte
            // 
            this.Tbc_Reporte.Controls.Add(this.Tbp_Consulta);
            this.Tbc_Reporte.Controls.Add(this.Tbp_Datos);
            this.Tbc_Reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Reporte.Location = new System.Drawing.Point(0, 100);
            this.Tbc_Reporte.Name = "Tbc_Reporte";
            this.Tbc_Reporte.SelectedIndex = 0;
            this.Tbc_Reporte.Size = new System.Drawing.Size(800, 350);
            this.Tbc_Reporte.TabIndex = 4;
            // 
            // Tbp_Consulta
            // 
            this.Tbp_Consulta.Controls.Add(this.Dgv_Consulta);
            this.Tbp_Consulta.Location = new System.Drawing.Point(4, 22);
            this.Tbp_Consulta.Name = "Tbp_Consulta";
            this.Tbp_Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Consulta.Size = new System.Drawing.Size(792, 324);
            this.Tbp_Consulta.TabIndex = 0;
            this.Tbp_Consulta.Text = "Consulta";
            this.Tbp_Consulta.UseVisualStyleBackColor = true;
            // 
            // Dgv_Consulta
            // 
            this.Dgv_Consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodReporte,
            this.Reporte,
            this.Usu,
            this.CodApp,
            this.Aplicacion,
            this.CodModulo,
            this.Modulo,
            this.Imp,
            this.est});
            this.Dgv_Consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Consulta.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Consulta.Name = "Dgv_Consulta";
            this.Dgv_Consulta.RowHeadersVisible = false;
            this.Dgv_Consulta.RowHeadersWidth = 82;
            this.Dgv_Consulta.Size = new System.Drawing.Size(786, 318);
            this.Dgv_Consulta.TabIndex = 2;
            this.Dgv_Consulta.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Consulta_CellDoubleClick);
            // 
            // CodReporte
            // 
            this.CodReporte.HeaderText = "Cod Reporte";
            this.CodReporte.Name = "CodReporte";
            this.CodReporte.ReadOnly = true;
            // 
            // Reporte
            // 
            this.Reporte.HeaderText = "Reporte";
            this.Reporte.MinimumWidth = 10;
            this.Reporte.Name = "Reporte";
            this.Reporte.ReadOnly = true;
            // 
            // Usu
            // 
            this.Usu.HeaderText = "Usuario";
            this.Usu.MinimumWidth = 10;
            this.Usu.Name = "Usu";
            this.Usu.ReadOnly = true;
            // 
            // CodApp
            // 
            this.CodApp.HeaderText = "Cod Aplicacion";
            this.CodApp.Name = "CodApp";
            this.CodApp.ReadOnly = true;
            // 
            // Aplicacion
            // 
            this.Aplicacion.HeaderText = "Aplicacion";
            this.Aplicacion.Name = "Aplicacion";
            this.Aplicacion.ReadOnly = true;
            // 
            // CodModulo
            // 
            this.CodModulo.HeaderText = "Cod Modulo";
            this.CodModulo.MinimumWidth = 10;
            this.CodModulo.Name = "CodModulo";
            this.CodModulo.ReadOnly = true;
            // 
            // Modulo
            // 
            this.Modulo.HeaderText = "Modulo";
            this.Modulo.Name = "Modulo";
            this.Modulo.ReadOnly = true;
            // 
            // Imp
            // 
            this.Imp.HeaderText = "Impresion";
            this.Imp.Name = "Imp";
            this.Imp.ReadOnly = true;
            // 
            // est
            // 
            this.est.HeaderText = "Estado";
            this.est.Name = "est";
            this.est.ReadOnly = true;
            // 
            // Tbp_Datos
            // 
            this.Tbp_Datos.BackColor = System.Drawing.Color.AliceBlue;
            this.Tbp_Datos.Controls.Add(this.Chk_Estado);
            this.Tbp_Datos.Controls.Add(this.label7);
            this.Tbp_Datos.Controls.Add(this.Chk_Impresion);
            this.Tbp_Datos.Controls.Add(this.label6);
            this.Tbp_Datos.Controls.Add(this.label5);
            this.Tbp_Datos.Controls.Add(this.Cmb_Modulo);
            this.Tbp_Datos.Controls.Add(this.label4);
            this.Tbp_Datos.Controls.Add(this.Cmb_Aplicacion);
            this.Tbp_Datos.Controls.Add(this.label2);
            this.Tbp_Datos.Controls.Add(this.Cmb_Reporte);
            this.Tbp_Datos.Controls.Add(this.label3);
            this.Tbp_Datos.Controls.Add(this.Txt_Usuario);
            this.Tbp_Datos.Controls.Add(this.label1);
            this.Tbp_Datos.Location = new System.Drawing.Point(4, 22);
            this.Tbp_Datos.Name = "Tbp_Datos";
            this.Tbp_Datos.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Datos.Size = new System.Drawing.Size(792, 324);
            this.Tbp_Datos.TabIndex = 1;
            this.Tbp_Datos.Text = "Datos";
            // 
            // Chk_Estado
            // 
            this.Chk_Estado.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chk_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Estado.Location = new System.Drawing.Point(229, 192);
            this.Chk_Estado.Name = "Chk_Estado";
            this.Chk_Estado.Size = new System.Drawing.Size(104, 24);
            this.Chk_Estado.TabIndex = 45;
            this.Chk_Estado.UseVisualStyleBackColor = true;
            this.Chk_Estado.CheckedChanged += new System.EventHandler(this.Chk_Estado_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Estado: ";
            // 
            // Chk_Impresion
            // 
            this.Chk_Impresion.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chk_Impresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Impresion.Location = new System.Drawing.Point(257, 246);
            this.Chk_Impresion.Name = "Chk_Impresion";
            this.Chk_Impresion.Size = new System.Drawing.Size(48, 45);
            this.Chk_Impresion.TabIndex = 43;
            this.Chk_Impresion.UseVisualStyleBackColor = true;
            this.Chk_Impresion.CheckedChanged += new System.EventHandler(this.Chk_Impresion_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(163, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "IMPRESION DE REPORTE AUTOMATICO: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(199, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "PROPIEDADES DE REPORTE";
            // 
            // Cmb_Modulo
            // 
            this.Cmb_Modulo.FormattingEnabled = true;
            this.Cmb_Modulo.Location = new System.Drawing.Point(231, 109);
            this.Cmb_Modulo.Name = "Cmb_Modulo";
            this.Cmb_Modulo.Size = new System.Drawing.Size(399, 21);
            this.Cmb_Modulo.TabIndex = 36;
            this.Cmb_Modulo.SelectedIndexChanged += new System.EventHandler(this.Cmb_Modulo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Modulo: ";
            // 
            // Cmb_Aplicacion
            // 
            this.Cmb_Aplicacion.FormattingEnabled = true;
            this.Cmb_Aplicacion.Location = new System.Drawing.Point(231, 136);
            this.Cmb_Aplicacion.Name = "Cmb_Aplicacion";
            this.Cmb_Aplicacion.Size = new System.Drawing.Size(399, 21);
            this.Cmb_Aplicacion.TabIndex = 38;
            this.Cmb_Aplicacion.SelectedIndexChanged += new System.EventHandler(this.Cmb_Aplicacion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Aplicacion: ";
            // 
            // Cmb_Reporte
            // 
            this.Cmb_Reporte.FormattingEnabled = true;
            this.Cmb_Reporte.Location = new System.Drawing.Point(231, 163);
            this.Cmb_Reporte.Name = "Cmb_Reporte";
            this.Cmb_Reporte.Size = new System.Drawing.Size(399, 21);
            this.Cmb_Reporte.TabIndex = 34;
            this.Cmb_Reporte.SelectedIndexChanged += new System.EventHandler(this.Cmb_Reporte_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Reporte: ";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Enabled = false;
            this.Txt_Usuario.Location = new System.Drawing.Point(231, 83);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(399, 20);
            this.Txt_Usuario.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Usuario: ";
            // 
            // Pnl_Nav
            // 
            this.Pnl_Nav.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pnl_Nav.Controls.Add(this.Btn_Cancelar);
            this.Pnl_Nav.Controls.Add(this.Btn_Borrar);
            this.Pnl_Nav.Controls.Add(this.Btn_Guardar);
            this.Pnl_Nav.Controls.Add(this.Btn_Nuevo);
            this.Pnl_Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Nav.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Nav.Name = "Pnl_Nav";
            this.Pnl_Nav.Size = new System.Drawing.Size(800, 100);
            this.Pnl_Nav.TabIndex = 3;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImage = global::CapaDisenoRpt.Properties.Resources.cancel_file;
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cancelar.Location = new System.Drawing.Point(474, 13);
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
            this.Btn_Borrar.Location = new System.Drawing.Point(400, 13);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(74, 74);
            this.Btn_Borrar.TabIndex = 3;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImage = global::CapaDisenoRpt.Properties.Resources.save_filepng;
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Guardar.Location = new System.Drawing.Point(326, 13);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(74, 74);
            this.Btn_Guardar.TabIndex = 2;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackgroundImage = global::CapaDisenoRpt.Properties.Resources.add_file;
            this.Btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Nuevo.Location = new System.Drawing.Point(252, 13);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(74, 74);
            this.Btn_Nuevo.TabIndex = 0;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Frm_PropiedadRptMdl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbc_Reporte);
            this.Controls.Add(this.Pnl_Nav);
            this.Name = "Frm_PropiedadRptMdl";
            this.Text = "PropiedadRptMdl";
            this.Tbc_Reporte.ResumeLayout(false);
            this.Tbp_Consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consulta)).EndInit();
            this.Tbp_Datos.ResumeLayout(false);
            this.Tbp_Datos.PerformLayout();
            this.Pnl_Nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_Reporte;
        private System.Windows.Forms.TabPage Tbp_Consulta;
        private System.Windows.Forms.TabPage Tbp_Datos;
        private System.Windows.Forms.Panel Pnl_Nav;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.CheckBox Chk_Estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Chk_Impresion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmb_Modulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_Aplicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_Reporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imp;
        private System.Windows.Forms.DataGridViewTextBoxColumn est;
    }
}