
namespace BUS_Manager
{
    partial class SplashScreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FadeIn_Timer = new System.Windows.Forms.Timer(this.components);
            this.Title1_Label = new System.Windows.Forms.Label();
            this.Title2_Label = new System.Windows.Forms.Label();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Indicator_LoadingIndicator = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.Form_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.BarAnimation = new System.Windows.Forms.Timer(this.components);
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // FadeIn_Timer
            // 
            this.FadeIn_Timer.Enabled = true;
            this.FadeIn_Timer.Interval = 1;
            this.FadeIn_Timer.Tick += new System.EventHandler(this.FadeAnim);
            // 
            // Title1_Label
            // 
            this.Title1_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title1_Label.AutoSize = true;
            this.Title1_Label.BackColor = System.Drawing.Color.Transparent;
            this.Title1_Label.Enabled = false;
            this.Title1_Label.Font = new System.Drawing.Font("Ubuntu", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1_Label.Location = new System.Drawing.Point(245, 162);
            this.Title1_Label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Title1_Label.Name = "Title1_Label";
            this.Title1_Label.Size = new System.Drawing.Size(159, 79);
            this.Title1_Label.TabIndex = 0;
            this.Title1_Label.Text = "BUS";
            this.Title1_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title2_Label
            // 
            this.Title2_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title2_Label.AutoSize = true;
            this.Title2_Label.BackColor = System.Drawing.Color.Transparent;
            this.Title2_Label.Enabled = false;
            this.Title2_Label.Font = new System.Drawing.Font("Ubuntu", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2_Label.Location = new System.Drawing.Point(366, 221);
            this.Title2_Label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Title2_Label.Name = "Title2_Label";
            this.Title2_Label.Size = new System.Drawing.Size(302, 79);
            this.Title2_Label.TabIndex = 1;
            this.Title2_Label.Text = "Manager";
            this.Title2_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.ProgressBar.Location = new System.Drawing.Point(0, 453);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.ProgressBar.ShadowDecoration.Parent = this.ProgressBar;
            this.ProgressBar.ShowPercentage = true;
            this.ProgressBar.Size = new System.Drawing.Size(897, 15);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 2;
            this.ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ProgressBar.UseTransparentBackground = true;
            // 
            // Indicator_LoadingIndicator
            // 
            this.Indicator_LoadingIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Indicator_LoadingIndicator.AnimationSpeed = 90;
            this.Indicator_LoadingIndicator.AutoStart = true;
            this.Indicator_LoadingIndicator.BackColor = System.Drawing.Color.Transparent;
            this.Indicator_LoadingIndicator.CircleSize = 1F;
            this.Indicator_LoadingIndicator.Enabled = false;
            this.Indicator_LoadingIndicator.Location = new System.Drawing.Point(843, 1);
            this.Indicator_LoadingIndicator.Name = "Indicator_LoadingIndicator";
            this.Indicator_LoadingIndicator.Size = new System.Drawing.Size(50, 50);
            this.Indicator_LoadingIndicator.TabIndex = 3;
            this.Indicator_LoadingIndicator.UseTransparentBackground = true;
            // 
            // Form_Drag
            // 
            this.Form_Drag.TargetControl = this;
            // 
            // BarAnimation
            // 
            this.BarAnimation.Enabled = true;
            this.BarAnimation.Tick += new System.EventHandler(this.BarAnim);
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.BorderRadius = 20;
            this.Form_Elipse.TargetControl = this;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(897, 468);
            this.Controls.Add(this.Indicator_LoadingIndicator);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Title1_Label);
            this.Controls.Add(this.Title2_Label);
            this.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "SplashScreen";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer FadeIn_Timer;
        private System.Windows.Forms.Label Title1_Label;
        private System.Windows.Forms.Label Title2_Label;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator Indicator_LoadingIndicator;
        private Guna.UI2.WinForms.Guna2DragControl Form_Drag;
        private System.Windows.Forms.Timer BarAnimation;
        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
    }
}

