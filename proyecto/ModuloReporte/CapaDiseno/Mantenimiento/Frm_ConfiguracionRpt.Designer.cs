namespace CapaDisenoRpt.Mantenimiento
{
    partial class Frm_ConfiguracionRpt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void  Dispose(bool disposing)
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
            this.Pnl_Datos = new System.Windows.Forms.Panel();
            this.Tbc_Configuracion = new System.Windows.Forms.TabControl();
            this.Tbp_Consulta = new System.Windows.Forms.TabPage();
            this.Dgv_Consulta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbp_Datos = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Txt_Ruta = new System.Windows.Forms.TextBox();
            this.Txt_Puerto = new System.Windows.Forms.TextBox();
            this.Txt_Contrasena = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Pnl_Nav = new System.Windows.Forms.Panel();
            this.Pnl_Datos.SuspendLayout();
            this.Tbc_Configuracion.SuspendLayout();
            this.Tbp_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consulta)).BeginInit();
            this.Tbp_Datos.SuspendLayout();
            this.Pnl_Nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Datos
            // 
            this.Pnl_Datos.Controls.Add(this.Tbc_Configuracion);
            this.Pnl_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Datos.Location = new System.Drawing.Point(0, 100);
            this.Pnl_Datos.Name = "Pnl_Datos";
            this.Pnl_Datos.Size = new System.Drawing.Size(904, 361);
            this.Pnl_Datos.TabIndex = 1;
            // 
            // Tbc_Configuracion
            // 
            this.Tbc_Configuracion.Controls.Add(this.Tbp_Consulta);
            this.Tbc_Configuracion.Controls.Add(this.Tbp_Datos);
            this.Tbc_Configuracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Configuracion.Location = new System.Drawing.Point(0, 0);
            this.Tbc_Configuracion.Name = "Tbc_Configuracion";
            this.Tbc_Configuracion.SelectedIndex = 0;
            this.Tbc_Configuracion.Size = new System.Drawing.Size(904, 361);
            this.Tbc_Configuracion.TabIndex = 0;
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
            this.User,
            this.Ruta,
            this.Estado});
            this.Dgv_Consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Consulta.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Consulta.Name = "Dgv_Consulta";
            this.Dgv_Consulta.RowHeadersVisible = false;
            this.Dgv_Consulta.Size = new System.Drawing.Size(890, 329);
            this.Dgv_Consulta.TabIndex = 1;
            this.Dgv_Consulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionarRegistro);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.Name = "User";
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Tbp_Datos
            // 
            this.Tbp_Datos.Controls.Add(this.label7);
            this.Tbp_Datos.Controls.Add(this.label6);
            this.Tbp_Datos.Controls.Add(this.label5);
            this.Tbp_Datos.Controls.Add(this.label4);
            this.Tbp_Datos.Controls.Add(this.label3);
            this.Tbp_Datos.Controls.Add(this.Txt_Estado);
            this.Tbp_Datos.Controls.Add(this.Txt_Ruta);
            this.Tbp_Datos.Controls.Add(this.Txt_Puerto);
            this.Tbp_Datos.Controls.Add(this.Txt_Contrasena);
            this.Tbp_Datos.Controls.Add(this.Txt_Usuario);
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
            this.Tbp_Datos.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ruta: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Puerto: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuario: ";
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(251, 224);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(399, 20);
            this.Txt_Estado.TabIndex = 8;
            // 
            // Txt_Ruta
            // 
            this.Txt_Ruta.Location = new System.Drawing.Point(251, 198);
            this.Txt_Ruta.Name = "Txt_Ruta";
            this.Txt_Ruta.Size = new System.Drawing.Size(399, 20);
            this.Txt_Ruta.TabIndex = 7;
            // 
            // Txt_Puerto
            // 
            this.Txt_Puerto.Location = new System.Drawing.Point(251, 172);
            this.Txt_Puerto.Name = "Txt_Puerto";
            this.Txt_Puerto.Size = new System.Drawing.Size(399, 20);
            this.Txt_Puerto.TabIndex = 6;
            // 
            // Txt_Contrasena
            // 
            this.Txt_Contrasena.Location = new System.Drawing.Point(251, 146);
            this.Txt_Contrasena.Name = "Txt_Contrasena";
            this.Txt_Contrasena.Size = new System.Drawing.Size(399, 20);
            this.Txt_Contrasena.TabIndex = 5;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(252, 120);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(399, 20);
            this.Txt_Usuario.TabIndex = 4;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(252, 94);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(399, 20);
            this.Txt_Nombre.TabIndex = 3;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(252, 68);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(399, 20);
            this.Txt_Codigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo: ";
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
            this.Pnl_Nav.TabIndex = 0;
            // 
            // Frm_ConfiguracionRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.Pnl_Datos);
            this.Controls.Add(this.Pnl_Nav);
            this.Name = "Frm_ConfiguracionRpt";
            this.Text = "Configuracion Reporte";
            this.Pnl_Datos.ResumeLayout(false);
            this.Tbc_Configuracion.ResumeLayout(false);
            this.Tbp_Consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consulta)).EndInit();
            this.Tbp_Datos.ResumeLayout(false);
            this.Tbp_Datos.PerformLayout();
            this.Pnl_Nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_Datos;
        private System.Windows.Forms.TabControl Tbc_Configuracion;
        private System.Windows.Forms.TabPage Tbp_Consulta;
        private System.Windows.Forms.TabPage Tbp_Datos;
        private System.Windows.Forms.DataGridView Dgv_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.TextBox Txt_Ruta;
        private System.Windows.Forms.TextBox Txt_Puerto;
        private System.Windows.Forms.TextBox Txt_Contrasena;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Panel Pnl_Nav;
    }
}