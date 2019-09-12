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
            openFileDialog.Filter = "allfiles | *.rpt";
            DialogResult result = openFileDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                this.fileUpload =  openFileDialog.FileName.ToString();
                this.nombre = fileUpload.Split('\\');
                Txt_Archivo.Text = this.nombre[nombre.Length - 1];
            }
        }

        private void upload(String filename)
        {
            //Uri uri = new Uri("ftp://192.168.43.243:22/");
            FileInfo fileInf = new FileInfo(filename);
            string uri = "ftp://" +
         "192.168.43.243:22" + " / " + fileInf.Name;
            FtpWebRequest reqFTP;

            // Create FtpWebRequest object from the Uri provided
            reqFTP =
         (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + "192.168.0.7" +
         "/" + fileInf.Name));

            // Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential("usuarioftp", "ftp");

            // By default KeepAlive is true, where the control connection is not closed
            // after a command is executed.
            reqFTP.KeepAlive = false;

            // Specify the command to be executed.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Specify the data transfer type.
            reqFTP.UseBinary = true;

            // Notify the server about the size of the uploaded file
            reqFTP.ContentLength = fileInf.Length;

            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read the file to be uploaded
            FileStream fs = fileInf.OpenRead();

            // Stream to which the file to be upload is written
            Stream strm = reqFTP.GetRequestStream();

            // Read from the file stream 2kb at a time
            contentLen = fs.Read(buff, 0, buffLength);

            // Till Stream content ends
            while (contentLen != 0)
            {
                // Write Content from the file stream to the FTP Upload Stream
                strm.Write(buff, 0, contentLen);
                contentLen = fs.Read(buff, 0, buffLength);
            }

            // Close the file stream and the Request Stream
            strm.Close();
            fs.Close();
            
        }

        private void Btn_Upload_Click_1(object sender, EventArgs e)
        {
            //File.Copy(this.fileUpload, this.path + this.nombre[nombre.Length - 1]);
            try
            {
                using (var client = new WebClient())
                {
                    client.Credentials = new NetworkCredential("usuarioftp", "ftp");
                    Uri uri = new Uri("ftp://192.168.43.243:22/");
                    client.UploadFile(uri, WebRequestMethods.Ftp.UploadFile, this.fileUpload);
                }

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
