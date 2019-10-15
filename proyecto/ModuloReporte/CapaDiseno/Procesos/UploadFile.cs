using System;
using System.Windows.Forms;
using System.IO;

namespace CapaDisenoRpt.Procesos
{
    class UploadFile
    {
        private String ruta;
        private String nombre;
        public UploadFile(String nombre, String ruta)
        {
            this.ruta = ruta;
            this.nombre = nombre;
        }

        public void insertFile(String source) 
        {
            try
            {
                File.Copy(source, ruta + nombre);
                MessageBox.Show("Archivo subido");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error al subir.");
            }
        }

        public void modifyFile(String source)
        {
            try
            {
                if (existFile())
                {
                    File.Delete(ruta + nombre);
                    File.Copy(source, ruta + nombre);
                }
                else
                {
                    File.Copy(source, ruta + nombre);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar.");
            }
        }

        public void deleteFile()
        {
            try
            {
               File.Delete(ruta + nombre);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar.");
            }
        }

        public bool existFile()
        {
            return File.Exists(ruta + nombre);
        }
    }
}
