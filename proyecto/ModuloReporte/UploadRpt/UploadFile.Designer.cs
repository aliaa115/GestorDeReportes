namespace UploadRpt
{
    partial class UploadFile
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Seleccionar = new System.Windows.Forms.Button();
            this.Txt_Archivo = new System.Windows.Forms.TextBox();
            this.Cbx_Modulo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Upload = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Seleccionar
            // 
            this.Btn_Seleccionar.Location = new System.Drawing.Point(553, 26);
            this.Btn_Seleccionar.Name = "Btn_Seleccionar";
            this.Btn_Seleccionar.Size = new System.Drawing.Size(120, 23);
            this.Btn_Seleccionar.TabIndex = 0;
            this.Btn_Seleccionar.Text = "Seleccionar archivo";
            this.Btn_Seleccionar.UseVisualStyleBackColor = true;
            this.Btn_Seleccionar.Click += new System.EventHandler(this.Btn_Upload_Click);
            // 
            // Txt_Archivo
            // 
            this.Txt_Archivo.Enabled = false;
            this.Txt_Archivo.Location = new System.Drawing.Point(12, 28);
            this.Txt_Archivo.Name = "Txt_Archivo";
            this.Txt_Archivo.Size = new System.Drawing.Size(535, 20);
            this.Txt_Archivo.TabIndex = 1;
            // 
            // Cbx_Modulo
            // 
            this.Cbx_Modulo.FormattingEnabled = true;
            this.Cbx_Modulo.Location = new System.Drawing.Point(12, 85);
            this.Cbx_Modulo.Name = "Cbx_Modulo";
            this.Cbx_Modulo.Size = new System.Drawing.Size(270, 21);
            this.Cbx_Modulo.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(297, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Módulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aplicación";
            // 
            // Btn_Upload
            // 
            this.Btn_Upload.Location = new System.Drawing.Point(127, 131);
            this.Btn_Upload.Name = "Btn_Upload";
            this.Btn_Upload.Size = new System.Drawing.Size(118, 41);
            this.Btn_Upload.TabIndex = 6;
            this.Btn_Upload.Text = "Aceptar";
            this.Btn_Upload.UseVisualStyleBackColor = true;
            this.Btn_Upload.Click += new System.EventHandler(this.Btn_Upload_Click_1);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(349, 131);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(118, 41);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "Cancelar";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Upload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Cbx_Modulo);
            this.Controls.Add(this.Txt_Archivo);
            this.Controls.Add(this.Btn_Seleccionar);
            this.Name = "Form1";
            this.Text = "Subir reporte";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Seleccionar;
        private System.Windows.Forms.TextBox Txt_Archivo;
        private System.Windows.Forms.ComboBox Cbx_Modulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Upload;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}

