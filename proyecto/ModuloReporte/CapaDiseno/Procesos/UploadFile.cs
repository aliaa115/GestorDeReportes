using System;
using System.Windows.Forms;
using System.IO;

namespace CapaDisenoRpt.Procesos
{
    class UploadFile
    {
        public UploadFile(String file, String ruta)
        {
            String[] nombre = file.Split('\\');
            try
            {
                File.Copy(file, ruta + nombre[nombre.Length - 1]);
                MessageBox.Show("Archivo subido");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error al subir");
            }
        }
    }
}
