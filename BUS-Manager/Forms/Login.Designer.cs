
namespace BUS_Manager.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Minimize_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Rezize_Button = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Form_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Background_Picture = new System.Windows.Forms.PictureBox();
            this.Login_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.NewAccount_Button = new System.Windows.Forms.Label();
            this.Login_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.User_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.SeePass_Button = new System.Windows.Forms.PictureBox();
            this.Pass_Picture = new System.Windows.Forms.PictureBox();
            this.Pass_Label = new System.Windows.Forms.Label();
            this.Pass_Separator = new Guna.UI2.WinForms.Guna2Separator();
            this.User_Picture = new System.Windows.Forms.PictureBox();
            this.User_Label = new System.Windows.Forms.Label();
            this.User_Separator = new Guna.UI2.WinForms.Guna2Separator();
            this.ForgotPass_Button = new System.Windows.Forms.Label();
            this.Loading_Indicator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.Background_Picture)).BeginInit();
            this.Login_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeePass_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.Animated = true;
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.CheckedState.Parent = this.Exit_Button;
            this.Exit_Button.CustomImages.Parent = this.Exit_Button;
            this.Exit_Button.FillColor = System.Drawing.Color.Red;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.HoverState.Parent = this.Exit_Button;
            this.Exit_Button.Location = new System.Drawing.Point(807, 4);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(18, 18);
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.UseTransparentBackground = true;
            this.Exit_Button.Click += new System.EventHandler(this.FormControl);
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.BorderRadius = 15;
            this.Form_Elipse.TargetControl = this;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Animated = true;
            this.Minimize_Button.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_Button.CheckedState.Parent = this.Minimize_Button;
            this.Minimize_Button.CustomImages.Parent = this.Minimize_Button;
            this.Minimize_Button.FillColor = System.Drawing.Color.Silver;
            this.Minimize_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimize_Button.ForeColor = System.Drawing.Color.White;
            this.Minimize_Button.HoverState.Parent = this.Minimize_Button;
            this.Minimize_Button.Location = new System.Drawing.Point(787, 4);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimize_Button.ShadowDecoration.Parent = this.Minimize_Button;
            this.Minimize_Button.Size = new System.Drawing.Size(18, 18);
            this.Minimize_Button.TabIndex = 2;
            this.Minimize_Button.UseTransparentBackground = true;
            this.Minimize_Button.Click += new System.EventHandler(this.FormControl);
            // 
            // Rezize_Button
            // 
            this.Rezize_Button.Animated = true;
            this.Rezize_Button.BackColor = System.Drawing.Color.Transparent;
            this.Rezize_Button.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rezize_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rezize_Button.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Rezize_Button.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rezize_Button.CheckedState.Parent = this.Rezize_Button;
            this.Rezize_Button.Location = new System.Drawing.Point(749, 3);
            this.Rezize_Button.Name = "Rezize_Button";
            this.Rezize_Button.ShadowDecoration.Parent = this.Rezize_Button;
            this.Rezize_Button.Size = new System.Drawing.Size(35, 20);
            this.Rezize_Button.TabIndex = 3;
            this.Rezize_Button.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rezize_Button.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rezize_Button.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Rezize_Button.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Rezize_Button.UncheckedState.Parent = this.Rezize_Button;
            this.Rezize_Button.UseTransparentBackground = true;
            this.Rezize_Button.Click += new System.EventHandler(this.FormControl);
            // 
            // Form_Drag
            // 
            this.Form_Drag.TargetControl = this.Background_Picture;
            // 
            // Background_Picture
            // 
            this.Background_Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background_Picture.Image = global::BUS_Manager.Properties.Resources.Template;
            this.Background_Picture.Location = new System.Drawing.Point(0, 0);
            this.Background_Picture.Name = "Background_Picture";
            this.Background_Picture.Size = new System.Drawing.Size(831, 541);
            this.Background_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background_Picture.TabIndex = 0;
            this.Background_Picture.TabStop = false;
            // 
            // Login_Panel
            // 
            this.Login_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Login_Panel.Controls.Add(this.NewAccount_Button);
            this.Login_Panel.Controls.Add(this.Login_Button);
            this.Login_Panel.Controls.Add(this.label3);
            this.Login_Panel.Controls.Add(this.User_Textbox);
            this.Login_Panel.Controls.Add(this.Password_Textbox);
            this.Login_Panel.Controls.Add(this.SeePass_Button);
            this.Login_Panel.Controls.Add(this.Pass_Picture);
            this.Login_Panel.Controls.Add(this.Pass_Label);
            this.Login_Panel.Controls.Add(this.Pass_Separator);
            this.Login_Panel.Controls.Add(this.User_Picture);
            this.Login_Panel.Controls.Add(this.User_Label);
            this.Login_Panel.Controls.Add(this.User_Separator);
            this.Login_Panel.Controls.Add(this.ForgotPass_Button);
            this.Login_Panel.Location = new System.Drawing.Point(279, 61);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.ShadowDecoration.Parent = this.Login_Panel;
            this.Login_Panel.Size = new System.Drawing.Size(274, 420);
            this.Login_Panel.TabIndex = 4;
            this.Login_Panel.UseTransparentBackground = true;
            // 
            // NewAccount_Button
            // 
            this.NewAccount_Button.AutoSize = true;
            this.NewAccount_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewAccount_Button.Font = new System.Drawing.Font("Ubuntu Light", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAccount_Button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NewAccount_Button.Location = new System.Drawing.Point(76, 369);
            this.NewAccount_Button.Name = "NewAccount_Button";
            this.NewAccount_Button.Size = new System.Drawing.Size(122, 32);
            this.NewAccount_Button.TabIndex = 13;
            this.NewAccount_Button.Text = "¿No tienes un usuario?\r\n!Crea una cuenta aquí¡";
            this.NewAccount_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_Button
            // 
            this.Login_Button.Animated = true;
            this.Login_Button.AutoRoundedCorners = true;
            this.Login_Button.BorderRadius = 21;
            this.Login_Button.CheckedState.Parent = this.Login_Button;
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.CustomImages.Parent = this.Login_Button;
            this.Login_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.HoverState.Parent = this.Login_Button;
            this.Login_Button.Location = new System.Drawing.Point(4, 288);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.ShadowDecoration.Parent = this.Login_Button;
            this.Login_Button.Size = new System.Drawing.Size(266, 45);
            this.Login_Button.TabIndex = 12;
            this.Login_Button.Text = "Iniciar Sesión";
            this.Login_Button.Click += new System.EventHandler(this.LoginEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(94, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "LOGIN";
            // 
            // User_Textbox
            // 
            this.User_Textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_Textbox.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Textbox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.User_Textbox.Location = new System.Drawing.Point(34, 105);
            this.User_Textbox.Name = "User_Textbox";
            this.User_Textbox.Size = new System.Drawing.Size(236, 28);
            this.User_Textbox.TabIndex = 1;
            this.User_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_Textbox.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Textbox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Password_Textbox.Location = new System.Drawing.Point(40, 194);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(199, 28);
            this.Password_Textbox.TabIndex = 1;
            this.Password_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password_Textbox.UseSystemPasswordChar = true;
            // 
            // SeePass_Button
            // 
            this.SeePass_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeePass_Button.Image = global::BUS_Manager.Properties.Resources.eye;
            this.SeePass_Button.Location = new System.Drawing.Point(245, 198);
            this.SeePass_Button.Name = "SeePass_Button";
            this.SeePass_Button.Size = new System.Drawing.Size(25, 25);
            this.SeePass_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SeePass_Button.TabIndex = 9;
            this.SeePass_Button.TabStop = false;
            // 
            // Pass_Picture
            // 
            this.Pass_Picture.Image = global::BUS_Manager.Properties.Resources.LockedIcon;
            this.Pass_Picture.Location = new System.Drawing.Point(9, 199);
            this.Pass_Picture.Name = "Pass_Picture";
            this.Pass_Picture.Size = new System.Drawing.Size(25, 25);
            this.Pass_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pass_Picture.TabIndex = 8;
            this.Pass_Picture.TabStop = false;
            // 
            // Pass_Label
            // 
            this.Pass_Label.AutoSize = true;
            this.Pass_Label.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pass_Label.Location = new System.Drawing.Point(4, 178);
            this.Pass_Label.Name = "Pass_Label";
            this.Pass_Label.Size = new System.Drawing.Size(74, 19);
            this.Pass_Label.TabIndex = 7;
            this.Pass_Label.Text = "contraseña";
            // 
            // Pass_Separator
            // 
            this.Pass_Separator.Location = new System.Drawing.Point(4, 223);
            this.Pass_Separator.Name = "Pass_Separator";
            this.Pass_Separator.Size = new System.Drawing.Size(266, 10);
            this.Pass_Separator.TabIndex = 5;
            // 
            // User_Picture
            // 
            this.User_Picture.Image = global::BUS_Manager.Properties.Resources.UserIcon;
            this.User_Picture.Location = new System.Drawing.Point(9, 110);
            this.User_Picture.Name = "User_Picture";
            this.User_Picture.Size = new System.Drawing.Size(25, 25);
            this.User_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User_Picture.TabIndex = 4;
            this.User_Picture.TabStop = false;
            // 
            // User_Label
            // 
            this.User_Label.AutoSize = true;
            this.User_Label.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.User_Label.Location = new System.Drawing.Point(4, 89);
            this.User_Label.Name = "User_Label";
            this.User_Label.Size = new System.Drawing.Size(52, 19);
            this.User_Label.TabIndex = 3;
            this.User_Label.Text = "usuario";
            // 
            // User_Separator
            // 
            this.User_Separator.Location = new System.Drawing.Point(4, 135);
            this.User_Separator.Name = "User_Separator";
            this.User_Separator.Size = new System.Drawing.Size(266, 10);
            this.User_Separator.TabIndex = 1;
            // 
            // ForgotPass_Button
            // 
            this.ForgotPass_Button.AutoSize = true;
            this.ForgotPass_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPass_Button.Font = new System.Drawing.Font("Ubuntu Light", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPass_Button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ForgotPass_Button.Location = new System.Drawing.Point(121, 230);
            this.ForgotPass_Button.Name = "ForgotPass_Button";
            this.ForgotPass_Button.Size = new System.Drawing.Size(152, 16);
            this.ForgotPass_Button.TabIndex = 11;
            this.ForgotPass_Button.Text = "¡Se me olvidó la contraseña!";
            // 
            // Loading_Indicator
            // 
            this.Loading_Indicator.AnimationSpeed = 85;
            this.Loading_Indicator.AutoStart = true;
            this.Loading_Indicator.BackColor = System.Drawing.Color.Transparent;
            this.Loading_Indicator.CircleSize = 1F;
            this.Loading_Indicator.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Loading_Indicator.Location = new System.Drawing.Point(369, 204);
            this.Loading_Indicator.Name = "Loading_Indicator";
            this.Loading_Indicator.Size = new System.Drawing.Size(90, 90);
            this.Loading_Indicator.TabIndex = 5;
            this.Loading_Indicator.UseTransparentBackground = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 541);
            this.Controls.Add(this.Login_Panel);
            this.Controls.Add(this.Rezize_Button);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Background_Picture);
            this.Controls.Add(this.Loading_Indicator);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Shown += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Background_Picture)).EndInit();
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeePass_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Background_Picture;
        private Guna.UI2.WinForms.Guna2CircleButton Exit_Button;
        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Rezize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Minimize_Button;
        private Guna.UI2.WinForms.Guna2DragControl Form_Drag;
        private Guna.UI2.WinForms.Guna2Panel Login_Panel;
        private Guna.UI2.WinForms.Guna2Separator User_Separator;
        private System.Windows.Forms.TextBox User_Textbox;
        private System.Windows.Forms.PictureBox User_Picture;
        private System.Windows.Forms.Label User_Label;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.PictureBox Pass_Picture;
        private System.Windows.Forms.Label Pass_Label;
        private Guna.UI2.WinForms.Guna2Separator Pass_Separator;
        private System.Windows.Forms.PictureBox SeePass_Button;
        private System.Windows.Forms.Label NewAccount_Button;
        private Guna.UI2.WinForms.Guna2GradientButton Login_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ForgotPass_Button;
        private Guna.UI2.WinForms.Guna2ProgressIndicator Loading_Indicator;
    }
}