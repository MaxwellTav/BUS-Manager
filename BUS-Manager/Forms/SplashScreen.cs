using System;
using System.Windows.Forms;

namespace BUS_Manager
{
    public partial class SplashScreen : Form
    {
        #region Useless

        public SplashScreen() { InitializeComponent(); }

        #endregion

        #region Variables

        Random RNG = new Random();  //Variable la cual la reutilizo para el azar del programa.
        bool _UseAnims = true;     //En caso de no querer usar una animación, apague esta variable (Marcar como "false" en donde dice "true")

        #endregion

        #region Funciones

        #region Animaciones

        /// <summary>
        /// Animación de la barra de carga que muestra el porcentaje.
        /// Esta función da feedback de que la animación está avanzando.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        void BarAnim(object sender, EventArgs ev)
        {
            if (_UseAnims)
            {
                try
                {
                    if (ProgressBar.Value < 95) { ProgressBar.Value += RNG.Next(0, 6); }
                    else { AnimeUsedAssets(); }
                }
                catch (Exception Error) { MessageBox.Show("Ha ocurrido un error fatal.\n\nCódigo del error:\n" + Error.HResult + "\n\nDetlles del error:\n" + Error.Message); }
            }
            else { AnimeUsedAssets(); }
        }

        /// <summary>
        /// Animación de entrada de desvanecimiento del formulario.
        /// Esta función cumple con el proposito del nombre, incrementando el valor
        /// "Opacity" (opacidad) del formulario dandole un toque de profesionalismo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        void FadeAnim(object sender, EventArgs ev)
        {
            try
            {
                if (Opacity <= 0.9f && _UseAnims) { Opacity += 0.0125f; }
                else { Opacity = 1; }
            }
            catch (Exception Error) { MessageBox.Show("Ha ocurrido un error fatal.\n\nCódigo del error:\n" + Error.HResult + "\n\nDetlles del error:\n" + Error.Message); }
        }

        /// <summary>
        /// Esta función es la que se encarga de detener los procesos que indican que
        /// hay una animación de carga.
        /// </summary>
        void AnimeUsedAssets()
        {
            //Configuración de cuando se completa la "carga".
            BarAnimation.Enabled = false;
            Indicator_LoadingIndicator.Visible = false;
            ProgressBar.Value = 100;

            Forms.MainForm mainForm = new Forms.MainForm(); //Creando instancia del Formulario.
            mainForm.Show(); //Mostrando la instancia del Formulario ya creado.
            Visible = false; //ocultando el formulario actual
        }

        #endregion

        //-----------------------Funcion "Al iniciar"-----------------------\\
        /// <summary>
        /// Esta función se asegura que todo esté normalizado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        void SplashScreen_Load(object sender, EventArgs ev)
        {
            ProgressBar.Value = 0;
            Indicator_LoadingIndicator.Visible = true;

            ///<Sumary> Esta función dice lo siguiente:
            ///Si en las configuraciones está guardada como
            ///"true" la variable la cual se encarga de administrar
            ///el uso o no de la animación, pues que active la casilla
            ///que hay en el formulario y use la animación.
            ///En caso contrario, baraja duríiiisimo.
            ///</Sumary>
            if (Properties.Settings.Default.UseAnimAgain_Value)
            { _UseAnims = true; UseAnimAgain_Bool.Checked = true;  }
            else
            { _UseAnims = false; UseAnimAgain_Bool.Checked = false; }

        }

        /// <summary>
        /// En esta función se está guardando la variable que se encarga de
        /// usar o no la animación de inicio, para así poder saltarla sin tener
        /// que acceder al código.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        void SaveThisFormAnim(object sender, EventArgs ev)
        {
            if (UseAnimAgain_Bool.Checked)
                Properties.Settings.Default.UseAnimAgain_Value = true;
            else
                Properties.Settings.Default.UseAnimAgain_Value = false;

            Properties.Settings.Default.Save();
        }

        #endregion
    }
}
