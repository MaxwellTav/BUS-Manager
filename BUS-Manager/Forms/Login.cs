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

        Form MForm = new Form();
        
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
        void ShowMessage(string _title, string _body, int _NoButtons, bool _sec, string BienvenidaBtn = null)
        {
            //Creando la instancia.
            MessageForm messageForm = new MessageForm();

            //Aplicando el texto.
            messageForm.Title = _title;
            messageForm.Body = _body;
            messageForm.NoButtons = _NoButtons;
            messageForm.Sec = _sec;

            if (BienvenidaBtn != string.Empty || BienvenidaBtn != null)
                messageForm.Yes_Button.Text = BienvenidaBtn;

            //Mostrando.
            try
            { messageForm.ShowDialog(); }
            catch (Exception error) { MessageBox.Show("Ha ocurrido un error: " + error.Message); }

            //Salida.
            MForm = messageForm;
        }
        #endregion

        /// <summary>
        /// Esta función se llamará cuando el formulario se termine de cargar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Login_Load(object sender, EventArgs e)
        {
            ShowMessage("Saludos...", "Bienvenido, inicié sesión con sus credenciales para comenzar\n\nEste y las demás cajas de mensajes aparecerán en la posición del ratón (Mouse).", 1, true, "¡Perfecto!");
        }


        /// <summary>
        /// Esta función es la que permite al usuario minimizar, maximizar y
        /// salir de la aplicación dependiendo al botón que se presione.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        void FormControl(object sender, EventArgs ev)
        {
            //Creando instancia del objeto.
            Control ctrl = (Control)sender;

            //Conociendo el botón que se presionó.
            foreach (Control control in Controls)
            {
                switch (ctrl.Name)
                {
                    //En caso de salir de la aplicación.
                    case "Exit_Button":
                        ShowMessage("¡Está saliendo de la aplicación!", "¿Está seguro que desea salir de la aplicación?", 2, false);
                        if (MForm.DialogResult == DialogResult.OK)
                            Application.Exit();
                        break;

                    //En caso de Botón de minimizar.
                    case "Minimize_Button":
                        WindowState = FormWindowState.Minimized;
                        break;

                    //En caso de Botón de maximizar.
                    case "Rezize_Button":
                        Rezize_Button.Checked = false;
                        ShowMessage("¡Opción no valida!", "Esta opción no está permitida en ese formulario", 1, true);
                        break;
                }
                //Lo que hace que el ciclo no se repita más veces, si ya
                //encontró lo que buscaba.
                break;
            }
        }

        void LoginEvent(object sender, EventArgs ev)
        {
            #region Login con variables estáticas
            


            #endregion

            #region Funcion con SQL

            #endregion
        }

        #endregion

    }
}
