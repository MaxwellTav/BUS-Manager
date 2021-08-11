
namespace BUS_Manager.Forms
{
    partial class MainForm
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
            this.Top_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Top_Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Title_Form = new System.Windows.Forms.Label();
            this.Rezize_Button = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Minimize_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Left_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Menu_Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.NavHelp_Button = new Guna.UI2.WinForms.Guna2Button();
            this.NavSupport_Button = new Guna.UI2.WinForms.Guna2Button();
            this.NavConfiguration_Button = new Guna.UI2.WinForms.Guna2Button();
            this.NavOutput_Button = new Guna.UI2.WinForms.Guna2Button();
            this.NavRegister_Button = new Guna.UI2.WinForms.Guna2Button();
            this.NavView_Button = new Guna.UI2.WinForms.Guna2Button();
            this.TopLeft_Panel = new System.Windows.Forms.Panel();
            this.View_Panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ViewTitle_Picture = new System.Windows.Forms.PictureBox();
            this.PathView_Buttons = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.VehiclesView_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.DriversView_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Register_Panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.RegsiterTitle_Picture = new System.Windows.Forms.PictureBox();
            this.PathRegister_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.VehicleRegister_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.DriversRegister_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.CreateRelations_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Top_Panel.SuspendLayout();
            this.Menu_Panel.SuspendLayout();
            this.View_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTitle_Picture)).BeginInit();
            this.Register_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegsiterTitle_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_Drag
            // 
            this.Top_Drag.TargetControl = this.Top_Panel;
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.AliceBlue;
            this.Top_Panel.BorderColor = System.Drawing.Color.Gray;
            this.Top_Panel.BorderThickness = 1;
            this.Top_Panel.Controls.Add(this.Title_Form);
            this.Top_Panel.Controls.Add(this.Rezize_Button);
            this.Top_Panel.Controls.Add(this.Minimize_Button);
            this.Top_Panel.Controls.Add(this.Exit_Button);
            this.Top_Panel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Top_Panel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Top_Panel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Top_Panel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.Top_Panel.Location = new System.Drawing.Point(298, 0);
            this.Top_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.ShadowDecoration.Parent = this.Top_Panel;
            this.Top_Panel.Size = new System.Drawing.Size(689, 28);
            this.Top_Panel.TabIndex = 1;
            // 
            // Title_Form
            // 
            this.Title_Form.AutoSize = true;
            this.Title_Form.BackColor = System.Drawing.Color.Transparent;
            this.Title_Form.Enabled = false;
            this.Title_Form.Location = new System.Drawing.Point(499, 4);
            this.Title_Form.Name = "Title_Form";
            this.Title_Form.Size = new System.Drawing.Size(101, 20);
            this.Title_Form.TabIndex = 0;
            this.Title_Form.Text = "Bus Manager";
            this.Title_Form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Rezize_Button.Location = new System.Drawing.Point(606, 4);
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
            this.Minimize_Button.Location = new System.Drawing.Point(644, 5);
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
            this.Exit_Button.Location = new System.Drawing.Point(664, 5);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(18, 18);
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.UseTransparentBackground = true;
            this.Exit_Button.Click += new System.EventHandler(this.FormControl);
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.BorderRadius = 8;
            this.Form_Elipse.TargetControl = this;
            // 
            // Left_Drag
            // 
            this.Left_Drag.TargetControl = this.Menu_Panel;
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.BorderColor = System.Drawing.Color.Gray;
            this.Menu_Panel.BorderRadius = 1;
            this.Menu_Panel.Controls.Add(this.NavHelp_Button);
            this.Menu_Panel.Controls.Add(this.NavSupport_Button);
            this.Menu_Panel.Controls.Add(this.NavConfiguration_Button);
            this.Menu_Panel.Controls.Add(this.NavOutput_Button);
            this.Menu_Panel.Controls.Add(this.NavRegister_Button);
            this.Menu_Panel.Controls.Add(this.NavView_Button);
            this.Menu_Panel.Controls.Add(this.TopLeft_Panel);
            this.Menu_Panel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Menu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Menu_Panel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Menu_Panel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Menu_Panel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Menu_Panel.Location = new System.Drawing.Point(0, 0);
            this.Menu_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.ShadowDecoration.Parent = this.Menu_Panel;
            this.Menu_Panel.Size = new System.Drawing.Size(298, 504);
            this.Menu_Panel.TabIndex = 0;
            // 
            // NavHelp_Button
            // 
            this.NavHelp_Button.CheckedState.Parent = this.NavHelp_Button;
            this.NavHelp_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NavHelp_Button.CustomImages.Parent = this.NavHelp_Button;
            this.NavHelp_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavHelp_Button.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHelp_Button.ForeColor = System.Drawing.Color.White;
            this.NavHelp_Button.HoverState.Parent = this.NavHelp_Button;
            this.NavHelp_Button.Image = global::BUS_Manager.Properties.Resources.Ayuda;
            this.NavHelp_Button.ImageSize = new System.Drawing.Size(35, 35);
            this.NavHelp_Button.Location = new System.Drawing.Point(0, 373);
            this.NavHelp_Button.Name = "NavHelp_Button";
            this.NavHelp_Button.ShadowDecoration.Parent = this.NavHelp_Button;
            this.NavHelp_Button.Size = new System.Drawing.Size(298, 69);
            this.NavHelp_Button.TabIndex = 5;
            this.NavHelp_Button.Text = "Ayuda";
            this.NavHelp_Button.Click += new System.EventHandler(this.ViewNavFunction);
            // 
            // NavSupport_Button
            // 
            this.NavSupport_Button.CheckedState.Parent = this.NavSupport_Button;
            this.NavSupport_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NavSupport_Button.CustomImages.Parent = this.NavSupport_Button;
            this.NavSupport_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavSupport_Button.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavSupport_Button.ForeColor = System.Drawing.Color.White;
            this.NavSupport_Button.HoverState.Parent = this.NavSupport_Button;
            this.NavSupport_Button.Image = global::BUS_Manager.Properties.Resources.Support;
            this.NavSupport_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.NavSupport_Button.Location = new System.Drawing.Point(0, 304);
            this.NavSupport_Button.Name = "NavSupport_Button";
            this.NavSupport_Button.ShadowDecoration.Parent = this.NavSupport_Button;
            this.NavSupport_Button.Size = new System.Drawing.Size(298, 69);
            this.NavSupport_Button.TabIndex = 4;
            this.NavSupport_Button.Text = "Soporte Tecnico";
            this.NavSupport_Button.Click += new System.EventHandler(this.ViewNavFunction);
            // 
            // NavConfiguration_Button
            // 
            this.NavConfiguration_Button.CheckedState.Parent = this.NavConfiguration_Button;
            this.NavConfiguration_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NavConfiguration_Button.CustomImages.Parent = this.NavConfiguration_Button;
            this.NavConfiguration_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavConfiguration_Button.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavConfiguration_Button.ForeColor = System.Drawing.Color.White;
            this.NavConfiguration_Button.HoverState.Parent = this.NavConfiguration_Button;
            this.NavConfiguration_Button.Image = global::BUS_Manager.Properties.Resources.Config;
            this.NavConfiguration_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.NavConfiguration_Button.Location = new System.Drawing.Point(0, 235);
            this.NavConfiguration_Button.Name = "NavConfiguration_Button";
            this.NavConfiguration_Button.ShadowDecoration.Parent = this.NavConfiguration_Button;
            this.NavConfiguration_Button.Size = new System.Drawing.Size(298, 69);
            this.NavConfiguration_Button.TabIndex = 3;
            this.NavConfiguration_Button.Text = "Configuraciones";
            this.NavConfiguration_Button.Click += new System.EventHandler(this.ViewNavFunction);
            // 
            // NavOutput_Button
            // 
            this.NavOutput_Button.CheckedState.Parent = this.NavOutput_Button;
            this.NavOutput_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NavOutput_Button.CustomImages.Parent = this.NavOutput_Button;
            this.NavOutput_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavOutput_Button.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavOutput_Button.ForeColor = System.Drawing.Color.White;
            this.NavOutput_Button.HoverState.Parent = this.NavOutput_Button;
            this.NavOutput_Button.Image = global::BUS_Manager.Properties.Resources.Report;
            this.NavOutput_Button.ImageSize = new System.Drawing.Size(35, 35);
            this.NavOutput_Button.Location = new System.Drawing.Point(0, 166);
            this.NavOutput_Button.Name = "NavOutput_Button";
            this.NavOutput_Button.ShadowDecoration.Parent = this.NavOutput_Button;
            this.NavOutput_Button.Size = new System.Drawing.Size(298, 69);
            this.NavOutput_Button.TabIndex = 2;
            this.NavOutput_Button.Text = "Salida | Reporte";
            this.NavOutput_Button.Click += new System.EventHandler(this.ViewNavFunction);
            // 
            // NavRegister_Button
            // 
            this.NavRegister_Button.CheckedState.Parent = this.NavRegister_Button;
            this.NavRegister_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NavRegister_Button.CustomImages.Parent = this.NavRegister_Button;
            this.NavRegister_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavRegister_Button.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavRegister_Button.ForeColor = System.Drawing.Color.White;
            this.NavRegister_Button.HoverState.Parent = this.NavRegister_Button;
            this.NavRegister_Button.Image = global::BUS_Manager.Properties.Resources.New;
            this.NavRegister_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.NavRegister_Button.Location = new System.Drawing.Point(0, 97);
            this.NavRegister_Button.Name = "NavRegister_Button";
            this.NavRegister_Button.ShadowDecoration.Parent = this.NavRegister_Button;
            this.NavRegister_Button.Size = new System.Drawing.Size(298, 69);
            this.NavRegister_Button.TabIndex = 1;
            this.NavRegister_Button.Text = "Registrar";
            this.NavRegister_Button.Click += new System.EventHandler(this.ViewNavFunction);
            // 
            // NavView_Button
            // 
            this.NavView_Button.CheckedState.Parent = this.NavView_Button;
            this.NavView_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NavView_Button.CustomImages.Parent = this.NavView_Button;
            this.NavView_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavView_Button.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavView_Button.ForeColor = System.Drawing.Color.White;
            this.NavView_Button.HoverState.Parent = this.NavView_Button;
            this.NavView_Button.Image = global::BUS_Manager.Properties.Resources.View2;
            this.NavView_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.NavView_Button.Location = new System.Drawing.Point(0, 28);
            this.NavView_Button.Name = "NavView_Button";
            this.NavView_Button.ShadowDecoration.Parent = this.NavView_Button;
            this.NavView_Button.Size = new System.Drawing.Size(298, 69);
            this.NavView_Button.TabIndex = 0;
            this.NavView_Button.Text = "Vista";
            this.NavView_Button.Click += new System.EventHandler(this.ViewNavFunction);
            // 
            // TopLeft_Panel
            // 
            this.TopLeft_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(128)))), ((int)(((byte)(43)))));
            this.TopLeft_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLeft_Panel.Enabled = false;
            this.TopLeft_Panel.Location = new System.Drawing.Point(0, 0);
            this.TopLeft_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TopLeft_Panel.Name = "TopLeft_Panel";
            this.TopLeft_Panel.Size = new System.Drawing.Size(298, 28);
            this.TopLeft_Panel.TabIndex = 0;
            // 
            // View_Panel
            // 
            this.View_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.View_Panel.BackColor = System.Drawing.Color.Transparent;
            this.View_Panel.Controls.Add(this.ViewTitle_Picture);
            this.View_Panel.Controls.Add(this.PathView_Buttons);
            this.View_Panel.Controls.Add(this.VehiclesView_Button);
            this.View_Panel.Controls.Add(this.DriversView_Button);
            this.View_Panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.View_Panel.Location = new System.Drawing.Point(298, 28);
            this.View_Panel.Name = "View_Panel";
            this.View_Panel.Radius = 5;
            this.View_Panel.ShadowColor = System.Drawing.Color.Black;
            this.View_Panel.Size = new System.Drawing.Size(689, 476);
            this.View_Panel.TabIndex = 2;
            this.View_Panel.Tag = "UserC";
            // 
            // ViewTitle_Picture
            // 
            this.ViewTitle_Picture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ViewTitle_Picture.BackgroundImage = global::BUS_Manager.Properties.Resources.View2;
            this.ViewTitle_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewTitle_Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ViewTitle_Picture.Location = new System.Drawing.Point(309, 18);
            this.ViewTitle_Picture.Name = "ViewTitle_Picture";
            this.ViewTitle_Picture.Size = new System.Drawing.Size(70, 70);
            this.ViewTitle_Picture.TabIndex = 2;
            this.ViewTitle_Picture.TabStop = false;
            // 
            // PathView_Buttons
            // 
            this.PathView_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathView_Buttons.AutoRoundedCorners = true;
            this.PathView_Buttons.BorderRadius = 39;
            this.PathView_Buttons.CheckedState.Parent = this.PathView_Buttons;
            this.PathView_Buttons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PathView_Buttons.CustomImages.Parent = this.PathView_Buttons;
            this.PathView_Buttons.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(144)))));
            this.PathView_Buttons.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.PathView_Buttons.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathView_Buttons.ForeColor = System.Drawing.Color.White;
            this.PathView_Buttons.HoverState.Parent = this.PathView_Buttons;
            this.PathView_Buttons.Image = global::BUS_Manager.Properties.Resources.Ruta;
            this.PathView_Buttons.ImageOffset = new System.Drawing.Point(-270, 25);
            this.PathView_Buttons.ImageSize = new System.Drawing.Size(50, 50);
            this.PathView_Buttons.Location = new System.Drawing.Point(14, 276);
            this.PathView_Buttons.Name = "PathView_Buttons";
            this.PathView_Buttons.ShadowDecoration.Parent = this.PathView_Buttons;
            this.PathView_Buttons.Size = new System.Drawing.Size(650, 80);
            this.PathView_Buttons.TabIndex = 0;
            this.PathView_Buttons.Text = "Rutas";
            this.PathView_Buttons.TextOffset = new System.Drawing.Point(0, -25);
            this.PathView_Buttons.Click += new System.EventHandler(this.DriversView_Button_Click);
            // 
            // VehiclesView_Button
            // 
            this.VehiclesView_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VehiclesView_Button.AutoRoundedCorners = true;
            this.VehiclesView_Button.BorderRadius = 39;
            this.VehiclesView_Button.CheckedState.Parent = this.VehiclesView_Button;
            this.VehiclesView_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VehiclesView_Button.CustomImages.Parent = this.VehiclesView_Button;
            this.VehiclesView_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(144)))));
            this.VehiclesView_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.VehiclesView_Button.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiclesView_Button.ForeColor = System.Drawing.Color.White;
            this.VehiclesView_Button.HoverState.Parent = this.VehiclesView_Button;
            this.VehiclesView_Button.Image = global::BUS_Manager.Properties.Resources.Vehicle;
            this.VehiclesView_Button.ImageOffset = new System.Drawing.Point(-270, 25);
            this.VehiclesView_Button.ImageSize = new System.Drawing.Size(50, 50);
            this.VehiclesView_Button.Location = new System.Drawing.Point(14, 190);
            this.VehiclesView_Button.Name = "VehiclesView_Button";
            this.VehiclesView_Button.ShadowDecoration.Parent = this.VehiclesView_Button;
            this.VehiclesView_Button.Size = new System.Drawing.Size(650, 80);
            this.VehiclesView_Button.TabIndex = 0;
            this.VehiclesView_Button.Text = "Vehiculos";
            this.VehiclesView_Button.TextOffset = new System.Drawing.Point(0, -25);
            this.VehiclesView_Button.Click += new System.EventHandler(this.DriversView_Button_Click);
            // 
            // DriversView_Button
            // 
            this.DriversView_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DriversView_Button.AutoRoundedCorners = true;
            this.DriversView_Button.BorderRadius = 39;
            this.DriversView_Button.CheckedState.Parent = this.DriversView_Button;
            this.DriversView_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DriversView_Button.CustomImages.Parent = this.DriversView_Button;
            this.DriversView_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(144)))));
            this.DriversView_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.DriversView_Button.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriversView_Button.ForeColor = System.Drawing.Color.White;
            this.DriversView_Button.HoverState.Parent = this.DriversView_Button;
            this.DriversView_Button.Image = global::BUS_Manager.Properties.Resources.Driver;
            this.DriversView_Button.ImageOffset = new System.Drawing.Point(-270, 25);
            this.DriversView_Button.ImageSize = new System.Drawing.Size(50, 50);
            this.DriversView_Button.Location = new System.Drawing.Point(14, 104);
            this.DriversView_Button.Name = "DriversView_Button";
            this.DriversView_Button.ShadowDecoration.Parent = this.DriversView_Button;
            this.DriversView_Button.Size = new System.Drawing.Size(650, 80);
            this.DriversView_Button.TabIndex = 0;
            this.DriversView_Button.Text = "Conductores";
            this.DriversView_Button.TextOffset = new System.Drawing.Point(0, -25);
            this.DriversView_Button.Click += new System.EventHandler(this.DriversView_Button_Click);
            // 
            // Register_Panel
            // 
            this.Register_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Register_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Register_Panel.Controls.Add(this.RegsiterTitle_Picture);
            this.Register_Panel.Controls.Add(this.CreateRelations_Button);
            this.Register_Panel.Controls.Add(this.PathRegister_Button);
            this.Register_Panel.Controls.Add(this.VehicleRegister_Button);
            this.Register_Panel.Controls.Add(this.DriversRegister_Button);
            this.Register_Panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Register_Panel.Location = new System.Drawing.Point(298, 28);
            this.Register_Panel.Name = "Register_Panel";
            this.Register_Panel.Radius = 5;
            this.Register_Panel.ShadowColor = System.Drawing.Color.Black;
            this.Register_Panel.Size = new System.Drawing.Size(689, 476);
            this.Register_Panel.TabIndex = 3;
            this.Register_Panel.Tag = "UserC";
            // 
            // RegsiterTitle_Picture
            // 
            this.RegsiterTitle_Picture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RegsiterTitle_Picture.BackgroundImage = global::BUS_Manager.Properties.Resources.New;
            this.RegsiterTitle_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegsiterTitle_Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegsiterTitle_Picture.Location = new System.Drawing.Point(309, 18);
            this.RegsiterTitle_Picture.Name = "RegsiterTitle_Picture";
            this.RegsiterTitle_Picture.Size = new System.Drawing.Size(70, 70);
            this.RegsiterTitle_Picture.TabIndex = 1;
            this.RegsiterTitle_Picture.TabStop = false;
            // 
            // PathRegister_Button
            // 
            this.PathRegister_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathRegister_Button.AutoRoundedCorners = true;
            this.PathRegister_Button.BorderRadius = 39;
            this.PathRegister_Button.CheckedState.Parent = this.PathRegister_Button;
            this.PathRegister_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PathRegister_Button.CustomImages.Parent = this.PathRegister_Button;
            this.PathRegister_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(144)))));
            this.PathRegister_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.PathRegister_Button.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathRegister_Button.ForeColor = System.Drawing.Color.White;
            this.PathRegister_Button.HoverState.Parent = this.PathRegister_Button;
            this.PathRegister_Button.Image = global::BUS_Manager.Properties.Resources.Ruta;
            this.PathRegister_Button.ImageOffset = new System.Drawing.Point(-270, 25);
            this.PathRegister_Button.ImageSize = new System.Drawing.Size(50, 50);
            this.PathRegister_Button.Location = new System.Drawing.Point(14, 276);
            this.PathRegister_Button.Name = "PathRegister_Button";
            this.PathRegister_Button.ShadowDecoration.Parent = this.PathRegister_Button;
            this.PathRegister_Button.Size = new System.Drawing.Size(650, 80);
            this.PathRegister_Button.TabIndex = 0;
            this.PathRegister_Button.Text = "Ruta";
            this.PathRegister_Button.TextOffset = new System.Drawing.Point(0, -25);
            this.PathRegister_Button.Click += new System.EventHandler(this.DriversView_Button_Click);
            // 
            // VehicleRegister_Button
            // 
            this.VehicleRegister_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VehicleRegister_Button.AutoRoundedCorners = true;
            this.VehicleRegister_Button.BorderRadius = 39;
            this.VehicleRegister_Button.CheckedState.Parent = this.VehicleRegister_Button;
            this.VehicleRegister_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VehicleRegister_Button.CustomImages.Parent = this.VehicleRegister_Button;
            this.VehicleRegister_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(144)))));
            this.VehicleRegister_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.VehicleRegister_Button.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleRegister_Button.ForeColor = System.Drawing.Color.White;
            this.VehicleRegister_Button.HoverState.Parent = this.VehicleRegister_Button;
            this.VehicleRegister_Button.Image = global::BUS_Manager.Properties.Resources.Vehicle;
            this.VehicleRegister_Button.ImageOffset = new System.Drawing.Point(-270, 25);
            this.VehicleRegister_Button.ImageSize = new System.Drawing.Size(50, 50);
            this.VehicleRegister_Button.Location = new System.Drawing.Point(14, 190);
            this.VehicleRegister_Button.Name = "VehicleRegister_Button";
            this.VehicleRegister_Button.ShadowDecoration.Parent = this.VehicleRegister_Button;
            this.VehicleRegister_Button.Size = new System.Drawing.Size(650, 80);
            this.VehicleRegister_Button.TabIndex = 0;
            this.VehicleRegister_Button.Text = "Vehiculo";
            this.VehicleRegister_Button.TextOffset = new System.Drawing.Point(0, -25);
            this.VehicleRegister_Button.Click += new System.EventHandler(this.DriversView_Button_Click);
            // 
            // DriversRegister_Button
            // 
            this.DriversRegister_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DriversRegister_Button.AutoRoundedCorners = true;
            this.DriversRegister_Button.BorderRadius = 39;
            this.DriversRegister_Button.CheckedState.Parent = this.DriversRegister_Button;
            this.DriversRegister_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DriversRegister_Button.CustomImages.Parent = this.DriversRegister_Button;
            this.DriversRegister_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(144)))));
            this.DriversRegister_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.DriversRegister_Button.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriversRegister_Button.ForeColor = System.Drawing.Color.White;
            this.DriversRegister_Button.HoverState.Parent = this.DriversRegister_Button;
            this.DriversRegister_Button.Image = global::BUS_Manager.Properties.Resources.Driver;
            this.DriversRegister_Button.ImageOffset = new System.Drawing.Point(-270, 25);
            this.DriversRegister_Button.ImageSize = new System.Drawing.Size(50, 50);
            this.DriversRegister_Button.Location = new System.Drawing.Point(14, 104);
            this.DriversRegister_Button.Name = "DriversRegister_Button";
            this.DriversRegister_Button.ShadowDecoration.Parent = this.DriversRegister_Button;
            this.DriversRegister_Button.Size = new System.Drawing.Size(650, 80);
            this.DriversRegister_Button.TabIndex = 0;
            this.DriversRegister_Button.Text = "Conductor";
            this.DriversRegister_Button.TextOffset = new System.Drawing.Point(0, -25);
            this.DriversRegister_Button.Click += new System.EventHandler(this.DriversView_Button_Click);
            // 
            // CreateRelations_Button
            // 
            this.CreateRelations_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateRelations_Button.AutoRoundedCorners = true;
            this.CreateRelations_Button.BorderRadius = 39;
            this.CreateRelations_Button.CheckedState.Parent = this.CreateRelations_Button;
            this.CreateRelations_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateRelations_Button.CustomImages.Parent = this.CreateRelations_Button;
            this.CreateRelations_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(144)))));
            this.CreateRelations_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(85)))));
            this.CreateRelations_Button.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateRelations_Button.ForeColor = System.Drawing.Color.White;
            this.CreateRelations_Button.HoverState.Parent = this.CreateRelations_Button;
            this.CreateRelations_Button.Image = global::BUS_Manager.Properties.Resources.Cross;
            this.CreateRelations_Button.ImageOffset = new System.Drawing.Point(-270, 25);
            this.CreateRelations_Button.ImageSize = new System.Drawing.Size(50, 50);
            this.CreateRelations_Button.Location = new System.Drawing.Point(14, 362);
            this.CreateRelations_Button.Name = "CreateRelations_Button";
            this.CreateRelations_Button.ShadowDecoration.Parent = this.CreateRelations_Button;
            this.CreateRelations_Button.Size = new System.Drawing.Size(650, 80);
            this.CreateRelations_Button.TabIndex = 0;
            this.CreateRelations_Button.Text = "Relacionar";
            this.CreateRelations_Button.TextOffset = new System.Drawing.Point(0, -25);
            this.CreateRelations_Button.Click += new System.EventHandler(this.DriversView_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 504);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.Register_Panel);
            this.Controls.Add(this.View_Panel);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            this.Menu_Panel.ResumeLayout(false);
            this.View_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewTitle_Picture)).EndInit();
            this.Register_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegsiterTitle_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl Top_Drag;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Top_Panel;
        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2DragControl Left_Drag;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Rezize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Minimize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Exit_Button;
        private System.Windows.Forms.Label Title_Form;
        private Guna.UI2.WinForms.Guna2ShadowPanel View_Panel;
        private Guna.UI2.WinForms.Guna2GradientTileButton DriversView_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton PathView_Buttons;
        private Guna.UI2.WinForms.Guna2GradientTileButton VehiclesView_Button;
        private Guna.UI2.WinForms.Guna2ShadowPanel Register_Panel;
        private System.Windows.Forms.PictureBox RegsiterTitle_Picture;
        private Guna.UI2.WinForms.Guna2GradientTileButton PathRegister_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton VehicleRegister_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton DriversRegister_Button;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Menu_Panel;
        private Guna.UI2.WinForms.Guna2Button NavHelp_Button;
        private Guna.UI2.WinForms.Guna2Button NavSupport_Button;
        private Guna.UI2.WinForms.Guna2Button NavConfiguration_Button;
        private Guna.UI2.WinForms.Guna2Button NavOutput_Button;
        private Guna.UI2.WinForms.Guna2Button NavRegister_Button;
        private Guna.UI2.WinForms.Guna2Button NavView_Button;
        private System.Windows.Forms.Panel TopLeft_Panel;
        private System.Windows.Forms.PictureBox ViewTitle_Picture;
        private Guna.UI2.WinForms.Guna2GradientTileButton CreateRelations_Button;
    }
}