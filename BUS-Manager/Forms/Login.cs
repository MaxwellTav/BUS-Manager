using System;
using System.Windows.Forms;

namespace BUS_Manager.Forms
{
    public partial class Login : Form
    {
        #region Useless
        public Login() { InitializeComponent(); }
        #endregion

        #region Variables

        MessageForm messageForm = new MessageForm();

        #endregion

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
