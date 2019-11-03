namespace CapaDisenoRpt.Mantenimiento
{
    partial class Frm_PropiedadesApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Chk_Estado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Chk_Impresion = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Cmb_Modulo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_Aplicacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_Reporte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Chk_Estado);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Chk_Impresion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Btn_Borrar);
            this.panel1.Controls.Add(this.Btn_Guardar);
            this.panel1.Controls.Add(this.Cmb_Modulo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Cmb_Aplicacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Cmb_Reporte);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_Usuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 307);
            this.panel1.TabIndex = 3;
            // 
            // Chk_Estado
            // 
            this.Chk_Estado.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chk_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Estado.Location = new System.Drawing.Point(92, 186);
            this.Chk_Estado.Name = "Chk_Estado";
            this.Chk_Estado.Size = new System.Drawing.Size(104, 24);
            this.Chk_Estado.TabIndex = 30;
            this.Chk_Estado.UseVisualStyleBackColor = true;
            this.Chk_Estado.CheckedChanged += new System.EventHandler(this.Chk_Estado_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Estado: ";
            // 
            // Chk_Impresion
            // 
            this.Chk_Impresion.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chk_Impresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Impresion.Location = new System.Drawing.Point(120, 240);
            this.Chk_Impresion.Name = "Chk_Impresion";
            this.Chk_Impresion.Size = new System.Drawing.Size(48, 45);
            this.Chk_Impresion.TabIndex = 28;
            this.Chk_Impresion.UseVisualStyleBackColor = true;
            this.Chk_Impresion.CheckedChanged += new System.EventHandler(this.Chk_Impresion_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(26, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "IMPRESION DE REPORTE AUTOMATICO: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(62, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 31);
            this.label5.TabIndex = 26;
            this.label5.Text = "PROPIEDADES DE REPORTE";
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackgroundImage = global::CapaDisenoRpt.Properties.Resources.delete_files;
            this.Btn_Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Borrar.Location = new System.Drawing.Point(339, 211);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(74, 74);
            this.Btn_Borrar.TabIndex = 25;
            this.Btn_Borrar.Text = "Cancelar";
            this.Btn_Borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImage = global::CapaDisenoRpt.Properties.Resources.save_filepng;
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Guardar.Location = new System.Drawing.Point(419, 211);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(74, 74);
            this.Btn_Guardar.TabIndex = 2;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Cmb_Modulo
            // 
            this.Cmb_Modulo.Enabled = false;
            this.Cmb_Modulo.FormattingEnabled = true;
            this.Cmb_Modulo.Location = new System.Drawing.Point(94, 103);
            this.Cmb_Modulo.Name = "Cmb_Modulo";
            this.Cmb_Modulo.Size = new System.Drawing.Size(399, 21);
            this.Cmb_Modulo.TabIndex = 18;
            this.Cmb_Modulo.SelectedIndexChanged += new System.EventHandler(this.Cmb_Modulo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(40, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Modulo: ";
            // 
            // Cmb_Aplicacion
            // 
            this.Cmb_Aplicacion.Enabled = false;
            this.Cmb_Aplicacion.FormattingEnabled = true;
            this.Cmb_Aplicacion.Location = new System.Drawing.Point(94, 130);
            this.Cmb_Aplicacion.Name = "Cmb_Aplicacion";
            this.Cmb_Aplicacion.Size = new System.Drawing.Size(399, 21);
            this.Cmb_Aplicacion.TabIndex = 20;
            this.Cmb_Aplicacion.SelectedIndexChanged += new System.EventHandler(this.Cmb_Aplicacion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Aplicacion: ";
            // 
            // Cmb_Reporte
            // 
            this.Cmb_Reporte.Enabled = false;
            this.Cmb_Reporte.FormattingEnabled = true;
            this.Cmb_Reporte.Location = new System.Drawing.Point(94, 157);
            this.Cmb_Reporte.Name = "Cmb_Reporte";
            this.Cmb_Reporte.Size = new System.Drawing.Size(399, 21);
            this.Cmb_Reporte.TabIndex = 16;
            this.Cmb_Reporte.SelectedIndexChanged += new System.EventHandler(this.Cmb_Reporte_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(37, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Reporte: ";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Enabled = false;
            this.Txt_Usuario.Location = new System.Drawing.Point(94, 77);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(399, 20);
            this.Txt_Usuario.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(39, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario: ";
            // 
            // Frm_Propiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 307);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Propiedades";
            this.Text = "Propiedades";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Cmb_Modulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_Aplicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_Reporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.CheckBox Chk_Impresion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Chk_Estado;
        private System.Windows.Forms.Label label7;
    }
}