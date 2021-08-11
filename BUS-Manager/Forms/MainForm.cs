using BUS_Manager.Forms.SubForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BUS_Manager.Forms
{
    public partial class MainForm : Form
    {
        #region Useless
        public MainForm() { InitializeComponent(); }
        #endregion

        #region Variables
        //Formulario para pasar la salida de la respuesta.
        Form MForm = new Form();

        //Colores de los botones.
        Color ButtonOriginalColor = new Color()
            , ButtonSelectedColor = new Color();
        int _R, _G, _B;
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
        /// Función que se ejecuta la iniciar el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Tamaño de ventana

            if (Size.Width < Screen.PrimaryScreen.Bounds.X || Size.Height < Screen.PrimaryScreen.Bounds.Y)
            {
                MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
                Size = MaximumSize;
                Location = new Point(0, 0);
            }

            #endregion

            #region Funcionalidad del scrollbar
            //var Scr_Helper = new Guna.UI2.WinForms.Helpers.PanelScrollHelper(Menu_Panel, LeftPanel_ScrollBar, true);
            //Scr_Helper.UpdateScrollBar();
            #endregion

            #region Visibilidad de UserControls

            foreach (Panel c in Controls)
                if (c.Tag == "UserC")
                {
                    c.Location = new Point(298, 28);
                    c.Visible = false;
                }

            View_Panel.Visible = true;

            #endregion

            #region Color de los botónes.
            //referencia de un color (el primer color).
            ButtonOriginalColor = NavView_Button.FillColor;

            _R = (ButtonOriginalColor.R - 30);
            _B = (ButtonOriginalColor.B - 30);
            _G = (ButtonOriginalColor.G - 30);

            //Iniciando como predeterminado y seleccionado el botón.
            NavView_Button.FillColor = Color.FromArgb(_R, _G, _B);
            #endregion
        }

        /// <summary>
        /// Esta función controla que formulario se abrirá al cliquear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DriversView_Button_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientButton btn = (Guna.UI2.WinForms.Guna2GradientButton)sender;
            switch (btn.Name)
            {
                //----------------Vistas----------------\\
                #region Ver Conductores.
                case "DriversView_Button":
                    ViewDriverForm viewDriver = new ViewDriverForm();
                    viewDriver.ShowDialog();
                    break;
                #endregion

                #region Ver Vehiculos.
                //Al clickar en vehiculos.
                case "VehiclesView_Button":
                    ViewVehicleForm viewVehicle = new ViewVehicleForm();
                    viewVehicle.ShowDialog();
                    break;
                #endregion

                #region Ver Rutas.
                //Al clickar en Rutas.
                case "PathView_Buttons":
                    ViewPathForm viewPath = new ViewPathForm();
                    viewPath.ShowDialog();
                    break;
                #endregion


                //---------------Registros---------------\\
                #region Registrar Conductores.
                case "DriversRegister_Button":
                    RegisterDriverForm registerDriver = new RegisterDriverForm();
                    registerDriver.ShowDialog();
                    break;
                #endregion

                #region Registrar Vehiculos.
                case "VehicleRegister_Button":
                    RegisterVehicleForm registerVehicle = new RegisterVehicleForm();
                    registerVehicle.ShowDialog();
                    break;
                #endregion

                #region Registrar Rutas.
                case "PathRegister_Button":
                    RegisterPathForm registerPath = new RegisterPathForm();
                    registerPath.ShowDialog();
                    break;
                #endregion

                #region Relacionar.
                case "CreateRelations_Button":
                    MatchEntitiesForm matchEntities = new MatchEntitiesForm();
                    matchEntities.ShowDialog();
                    break;
                    #endregion
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
        /// Esta función es la que se encarga de la navegación de los botones del menú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        void ViewNavFunction(object sender, EventArgs ev)
        {
            //Declarando Variables
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;

            try { ButtonSelectedColor = Color.FromArgb(_R, _G, _B); }
            catch (Exception error) { ShowMessage("Ha ocurrido un error grave", "Error:\n" + error.Message, 1, true); }

            switch (btn.Name)
            {
                //Botón de vista.
                case "NavView_Button":
                    OnOffSubEvent(View_Panel);
                    break;

                //Botón de registro.
                case "NavRegister_Button":
                    OnOffSubEvent(Register_Panel);
                    break;

                default:
                    ShowMessage("Excepción no necesaria", "Esta función de la aplicación no fue programada porque no se necesita y/o no se pidió.", 1, true);
                    break;
            }

            void OnOffSubEvent(Panel _panel)
            {
                _panel.Visible = true;
                _panel.Enabled = true;
                _panel.BringToFront();

                #region Volver a la normalidad (Para evitar Bug).
                ///Código original.
                //foreach (Guna.UI2.WinForms.Guna2Button button in Menu_Panel.Controls)
                //    if (button is Guna.UI2.WinForms.Guna2Button)
                //        button.FillColor = ButtonOriginalColor;

                NavView_Button.FillColor = ButtonOriginalColor;
                NavRegister_Button.FillColor = ButtonOriginalColor;
                NavOutput_Button.FillColor = ButtonOriginalColor;
                NavConfiguration_Button.FillColor = ButtonOriginalColor;
                NavSupport_Button.FillColor = ButtonOriginalColor;
                NavHelp_Button.FillColor = ButtonOriginalColor;
                #endregion

                btn.FillColor = ButtonSelectedColor;
            }
        }

        /// <summary>
        /// Esta función se ejecutará cuando el formulario se muestre por primera vez.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            //Mensaje de bienvenida
            ShowMessage("¡Está en el formulario principal!", "Bienvenido a \"BUS Manager\"\n\n¿Qué quiere hacer?\n\nSeleccione una opción para comenzar.", 1, true);
        }


        #endregion
    }
}
