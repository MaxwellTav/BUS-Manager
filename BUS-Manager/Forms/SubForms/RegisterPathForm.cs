using System;
using System.Windows.Forms;

namespace BUS_Manager.Forms.SubForms
{
    public partial class RegisterPathForm : Form
    {
        #region Useless
        public RegisterPathForm() { InitializeComponent(); }
        #endregion

        #region Variables
        private MessageForm MForm;
        #endregion

        #region Funciones.

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
        void ShowMessage(string _title, string _body, int _NoButtons, bool _sec)
        {
            //Creando la instancia.
            MessageForm messageForm = new MessageForm();

            //Aplicando el texto.
            messageForm.Title = _title;
            messageForm.Body = _body;
            messageForm.NoButtons = _NoButtons;
            messageForm.Sec = _sec;

            //Mostrando.
            try
            { messageForm.ShowDialog(); }
            catch (Exception error) { MessageBox.Show("Ha ocurrido un error:\n" + error.Message, "Código del error: " + error.HResult, MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //Salida.
            MForm = messageForm;
        }

        void ThrowAnError(Exception error)
        { ShowMessage("¡Error #" + error.HResult + "!", "Ha ocurrido un error\n" + error.Message, 1, true); }

        #endregion

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
                        ShowMessage("¡Está saliendo del formulario!", "¿Está seguro que desea salir del formulario actual?", 2, false);
                        if (MForm.DialogResult == DialogResult.OK)
                            Close();
                        break;

                    //En caso de Botón de minimizar.
                    case "Minimize_Button":
                        WindowState = FormWindowState.Minimized;
                        break;

                    //En caso de Botón de maximizar.
                    case "Rezize_Button":
                        if (Rezize_Button.Checked)
                            WindowState = FormWindowState.Maximized;
                        else
                            WindowState = FormWindowState.Normal;
                        break;
                }
                //Lo que hace que el ciclo no se repita más veces, si ya
                //encontró lo que buscaba.
                break;
            }
        }

        /// <summary>
        /// Esta función es la que se encarga de eliminar o guardar la información.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BottomButtons(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientButton btn = (Guna.UI2.WinForms.Guna2GradientButton)sender;

            switch (btn.Name)
            {
                //Botón borrar.
                case "Cancel_Button":
                    EraseAll();
                    ShowMessage("¡Datos borrados!", "Los datos del formulario actual han sido borrados.", 1, true);
                    break;

                //Botón guardar.
                case "Save_Button":

                    ShowMessage("¿Quiere insertar esta ruta?", "Ruta: " + Path_Textbox.Text, 2, false);
                    if (MForm.DialogResult == DialogResult.OK)
                    {
                        try
                        {
                            #region Código Plinio



                            #endregion

                            EraseAll();
                            ShowMessage("¡Guardado!", "¡Datos guardados con exito!", 1, true);
                        }
                        catch (Exception error) { ShowMessage("¡Error #" + error.HResult + "!", "Ha ocurrido un error\n" + error.Message, 1, true); }
                    }
                    break;
            }

            void EraseAll()
            {
                /*Había un código más optimizado, pero Visual Studio parece no querer cooperar.*/
                Path_Textbox.Text = "";
            }
        }

        /// <summary>
        /// Esta función se ejecutará al momento despues de visualizar por primera vez el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterPathForm_Shown(object sender, EventArgs e)
        { ShowMessage("ATENCIÓN", "Por favor, no interactue con el mapa que está visualizando, es solo informativo, no operativo.", 1, true); }

        /// <summary>
        /// Esta función se encargará de buscar una ubicación en maps.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Path_Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SeachInWebView();
        }

        /// <summary>
        /// Esta función es la que se encarga de buscar en internet
        /// </summary>
        void SeachInWebView()
        {
            string finalUrl = "https://www.google.com.do/maps/search/" + Path_Textbox.Text;

            try
            //Se espera lo siguiente: https://www.google.com.do/maps/search/
            {
                if (finalUrl != MapView_WebBrowser.Url.ToString())
                    MapView_WebBrowser.Navigate(finalUrl);
            }
            catch (Exception error)
            { ThrowAnError(error); }
        }

        #region WebView
        //Está buscando algo.
        private void MapView_WebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        { WebLoading_Indicator.Visible = true; }

        //Ya terminó la busqueda.
        private void MapView_WebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        { WebLoading_Indicator.Visible = false; }

        //Botón buscar
        private void Search_Button_Click(object sender, EventArgs e)
        { SeachInWebView(); }
        #endregion

        #endregion
    }
}
