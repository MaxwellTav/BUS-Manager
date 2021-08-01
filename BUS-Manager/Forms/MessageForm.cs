using System;
using System.Windows.Forms;

namespace BUS_Manager.Forms
{
    public partial class MessageForm : Form
    {
        #region Useless
        public MessageForm() { InitializeComponent(); }
        #endregion

        #region Variables

        public string Title, Body;
        public int NoButtons;

        public int SecondLeft = 10; //Variable que se utiliza para contar cuando se cerrará automaticamente el mensaje.

        #endregion

        #region Events
        /// <summary>
        /// Esta función hace que se muestre el mensaje en pantalla customizada,
        /// en caso de que no pueda mostrar el mensaje, pues que lo muestre de la manera
        /// ambigua, y en caso de que tampoco pueda, pues muestre el error específico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageForm_Load(object sender, EventArgs e)
        {
            //Configuración inicial para evitar BUGS.
            BodyMessage_Label.Text = "BodyMessage_Label error";
            TitleMessage_Label.Text = "TitleMessage_Label error";
            Yes_Button.Text = "Si - 10";
            No_Button.Text = "No";
            AutomaticlyCloseMessage_Timer.Enabled = true;
            SecondLeft = 10;

            //Que la posición del mensaje sea la posición del mouse.
            Location = new System.Drawing.Point(Cursor.Position.X - 225, Cursor.Position.Y);

            #region Test
            //Body = "¿Está seguro que este es un cuerpo de mensaje?";
            //Title = "¿Éstá seguro que este es un titulo de mensaje?";
            //NoButtons = 5;
            #endregion

            //Esta es la manera que hay que llamar la función para mostrar el mensaje.
            ShowMessage(Body, Title, NoButtons);
        }

        /// <summary>
        /// El evento más importante de este formulario y probablemente
        /// del programa completo.
        /// </summary>
        /// <param name="_Body"></param>
        /// <param name="_Title"></param>
        /// <param name="HowManyBtns"></param>
        public void ShowMessage(string _Body, string _Title, int HowManyBtns)
        {
            //Intenta mostrar el mensaje de manera customizada.
            try
            {
                BodyMessage_Label.Text = _Body;
                TitleMessage_Label.Text = _Title;

                switch (HowManyBtns)
                {
                    case 1:
                        Yes_Button.Size = new System.Drawing.Size(457, 45);
                        Yes_Button.Text = "Ok";
                        No_Button.Visible = false;
                        break;

                    default:
                        Yes_Button.Size = new System.Drawing.Size(228, 45);
                        No_Button.Visible = true;
                        break;
                }
            }
            //Si no se puede mostrar el mensaje de manera customizada,
            //pues intenta hacerla del modo tradicional.
            catch
            {
                try
                {
                    MessageBoxButtons _botones = new MessageBoxButtons();

                    switch (HowManyBtns)
                    {
                        case 1:
                            _botones = MessageBoxButtons.OK;
                            break;

                        case 2:
                            _botones = MessageBoxButtons.YesNo;
                            break;
                    }

                    MessageBox.Show(_Body, _Title, _botones);
                }
                catch (Exception Error)
                { MessageBox.Show("Ha ocurrido un error fatal\n\nDetalles del error: " + Error.Message, Error.HResult.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        /// <summary>
        /// En esta función se está decreciendo la variable "SecondLeft" cada
        /// segundo. (1 seg = 1000 milesimas).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutomaticlyCloseMessage_Timer_Tick(object sender, EventArgs e)
        {
            if (SecondLeft > 0)
            {
                SecondLeft--;
                Yes_Button.Text = ("Si - " + SecondLeft);
            }
            else
                Output(DialogResult.No);
        }

        /// <summary>
        /// Esta es la función que finaliza todo.
        /// </summary>
        /// <param name="_output"></param>
        private void Output(DialogResult _output)
        { DialogResult = _output; Close(); }

        #endregion

        #region Botones
        /// <summary>
        /// Boton ok el cual es si.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Yes_Button_Click(object sender, EventArgs e)
        {
            AutomaticlyCloseMessage_Timer.Enabled = false;
            Output(DialogResult.OK);
        }

        /// <summary>
        /// Botón no.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void No_Button_Click(object sender, EventArgs e)
        {
            AutomaticlyCloseMessage_Timer.Enabled = false;
            Output(DialogResult.No);
        }
        #endregion
    }
}
