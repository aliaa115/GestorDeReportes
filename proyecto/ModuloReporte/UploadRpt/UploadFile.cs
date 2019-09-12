using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

namespace UploadRpt
{
    public partial class UploadFile : Form
    {
        //String path = "C:\\tmp\\";
        private String[] nombre;
        private String fileUpload;
        public UploadFile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "allfiles|*.rpt";
            DialogResult result = openFileDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                this.fileUpload =  openFileDialog.FileName.ToString();
                this.nombre = fileUpload.Split('\\');
                Txt_Archivo.Text = this.nombre[nombre.Length - 1];
            }
        }

        private void upload(String fileUpload)
        {
            try
            {
                Uri uri = new Uri("ftp://192.168.43.134:22/home/usuarioftp/compartido" + this.nombre[nombre.Length - 1]);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("diegot", "diego123");
                request.PreAuthenticate = false;
                //request.ContentType = false;
                request.UseDefaultCredentials = false;
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;
                using (FileStream fs = File.OpenRead(this.fileUpload))
                {
                    byte[] buffer = new byte[fs.Length];
                    request.ContentLength = fs.Length;
                    fs.Read(buffer, 0, buffer.Length);
                    fs.Close();
                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(buffer, 0, buffer.Length);
                    requestStream.Flush();
                    requestStream.Close();
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error al subir");
            }
        }
        private void Btn_Upload_Click_1(object sender, EventArgs e)
        {
            
            //File.Copy(this.fileUpload, this.path + this.nombre[nombre.Length - 1]);
            try
            {
                upload(this.fileUpload);

                MessageBox.Show("Archivo subido");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error al subir");
            }
            
        }


    }
}
