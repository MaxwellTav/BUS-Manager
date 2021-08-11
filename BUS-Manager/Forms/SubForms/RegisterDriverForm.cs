using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BUS_Manager.Forms.SubForms
{
    public partial class RegisterDriverForm : Form
    {
        #region Useless
        public RegisterDriverForm() { InitializeComponent(); }
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
                        Rezize_Button.Checked = false;
                        ShowMessage("¡Opción no valida!", "Esta opción no está permitida en ese formulario", 1, true);
                        break;
                }
                //Lo que hace que el ciclo no se repita más veces, si ya
                //encontró lo que buscaba.
                break;
            }
        }

        /// <summary>
        /// Esta función se ejecutará al iniciar la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterDriverForm_Load(object sender, EventArgs e)
        {
            //Poner el día acutal.
            DateBornDriver_Picker.Value = DateTime.Now;
        }

        #region Cédula.
        private void IdentificationDriver_Textbox_TextChanged(object sender, EventArgs e)
        {
            List<string> listString = new List<string>();
            string FinalTextID = string.Empty;

            if (IdentificationDriver_Textbox.Text.Length == 11)
            {
                string _Text = IdentificationDriver_Textbox.Text;

                foreach (Char c in _Text)
                    listString.Add(c.ToString());

                for (int i = 0; i < listString.Count; i++)
                {
                    if ((i == 3) || (i == 10))
                        FinalTextID += "-";

                    FinalTextID += listString[i];
                }

                IdentificationDriver_Textbox.Text = FinalTextID;
            }
        }
        #endregion

        #region Restricciones
        //Restricciones Cédula (Restricción de dígitos).
        private void IdentificationDriver_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }

        //Restricciones Cédula (Cuando presiona atras que borre completamente el textbox)
        private void IdentificationDriver_Textbox_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Back) IdentificationDriver_Textbox.Text = string.Empty; }

        //Restricciones Nombre y Apellido (Evitar dígitos raros). 
        private void NameDriver_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        { e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar); }

        #endregion

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
                    ShowMessage("¿Los datos son correctos?",
                        "Nombre: " + NameDriver_Textbox.Text + "\n" +
                        "Apellidos: " + LastNDriver_Textbox.Text + "\n" +
                        "Natalidad: " + DateBornDriver_Picker.Value + "\n" +
                        "Cédula: " + IdentificationDriver_Textbox.Text
                        , 2, false);

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
                NameDriver_Textbox.Text = "";
                LastNDriver_Textbox.Text = "";
                IdentificationDriver_Textbox.Text = "";
                DateBornDriver_Picker.Value = DateTime.Now;
            }
        }
        #endregion
    }
}
