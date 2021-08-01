using System;
using System.Windows.Forms;

namespace BUS_Manager.Forms
{
    public partial class MainForm : Form
    {
        #region Useless
        public MainForm() { InitializeComponent(); }
        #endregion

        #region Variables

        MessageForm messageForm = new MessageForm();

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMessage("Hola", "¿Como estás?");
        }

        #region Eventos
        private void ShowMessage(string title, string body)
        {
            //Aplicando el texto.
            messageForm.Title = title;
            messageForm.Body = body;

            //Aplicando la animación.
            //Guna desactualizado...

            //Mostrando.
            messageForm.ShowDialog();
        }
        #endregion
    }
}
