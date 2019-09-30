namespace CapaDisenoRpt.Mantenimiento
{
    partial class Frm_Reporte
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
            this.Tbc_Reporte = new System.Windows.Forms.TabControl();
            this.Tbp_Consulta = new System.Windows.Forms.TabPage();
            this.Dgv_Consulta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Configuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbp_Datos = new System.Windows.Forms.TabPage();
            this.Btn_SeleccionarFile = new System.Windows.Forms.Button();
            this.Cmb_Configuracion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Txt_Archivo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_PreView = new System.Windows.Forms.Button();
            this.Pnl_Nav.SuspendLayout();
            this.Tbc_Reporte.SuspendLayout();
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
            this.Pnl_Nav.TabIndex = 1;
            // 
            // Tbc_Reporte
            // 
            this.Tbc_Reporte.Controls.Add(this.Tbp_Consulta);
            this.Tbc_Reporte.Controls.Add(this.Tbp_Datos);
            this.Tbc_Reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Reporte.Location = new System.Drawing.Point(0, 100);
            this.Tbc_Reporte.Name = "Tbc_Reporte";
            this.Tbc_Reporte.SelectedIndex = 0;
            this.Tbc_Reporte.Size = new System.Drawing.Size(904, 361);
            this.Tbc_Reporte.TabIndex = 2;
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
            this.Codigo,
            this.Nombre,
            this.Configuracion,
            this.Archivo,
            this.Estado});
            this.Dgv_Consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Consulta.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Consulta.Name = "Dgv_Consulta";
            this.Dgv_Consulta.RowHeadersWidth = 82;
            this.Dgv_Consulta.Size = new System.Drawing.Size(890, 329);
            this.Dgv_Consulta.TabIndex = 1;
            this.Dgv_Consulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionarRegistro);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 10;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 10;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Configuracion
            // 
            this.Configuracion.HeaderText = "Configuracion";
            this.Configuracion.MinimumWidth = 10;
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Width = 200;
            // 
            // Archivo
            // 
            this.Archivo.HeaderText = "Nombre archivo";
            this.Archivo.MinimumWidth = 10;
            this.Archivo.Name = "Archivo";
            this.Archivo.Width = 130;
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
            this.Tbp_Datos.Controls.Add(this.Btn_PreView);
            this.Tbp_Datos.Controls.Add(this.Btn_SeleccionarFile);
            this.Tbp_Datos.Controls.Add(this.Cmb_Configuracion);
            this.Tbp_Datos.Controls.Add(this.label7);
            this.Tbp_Datos.Controls.Add(this.label4);
            this.Tbp_Datos.Controls.Add(this.label3);
            this.Tbp_Datos.Controls.Add(this.Txt_Estado);
            this.Tbp_Datos.Controls.Add(this.Txt_Archivo);
            this.Tbp_Datos.Controls.Add(this.Txt_Nombre);
            this.Tbp_Datos.Controls.Add(this.Txt_Codigo);
            this.Tbp_Datos.Controls.Add(this.label2);
            this.Tbp_Datos.Controls.Add(this.label1);
            this.Tbp_Datos.Location = new System.Drawing.Point(4, 22);
            this.Tbp_Datos.Name = "Tbp_Datos";
            this.Tbp_Datos.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Datos.Size = new System.Drawing.Size(896, 335);
            this.Tbp_Datos.TabIndex = 1;
            this.Tbp_Datos.Text = "Datos";
            // 
            // Btn_SeleccionarFile
            // 
            this.Btn_SeleccionarFile.Location = new System.Drawing.Point(577, 145);
            this.Btn_SeleccionarFile.Name = "Btn_SeleccionarFile";
            this.Btn_SeleccionarFile.Size = new System.Drawing.Size(75, 20);
            this.Btn_SeleccionarFile.TabIndex = 6;
            this.Btn_SeleccionarFile.Text = "Seleccionar";
            this.Btn_SeleccionarFile.UseVisualStyleBackColor = true;
            this.Btn_SeleccionarFile.Click += new System.EventHandler(this.Btn_SeleccionarFile_Click);
            // 
            // Cmb_Configuracion
            // 
            this.Cmb_Configuracion.FormattingEnabled = true;
            this.Cmb_Configuracion.Location = new System.Drawing.Point(252, 119);
            this.Cmb_Configuracion.Name = "Cmb_Configuracion";
            this.Cmb_Configuracion.Size = new System.Drawing.Size(399, 21);
            this.Cmb_Configuracion.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Archivo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Configuracion: ";
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(252, 171);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(400, 20);
            this.Txt_Estado.TabIndex = 7;
            // 
            // Txt_Archivo
            // 
            this.Txt_Archivo.Enabled = false;
            this.Txt_Archivo.Location = new System.Drawing.Point(252, 146);
            this.Txt_Archivo.Name = "Txt_Archivo";
            this.Txt_Archivo.Size = new System.Drawing.Size(318, 20);
            this.Txt_Archivo.TabIndex = 5;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(252, 93);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(400, 20);
            this.Txt_Nombre.TabIndex = 3;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(252, 67);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(400, 20);
            this.Txt_Codigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo: ";
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
            // Btn_PreView
            // 
            this.Btn_PreView.BackgroundImage = global::CapaDisenoRpt.Properties.Resources.linked_File;
            this.Btn_PreView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_PreView.Location = new System.Drawing.Point(576, 217);
            this.Btn_PreView.Name = "Btn_PreView";
            this.Btn_PreView.Size = new System.Drawing.Size(75, 75);
            this.Btn_PreView.TabIndex = 14;
            this.Btn_PreView.UseVisualStyleBackColor = true;
            this.Btn_PreView.Click += new System.EventHandler(this.Btn_PreView_Click);
            // 
            // Frm_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.Tbc_Reporte);
            this.Controls.Add(this.Pnl_Nav);
            this.Name = "Frm_Reporte";
            this.Text = "Reporte";
            this.Pnl_Nav.ResumeLayout(false);
            this.Tbc_Reporte.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl Tbc_Reporte;
        private System.Windows.Forms.TabPage Tbp_Consulta;
        private System.Windows.Forms.DataGridView Dgv_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Configuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.TextBox Txt_Archivo;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_SeleccionarFile;
        private System.Windows.Forms.ComboBox Cmb_Configuracion;
        private System.Windows.Forms.TabPage Tbp_Datos;
        private System.Windows.Forms.Button Btn_PreView;
    }
}