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
        private void SplashScreen_Load(object sender, EventArgs ev)
        { ProgressBar.Value = 0; Indicator_LoadingIndicator.Visible = true; }

        #endregion
    }
}
