
namespace BUS_Manager.Forms.SubForms
{
    partial class RegisterVehicleForm
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
            this.Title_Picture = new System.Windows.Forms.PictureBox();
            this.MarkVehicle_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Top_Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Rezize_Button = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Minimize_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Title_Form = new System.Windows.Forms.Label();
            this.ModelVehicle_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDVehicle_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ColorVehicle_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.From_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ColorPicker_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.YearVehicle_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CurrentColorVehicle_Color = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Picture)).BeginInit();
            this.Top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColorVehicle_Color)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.Animated = true;
            this.Save_Button.CheckedState.Parent = this.Save_Button;
            this.Save_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Button.CustomImages.Parent = this.Save_Button;
            this.Save_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.Save_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Save_Button.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.Save_Button.ForeColor = System.Drawing.Color.White;
            this.Save_Button.HoverState.Parent = this.Save_Button;
            this.Save_Button.Location = new System.Drawing.Point(224, 399);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.ShadowDecoration.Parent = this.Save_Button;
            this.Save_Button.Size = new System.Drawing.Size(254, 72);
            this.Save_Button.TabIndex = 18;
            this.Save_Button.Text = "Procesar / Guardar";
            this.Save_Button.Click += new System.EventHandler(this.BottomButtons);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Animated = true;
            this.Cancel_Button.CheckedState.Parent = this.Cancel_Button;
            this.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_Button.CustomImages.Parent = this.Cancel_Button;
            this.Cancel_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Cancel_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.Cancel_Button.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.Cancel_Button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Button.HoverState.Parent = this.Cancel_Button;
            this.Cancel_Button.Location = new System.Drawing.Point(0, 399);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.ShadowDecoration.Parent = this.Cancel_Button;
            this.Cancel_Button.Size = new System.Drawing.Size(224, 72);
            this.Cancel_Button.TabIndex = 17;
            this.Cancel_Button.Text = "Limpiar / Borrar Formulario";
            this.Cancel_Button.Click += new System.EventHandler(this.BottomButtons);
            // 
            // Title_Picture
            // 
            this.Title_Picture.BackgroundImage = global::BUS_Manager.Properties.Resources.Vehicle;
            this.Title_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Title_Picture.Location = new System.Drawing.Point(216, 43);
            this.Title_Picture.Name = "Title_Picture";
            this.Title_Picture.Size = new System.Drawing.Size(50, 50);
            this.Title_Picture.TabIndex = 16;
            this.Title_Picture.TabStop = false;
            // 
            // MarkVehicle_Textbox
            // 
            this.MarkVehicle_Textbox.Animated = true;
            this.MarkVehicle_Textbox.BorderThickness = 0;
            this.MarkVehicle_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MarkVehicle_Textbox.DefaultText = "";
            this.MarkVehicle_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MarkVehicle_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MarkVehicle_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MarkVehicle_Textbox.DisabledState.Parent = this.MarkVehicle_Textbox;
            this.MarkVehicle_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MarkVehicle_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.MarkVehicle_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MarkVehicle_Textbox.FocusedState.Parent = this.MarkVehicle_Textbox;
            this.MarkVehicle_Textbox.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.MarkVehicle_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MarkVehicle_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MarkVehicle_Textbox.HoverState.Parent = this.MarkVehicle_Textbox;
            this.MarkVehicle_Textbox.Location = new System.Drawing.Point(30, 87);
            this.MarkVehicle_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MarkVehicle_Textbox.Name = "MarkVehicle_Textbox";
            this.MarkVehicle_Textbox.PasswordChar = '\0';
            this.MarkVehicle_Textbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.MarkVehicle_Textbox.PlaceholderText = "Marca del autobús";
            this.MarkVehicle_Textbox.SelectedText = "";
            this.MarkVehicle_Textbox.ShadowDecoration.Parent = this.MarkVehicle_Textbox;
            this.MarkVehicle_Textbox.Size = new System.Drawing.Size(410, 43);
            this.MarkVehicle_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.MarkVehicle_Textbox.TabIndex = 15;
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
            this.Top_Panel.Size = new System.Drawing.Size(478, 28);
            this.Top_Panel.TabIndex = 14;
            // 
            // Rezize_Button
            // 
            this.Rezize_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Rezize_Button.Animated = true;
            this.Rezize_Button.BackColor = System.Drawing.Color.Transparent;
            this.Rezize_Button.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rezize_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rezize_Button.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Rezize_Button.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rezize_Button.CheckedState.Parent = this.Rezize_Button;
            this.Rezize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rezize_Button.Location = new System.Drawing.Point(395, 4);
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
            this.Minimize_Button.Location = new System.Drawing.Point(433, 5);
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
            this.Exit_Button.Location = new System.Drawing.Point(453, 5);
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
            this.Title_Form.Location = new System.Drawing.Point(3, 0);
            this.Title_Form.Name = "Title_Form";
            this.Title_Form.Size = new System.Drawing.Size(397, 24);
            this.Title_Form.TabIndex = 0;
            this.Title_Form.Text = "Bus Manager - Registrar Vehículos";
            this.Title_Form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelVehicle_Textbox
            // 
            this.ModelVehicle_Textbox.Animated = true;
            this.ModelVehicle_Textbox.BorderThickness = 0;
            this.ModelVehicle_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelVehicle_Textbox.DefaultText = "";
            this.ModelVehicle_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ModelVehicle_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ModelVehicle_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModelVehicle_Textbox.DisabledState.Parent = this.ModelVehicle_Textbox;
            this.ModelVehicle_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModelVehicle_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.ModelVehicle_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModelVehicle_Textbox.FocusedState.Parent = this.ModelVehicle_Textbox;
            this.ModelVehicle_Textbox.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.ModelVehicle_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ModelVehicle_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModelVehicle_Textbox.HoverState.Parent = this.ModelVehicle_Textbox;
            this.ModelVehicle_Textbox.Location = new System.Drawing.Point(30, 140);
            this.ModelVehicle_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModelVehicle_Textbox.Name = "ModelVehicle_Textbox";
            this.ModelVehicle_Textbox.PasswordChar = '\0';
            this.ModelVehicle_Textbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ModelVehicle_Textbox.PlaceholderText = "Modelo del autobús";
            this.ModelVehicle_Textbox.SelectedText = "";
            this.ModelVehicle_Textbox.ShadowDecoration.Parent = this.ModelVehicle_Textbox;
            this.ModelVehicle_Textbox.Size = new System.Drawing.Size(410, 43);
            this.ModelVehicle_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ModelVehicle_Textbox.TabIndex = 15;
            // 
            // IDVehicle_Textbox
            // 
            this.IDVehicle_Textbox.Animated = true;
            this.IDVehicle_Textbox.BorderThickness = 0;
            this.IDVehicle_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDVehicle_Textbox.DefaultText = "";
            this.IDVehicle_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDVehicle_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDVehicle_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDVehicle_Textbox.DisabledState.Parent = this.IDVehicle_Textbox;
            this.IDVehicle_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDVehicle_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.IDVehicle_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDVehicle_Textbox.FocusedState.Parent = this.IDVehicle_Textbox;
            this.IDVehicle_Textbox.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.IDVehicle_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDVehicle_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDVehicle_Textbox.HoverState.Parent = this.IDVehicle_Textbox;
            this.IDVehicle_Textbox.Location = new System.Drawing.Point(30, 193);
            this.IDVehicle_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDVehicle_Textbox.Name = "IDVehicle_Textbox";
            this.IDVehicle_Textbox.PasswordChar = '\0';
            this.IDVehicle_Textbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.IDVehicle_Textbox.PlaceholderText = "Placa del autobús";
            this.IDVehicle_Textbox.SelectedText = "";
            this.IDVehicle_Textbox.ShadowDecoration.Parent = this.IDVehicle_Textbox;
            this.IDVehicle_Textbox.Size = new System.Drawing.Size(410, 43);
            this.IDVehicle_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.IDVehicle_Textbox.TabIndex = 15;
            // 
            // ColorVehicle_Textbox
            // 
            this.ColorVehicle_Textbox.Animated = true;
            this.ColorVehicle_Textbox.AutoCompleteCustomSource.AddRange(new string[] {
            "Rojo",
            "Azul",
            "Blanco",
            "Amarillo",
            "Verde",
            "Gris",
            "Gris Claro",
            "Grid Oscuro",
            "Rosa Fucsia"});
            this.ColorVehicle_Textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ColorVehicle_Textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ColorVehicle_Textbox.BorderThickness = 0;
            this.ColorVehicle_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ColorVehicle_Textbox.DefaultText = "";
            this.ColorVehicle_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ColorVehicle_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ColorVehicle_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ColorVehicle_Textbox.DisabledState.Parent = this.ColorVehicle_Textbox;
            this.ColorVehicle_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ColorVehicle_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.ColorVehicle_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ColorVehicle_Textbox.FocusedState.Parent = this.ColorVehicle_Textbox;
            this.ColorVehicle_Textbox.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.ColorVehicle_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ColorVehicle_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ColorVehicle_Textbox.HoverState.Parent = this.ColorVehicle_Textbox;
            this.ColorVehicle_Textbox.Location = new System.Drawing.Point(30, 246);
            this.ColorVehicle_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColorVehicle_Textbox.Name = "ColorVehicle_Textbox";
            this.ColorVehicle_Textbox.PasswordChar = '\0';
            this.ColorVehicle_Textbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ColorVehicle_Textbox.PlaceholderText = "Color del autobús";
            this.ColorVehicle_Textbox.SelectedText = "";
            this.ColorVehicle_Textbox.ShadowDecoration.Parent = this.ColorVehicle_Textbox;
            this.ColorVehicle_Textbox.Size = new System.Drawing.Size(197, 43);
            this.ColorVehicle_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ColorVehicle_Textbox.TabIndex = 15;
            // 
            // ColorPicker
            // 
            this.ColorPicker.AnyColor = true;
            this.ColorPicker.FullOpen = true;
            this.ColorPicker.ShowHelp = true;
            // 
            // From_Drag
            // 
            this.From_Drag.TargetControl = this.Top_Panel;
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.BorderRadius = 25;
            this.Form_Elipse.TargetControl = this;
            // 
            // ColorPicker_Button
            // 
            this.ColorPicker_Button.Animated = true;
            this.ColorPicker_Button.AutoRoundedCorners = true;
            this.ColorPicker_Button.BorderRadius = 21;
            this.ColorPicker_Button.CheckedState.Parent = this.ColorPicker_Button;
            this.ColorPicker_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorPicker_Button.CustomImages.Parent = this.ColorPicker_Button;
            this.ColorPicker_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.ColorPicker_Button.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.ColorPicker_Button.ForeColor = System.Drawing.Color.White;
            this.ColorPicker_Button.HoverState.Parent = this.ColorPicker_Button;
            this.ColorPicker_Button.Location = new System.Drawing.Point(234, 246);
            this.ColorPicker_Button.Name = "ColorPicker_Button";
            this.ColorPicker_Button.ShadowDecoration.Parent = this.ColorPicker_Button;
            this.ColorPicker_Button.Size = new System.Drawing.Size(206, 45);
            this.ColorPicker_Button.TabIndex = 19;
            this.ColorPicker_Button.Text = "Elegir color";
            this.ColorPicker_Button.Click += new System.EventHandler(this.ColorPicker_Button_Click);
            // 
            // YearVehicle_Textbox
            // 
            this.YearVehicle_Textbox.Animated = true;
            this.YearVehicle_Textbox.BorderThickness = 0;
            this.YearVehicle_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.YearVehicle_Textbox.DefaultText = "";
            this.YearVehicle_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.YearVehicle_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.YearVehicle_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.YearVehicle_Textbox.DisabledState.Parent = this.YearVehicle_Textbox;
            this.YearVehicle_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.YearVehicle_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.YearVehicle_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YearVehicle_Textbox.FocusedState.Parent = this.YearVehicle_Textbox;
            this.YearVehicle_Textbox.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.YearVehicle_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.YearVehicle_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YearVehicle_Textbox.HoverState.Parent = this.YearVehicle_Textbox;
            this.YearVehicle_Textbox.Location = new System.Drawing.Point(30, 316);
            this.YearVehicle_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YearVehicle_Textbox.MaxLength = 4;
            this.YearVehicle_Textbox.Name = "YearVehicle_Textbox";
            this.YearVehicle_Textbox.PasswordChar = '\0';
            this.YearVehicle_Textbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.YearVehicle_Textbox.PlaceholderText = "Año del autobús";
            this.YearVehicle_Textbox.SelectedText = "";
            this.YearVehicle_Textbox.ShadowDecoration.Parent = this.YearVehicle_Textbox;
            this.YearVehicle_Textbox.Size = new System.Drawing.Size(410, 43);
            this.YearVehicle_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.YearVehicle_Textbox.TabIndex = 15;
            // 
            // CurrentColorVehicle_Color
            // 
            this.CurrentColorVehicle_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CurrentColorVehicle_Color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CurrentColorVehicle_Color.Location = new System.Drawing.Point(30, 297);
            this.CurrentColorVehicle_Color.Name = "CurrentColorVehicle_Color";
            this.CurrentColorVehicle_Color.ShadowDecoration.Parent = this.CurrentColorVehicle_Color;
            this.CurrentColorVehicle_Color.Size = new System.Drawing.Size(410, 19);
            this.CurrentColorVehicle_Color.TabIndex = 20;
            this.CurrentColorVehicle_Color.TabStop = false;
            // 
            // RegisterVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 470);
            this.Controls.Add(this.CurrentColorVehicle_Color);
            this.Controls.Add(this.ColorPicker_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.YearVehicle_Textbox);
            this.Controls.Add(this.ColorVehicle_Textbox);
            this.Controls.Add(this.IDVehicle_Textbox);
            this.Controls.Add(this.ModelVehicle_Textbox);
            this.Controls.Add(this.MarkVehicle_Textbox);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Title_Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterVehicleForm";
            ((System.ComponentModel.ISupportInitialize)(this.Title_Picture)).EndInit();
            this.Top_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColorVehicle_Color)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton Save_Button;
        private Guna.UI2.WinForms.Guna2GradientButton Cancel_Button;
        private System.Windows.Forms.PictureBox Title_Picture;
        private Guna.UI2.WinForms.Guna2TextBox MarkVehicle_Textbox;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Top_Panel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Rezize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Minimize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Exit_Button;
        private System.Windows.Forms.Label Title_Form;
        private Guna.UI2.WinForms.Guna2TextBox ModelVehicle_Textbox;
        private Guna.UI2.WinForms.Guna2TextBox IDVehicle_Textbox;
        private Guna.UI2.WinForms.Guna2TextBox ColorVehicle_Textbox;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private Guna.UI2.WinForms.Guna2DragControl From_Drag;
        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2PictureBox CurrentColorVehicle_Color;
        private Guna.UI2.WinForms.Guna2GradientButton ColorPicker_Button;
        private Guna.UI2.WinForms.Guna2TextBox YearVehicle_Textbox;
    }
}