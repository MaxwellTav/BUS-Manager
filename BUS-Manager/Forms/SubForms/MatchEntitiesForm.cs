using System;
using System.Drawing;
using System.Windows.Forms;

namespace BUS_Manager.Forms.SubForms
{
    public partial class MatchEntitiesForm : Form
    {
        #region Useless
        public MatchEntitiesForm() { InitializeComponent(); }
        #endregion

        #region Variables
        private MessageForm MForm;
        #endregion

        #region Funciones

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
        /// Función al cargar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MatchEntitiesForm_Load(object sender, EventArgs e)
        {
            RestoreAll(PanelSelection);
        }

        #region Navegación
        private void RestoreAll(Control _control)
        {
            try
            {
                foreach (Control c in Controls)
                    if (c is Panel)
                    {
                        c.Location = new Point(0, 48);
                        c.Visible = false;
                        c.Enabled = false;
                    }

                if (_control != null)
                {
                    _control.Visible = true;
                    _control.Enabled = true;
                    _control.BringToFront();
                }
            }
            catch { }
        }

        //Ir a creación de entidades.
        private void GoToCreate_Click(object sender, EventArgs e)
        { RestoreAll(PanelMatch); }

        //Ir a borrar entidades.
        private void GoToDelete_Click(object sender, EventArgs e)
        { RestoreAll(PanelDelete); }

        //Atras (Borrar)
        private void BackDelete_Button_Click(object sender, EventArgs e)
        { RestoreAll(PanelSelection); }

        //Atras (Crear)
        private void BackCreate_Button_Click(object sender, EventArgs e)
        { RestoreAll(PanelSelection); }

        //Ayuda
        private void Help_Button_Click(object sender, EventArgs e)
        { ShowMessage("¡Ayuda!", "Seleccione las entidades que quiera relacionar?\n\n¿Cuál conductor?\n¿Cuál vehículo\n¿Cuál ruta?\nLuego presione \"Relacionar\"", 1, true); }
        #endregion

        /// <summary>
        /// Esta función se ejecutará cada 1 segundo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VoidUpdate_Tick(object sender, EventArgs e)
        {
            #region Código obsoleto
            //Actualizar(Driver_DataGridView);
            //Actualizar(Vehicle_DataGridView);
            //Actualizar(Path_DataGridView);
            //Actualizar(Relations_DataGrid);
            #endregion

            try
            {
                foreach (Guna.UI2.WinForms.Guna2DataGridView c in PanelDelete.Controls)
                { Actualizar(c); }

                foreach (Guna.UI2.WinForms.Guna2DataGridView c in PanelMatch.Controls)
                { Actualizar(c); }
            }
            catch { }


            /// <summary>
            /// Sub función que recibe el control del DataGrid y lo
            /// actualiza en el proceso.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void Actualizar(Guna.UI2.WinForms.Guna2DataGridView _Grid)
            {
                try
                {
                    _Grid.Update();
                    _Grid.Refresh();
                }
                catch { }
            }
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
        #endregion

        /// <summary>
        /// Botón "Relacionar".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done_Button_Click(object sender, EventArgs e)
        {
            try
            {
                ShowMessage("¿Quiere relacionar la siguiente entrada?",
                    "Chofer: " + Driver_DataGridView.SelectedCells.ToString() + "\n" +
                    "Vehículo: " + Vehicle_DataGridView.SelectedCells.ToString() + "\n" +
                    "Ruta: " + Path_DataGridView.SelectedCells.ToString()
                    , 2, false);

                //Si acepta todo lo anterior, pues que guarde.
                if (MForm.DialogResult == DialogResult.OK)
                {
                    #region Código Plinio.

                    #endregion

                    ShowMessage("¡Exito!", "¡Datos guardados correctamente!", 1, true);
                }
            }
            catch { }
        }

        /// <summary>
        /// Botón "Eliminar".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            ShowMessage("¡Está punto de eliminar el siguiente dato!",
                Relations_DataGrid.SelectedCells.ToString() + "\n¿Está seguro que quiere eliminar este dato?"
                , 2, false);

            if (MForm.DialogResult == DialogResult.OK)
                ShowMessage("¡Éxito!", "¡El dato se ha eliminado con éxito!", 1, true);
        }
    }
}
