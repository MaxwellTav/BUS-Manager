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

        #region Mensaje
        /// <summary>
        /// Esta función es la que se llamará si quiero mandar un mensaje customizado
        /// La misma función se encarga de que si ocurre un error pues que muestre
        /// el mismo mensaje, pero con el predeterminado de windows.
        /// En caso de que tampoco pueda, pues... que muestre en otro mensaje (predeterminado)
        /// del error.
        /// </summary>
        /// <param name="_title"></param>
        /// <param name="_body"></param>
        /// <param name="_NoButtons"></param>
        private void ShowMessage(string _title, string _body, int _NoButtons)
        {
            //Aplicando el texto.
            messageForm.Title = _title;
            messageForm.Body = _body;
            messageForm.NoButtons = _NoButtons;

            //Aplicando la animación.
            //Guna desactualizado...

            //Mostrando.
            messageForm.ShowDialog();
        }
        #endregion

        /// <summary>
        /// Esta función se llamará cuando el formulario se termine de cargar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        { ShowMessage("Saludos...", "Bienvenido, inicié sesión con sus credenciales para comenzar\n\nEste y las demás cajas de mensajes aparecerán en la posición del ratón (Mouse).", 1); }

        #endregion
    }
}
