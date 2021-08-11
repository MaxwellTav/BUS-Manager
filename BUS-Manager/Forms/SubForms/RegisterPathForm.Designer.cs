
namespace BUS_Manager.Forms.SubForms
{
    partial class RegisterPathForm
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
            this.Save_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Cancel_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Top_Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Rezize_Button = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Minimize_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Title_Form = new System.Windows.Forms.Label();
            this.Form_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Path_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MapView_WebBrowser = new System.Windows.Forms.WebBrowser();
            this.WebLoading_Indicator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.Search_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Animated = true;
            this.Save_Button.CheckedState.Parent = this.Save_Button;
            this.Save_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Button.CustomImages.Parent = this.Save_Button;
            this.Save_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.Save_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Save_Button.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.Save_Button.ForeColor = System.Drawing.Color.White;
            this.Save_Button.HoverState.Parent = this.Save_Button;
            this.Save_Button.Location = new System.Drawing.Point(439, 452);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.ShadowDecoration.Parent = this.Save_Button;
            this.Save_Button.Size = new System.Drawing.Size(475, 72);
            this.Save_Button.TabIndex = 17;
            this.Save_Button.Text = "Procesar / Guardar";
            this.Save_Button.Click += new System.EventHandler(this.BottomButtons);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel_Button.Animated = true;
            this.Cancel_Button.CheckedState.Parent = this.Cancel_Button;
            this.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_Button.CustomImages.Parent = this.Cancel_Button;
            this.Cancel_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Cancel_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.Cancel_Button.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.Cancel_Button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Button.HoverState.Parent = this.Cancel_Button;
            this.Cancel_Button.Location = new System.Drawing.Point(0, 452);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.ShadowDecoration.Parent = this.Cancel_Button;
            this.Cancel_Button.Size = new System.Drawing.Size(444, 72);
            this.Cancel_Button.TabIndex = 16;
            this.Cancel_Button.Text = "Limpiar / Borrar Formulario";
            this.Cancel_Button.Click += new System.EventHandler(this.BottomButtons);
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.AliceBlue;
            this.Top_Panel.BorderColor = System.Drawing.Color.Gray;
            this.Top_Panel.BorderThickness = 1;
            this.Top_Panel.Controls.Add(this.Rezize_Button);
            this.Top_Panel.Controls.Add(this.Minimize_Button);
            this.Top_Panel.Controls.Add(this.Exit_Button);
            this.Top_Panel.Controls.Add(this.Title_Form);
            this.Top_Panel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Top_Panel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Top_Panel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Top_Panel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.ShadowDecoration.Parent = this.Top_Panel;
            this.Top_Panel.Size = new System.Drawing.Size(914, 28);
            this.Top_Panel.TabIndex = 14;
            // 
            // Rezize_Button
            // 
            this.Rezize_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Rezize_Button.Animated = true;
            this.Rezize_Button.BackColor = System.Drawing.Color.Transparent;
            this.Rezize_Button.Checked = true;
            this.Rezize_Button.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rezize_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rezize_Button.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Rezize_Button.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rezize_Button.CheckedState.Parent = this.Rezize_Button;
            this.Rezize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rezize_Button.Location = new System.Drawing.Point(831, 4);
            this.Rezize_Button.Name = "Rezize_Button";
            this.Rezize_Button.ShadowDecoration.Parent = this.Rezize_Button;
            this.Rezize_Button.Size = new System.Drawing.Size(35, 20);
            this.Rezize_Button.TabIndex = 6;
            this.Rezize_Button.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rezize_Button.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rezize_Button.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Rezize_Button.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Rezize_Button.UncheckedState.Parent = this.Rezize_Button;
            this.Rezize_Button.UseTransparentBackground = true;
            this.Rezize_Button.Click += new System.EventHandler(this.FormControl);
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Minimize_Button.Animated = true;
            this.Minimize_Button.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_Button.CheckedState.Parent = this.Minimize_Button;
            this.Minimize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Button.CustomImages.Parent = this.Minimize_Button;
            this.Minimize_Button.FillColor = System.Drawing.Color.Silver;
            this.Minimize_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimize_Button.ForeColor = System.Drawing.Color.White;
            this.Minimize_Button.HoverState.Parent = this.Minimize_Button;
            this.Minimize_Button.Location = new System.Drawing.Point(869, 5);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimize_Button.ShadowDecoration.Parent = this.Minimize_Button;
            this.Minimize_Button.Size = new System.Drawing.Size(18, 18);
            this.Minimize_Button.TabIndex = 5;
            this.Minimize_Button.UseTransparentBackground = true;
            this.Minimize_Button.Click += new System.EventHandler(this.FormControl);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Exit_Button.Animated = true;
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.CheckedState.Parent = this.Exit_Button;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.CustomImages.Parent = this.Exit_Button;
            this.Exit_Button.FillColor = System.Drawing.Color.Red;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.HoverState.Parent = this.Exit_Button;
            this.Exit_Button.Location = new System.Drawing.Point(889, 5);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(18, 18);
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.UseTransparentBackground = true;
            this.Exit_Button.Click += new System.EventHandler(this.FormControl);
            // 
            // Title_Form
            // 
            this.Title_Form.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title_Form.BackColor = System.Drawing.Color.Transparent;
            this.Title_Form.Enabled = false;
            this.Title_Form.Font = new System.Drawing.Font("Ubuntu Light", 14.25F);
            this.Title_Form.Location = new System.Drawing.Point(221, 0);
            this.Title_Form.Name = "Title_Form";
            this.Title_Form.Size = new System.Drawing.Size(472, 24);
            this.Title_Form.TabIndex = 0;
            this.Title_Form.Text = "Bus Manager - Registrar Rutas";
            this.Title_Form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Drag
            // 
            this.Form_Drag.TargetControl = this.Top_Panel;
            // 
            // Path_Textbox
            // 
            this.Path_Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Path_Textbox.Animated = true;
            this.Path_Textbox.AutoRoundedCorners = true;
            this.Path_Textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Path_Textbox.BorderRadius = 20;
            this.Path_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Path_Textbox.DefaultText = "";
            this.Path_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Path_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Path_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Path_Textbox.DisabledState.Parent = this.Path_Textbox;
            this.Path_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Path_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.Path_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Path_Textbox.FocusedState.Parent = this.Path_Textbox;
            this.Path_Textbox.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.Path_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Path_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Path_Textbox.HoverState.Parent = this.Path_Textbox;
            this.Path_Textbox.Location = new System.Drawing.Point(60, 31);
            this.Path_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Path_Textbox.Name = "Path_Textbox";
            this.Path_Textbox.PasswordChar = '\0';
            this.Path_Textbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Path_Textbox.PlaceholderText = "Nombre de la Ruta / Calle (Presiona \"Enter\" para buscar)";
            this.Path_Textbox.SelectedText = "";
            this.Path_Textbox.ShadowDecoration.Parent = this.Path_Textbox;
            this.Path_Textbox.Size = new System.Drawing.Size(724, 43);
            this.Path_Textbox.TabIndex = 18;
            this.Path_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Path_Textbox_KeyDown);
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.BorderRadius = 10;
            this.Form_Elipse.TargetControl = this;
            // 
            // MapView_WebBrowser
            // 
            this.MapView_WebBrowser.AllowWebBrowserDrop = false;
            this.MapView_WebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapView_WebBrowser.Location = new System.Drawing.Point(0, 79);
            this.MapView_WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.MapView_WebBrowser.Name = "MapView_WebBrowser";
            this.MapView_WebBrowser.ScriptErrorsSuppressed = true;
            this.MapView_WebBrowser.Size = new System.Drawing.Size(914, 374);
            this.MapView_WebBrowser.TabIndex = 19;
            this.MapView_WebBrowser.TabStop = false;
            this.MapView_WebBrowser.Url = new System.Uri("https://www.google.com.do/maps/search/", System.UriKind.Absolute);
            this.MapView_WebBrowser.WebBrowserShortcutsEnabled = false;
            this.MapView_WebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.MapView_WebBrowser_Navigated);
            this.MapView_WebBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.MapView_WebBrowser_Navigating);
            // 
            // WebLoading_Indicator
            // 
            this.WebLoading_Indicator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WebLoading_Indicator.AnimationSpeed = 85;
            this.WebLoading_Indicator.AutoStart = true;
            this.WebLoading_Indicator.BackColor = System.Drawing.Color.Transparent;
            this.WebLoading_Indicator.CircleSize = 1F;
            this.WebLoading_Indicator.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.WebLoading_Indicator.Location = new System.Drawing.Point(2, 28);
            this.WebLoading_Indicator.Name = "WebLoading_Indicator";
            this.WebLoading_Indicator.Size = new System.Drawing.Size(50, 50);
            this.WebLoading_Indicator.TabIndex = 20;
            this.WebLoading_Indicator.UseTransparentBackground = true;
            // 
            // Search_Button
            // 
            this.Search_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Search_Button.Animated = true;
            this.Search_Button.AutoRoundedCorners = true;
            this.Search_Button.BorderRadius = 20;
            this.Search_Button.CheckedState.Parent = this.Search_Button;
            this.Search_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Button.CustomImages.Parent = this.Search_Button;
            this.Search_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.Search_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Search_Button.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.ForeColor = System.Drawing.Color.White;
            this.Search_Button.HoverState.Parent = this.Search_Button;
            this.Search_Button.Location = new System.Drawing.Point(799, 31);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.ShadowDecoration.Parent = this.Search_Button;
            this.Search_Button.Size = new System.Drawing.Size(111, 43);
            this.Search_Button.TabIndex = 21;
            this.Search_Button.Text = "Buscar / Refrescar";
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // RegisterPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 523);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.MapView_WebBrowser);
            this.Controls.Add(this.Path_Textbox);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.WebLoading_Indicator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterPathForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPathForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.RegisterPathForm_Shown);
            this.Top_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton Save_Button;
        private Guna.UI2.WinForms.Guna2GradientButton Cancel_Button;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Top_Panel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Rezize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Minimize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Exit_Button;
        private System.Windows.Forms.Label Title_Form;
        private Guna.UI2.WinForms.Guna2DragControl Form_Drag;
        private Guna.UI2.WinForms.Guna2TextBox Path_Textbox;
        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private System.Windows.Forms.WebBrowser MapView_WebBrowser;
        private Guna.UI2.WinForms.Guna2ProgressIndicator WebLoading_Indicator;
        private Guna.UI2.WinForms.Guna2GradientButton Search_Button;
    }
}