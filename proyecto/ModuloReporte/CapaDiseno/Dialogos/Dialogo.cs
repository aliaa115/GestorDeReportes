using System;
using System.Windows.Forms;

namespace CapaDisenoRpt.Dialogos
{
    public class Dialogo
    {
        public bool dialogoSiNo(String texto, String titulo)
        {
            var resultado = MessageBox.Show(titulo, texto,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return resultado == DialogResult.Yes ? true : false;
        }

        public void dialogoAdvertencia(String texto, String titulo)
        {
            var resultado = MessageBox.Show(titulo, texto,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
