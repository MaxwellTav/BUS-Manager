using System;
using System.Drawing;
using System.Windows.Forms;

namespace BUS_Manager.Forms.SubForms
{
    public partial class RegisterVehicleForm : Form
    {
        #region Useless
        public RegisterVehicleForm() { InitializeComponent(); }
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
                    ShowMessage("¿Los datos son correctos?",
                        "Marca: " + MarkVehicle_Textbox.Text + "\n" +
                        "Modelo: " + ModelVehicle_Textbox.Text + "\n" +
                        "Placa: " + IDVehicle_Textbox.Text + "\n" +
                        "Color: " + ColorVehicle_Textbox.Text + "\n" +
                        "Año: " + YearVehicle_Textbox.Text

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
                MarkVehicle_Textbox.Text = "";
                ModelVehicle_Textbox.Text = "";
                IDVehicle_Textbox.Text = "";
                ColorVehicle_Textbox.Text = "";
                YearVehicle_Textbox.Text = "";

                CurrentColorVehicle_Color.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        /// <summary>
        /// Esta función se encargará de elegir el color para el vehículo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPicker_Button_Click(object sender, EventArgs e)
        {
            ColorPicker.ShowDialog();

            CurrentColorVehicle_Color.BackColor = ColorPicker.Color;
            ColorVehicle_Textbox.Text = ColorPicker.Color.ToString();
        }
        #endregion
    }
}
