using System;
using System.Windows.Forms;

namespace BUS_Manager.Forms.SubForms
{
    public partial class ViewVehicleForm : Form
    {
        #region Useless.
        public ViewVehicleForm() { InitializeComponent(); }
        #endregion

        #region Variables.
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

        #endregion

        /// <summary>
        /// Función que actualiza el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VoidUpdate_Tick(object sender, EventArgs e)
        {
            Driver_DataGridView.Refresh();
            Driver_DataGridView.Update();
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
        #endregion
    }
}
