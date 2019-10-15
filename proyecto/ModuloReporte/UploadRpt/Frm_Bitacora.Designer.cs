namespace UploadRpt
{
    partial class Frm_Bitacora
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
            this.Btn_ImpRpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ImpRpt
            // 
            this.Btn_ImpRpt.Location = new System.Drawing.Point(153, 86);
            this.Btn_ImpRpt.Name = "Btn_ImpRpt";
            this.Btn_ImpRpt.Size = new System.Drawing.Size(267, 142);
            this.Btn_ImpRpt.TabIndex = 0;
            this.Btn_ImpRpt.Text = "Reporte Bitacora";
            this.Btn_ImpRpt.UseVisualStyleBackColor = true;
            this.Btn_ImpRpt.Click += new System.EventHandler(this.Btn_ImpRpt_Click);
            // 
            // Frm_Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_ImpRpt);
            this.Name = "Frm_Bitacora";
            this.Text = "Frm_Bitacora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ImpRpt;
    }
}