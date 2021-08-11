
namespace BUS_Manager.Forms.SubForms
{
    partial class RegisterDriverForm
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
            this.Top_Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Rezize_Button = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Minimize_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Title_Form = new System.Windows.Forms.Label();
            this.From_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LastNDriver_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateBornTitle_Label = new System.Windows.Forms.Label();
            this.DateBornDriver_Picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.IdentificationDriver_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Cancel_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.NameDriver_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Save_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.Top_Panel.TabIndex = 3;
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
            this.Title_Form.Size = new System.Drawing.Size(472, 24);
            this.Title_Form.TabIndex = 0;
            this.Title_Form.Text = "Bus Manager - Registrar Choferes";
            this.Title_Form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BUS_Manager.Properties.Resources.Driver;
            this.pictureBox1.Location = new System.Drawing.Point(216, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LastNDriver_Textbox
            // 
            this.LastNDriver_Textbox.Animated = true;
            this.LastNDriver_Textbox.BorderThickness = 0;
            this.LastNDriver_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNDriver_Textbox.DefaultText = "";
            this.LastNDriver_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastNDriver_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastNDriver_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNDriver_Textbox.DisabledState.Parent = this.LastNDriver_Textbox;
            this.LastNDriver_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNDriver_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.LastNDriver_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastNDriver_Textbox.FocusedState.Parent = this.LastNDriver_Textbox;
            this.LastNDriver_Textbox.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.LastNDriver_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LastNDriver_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastNDriver_Textbox.HoverState.Parent = this.LastNDriver_Textbox;
            this.LastNDriver_Textbox.Location = new System.Drawing.Point(30, 161);
            this.LastNDriver_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNDriver_Textbox.Name = "LastNDriver_Textbox";
            this.LastNDriver_Textbox.PasswordChar = '\0';
            this.LastNDriver_Textbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.LastNDriver_Textbox.PlaceholderText = "Primer y segundo Apellido";
            this.LastNDriver_Textbox.SelectedText = "";
            this.LastNDriver_Textbox.ShadowDecoration.Parent = this.LastNDriver_Textbox;
            this.LastNDriver_Textbox.Size = new System.Drawing.Size(410, 43);
            this.LastNDriver_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.LastNDriver_Textbox.TabIndex = 7;
            this.LastNDriver_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameDriver_Textbox_KeyPress);
            // 
            // DateBornTitle_Label
            // 
            this.DateBornTitle_Label.AutoSize = true;
            this.DateBornTitle_Label.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.DateBornTitle_Label.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.DateBornTitle_Label.Location = new System.Drawing.Point(36, 220);
            this.DateBornTitle_Label.Name = "DateBornTitle_Label";
            this.DateBornTitle_Label.Size = new System.Drawing.Size(163, 21);
            this.DateBornTitle_Label.TabIndex = 8;
            this.DateBornTitle_Label.Text = "Fecha de nacimiento";
            // 
            // DateBornDriver_Picker
            // 
            this.DateBornDriver_Picker.Animated = true;
            this.DateBornDriver_Picker.AutoRoundedCorners = true;
            this.DateBornDriver_Picker.BorderRadius = 17;
            this.DateBornDriver_Picker.CheckedState.Parent = this.DateBornDriver_Picker;
            this.DateBornDriver_Picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateBornDriver_Picker.FillColor = System.Drawing.Color.DarkGray;
            this.DateBornDriver_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateBornDriver_Picker.HoverState.Parent = this.DateBornDriver_Picker;
            this.DateBornDriver_Picker.Location = new System.Drawing.Point(40, 246);
            this.DateBornDriver_Picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateBornDriver_Picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateBornDriver_Picker.Name = "DateBornDriver_Picker";
            this.DateBornDriver_Picker.ShadowDecoration.Parent = this.DateBornDriver_Picker;
            this.DateBornDriver_Picker.Size = new System.Drawing.Size(400, 36);
            this.DateBornDriver_Picker.TabIndex = 9;
            this.DateBornDriver_Picker.Value = new System.DateTime(2001, 9, 7, 12, 30, 0, 0);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(30, 279);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(410, 10);
            this.guna2Separator1.TabIndex = 10;
            // 
            // IdentificationDriver_Textbox
            // 
            this.IdentificationDriver_Textbox.Animated = true;
            this.IdentificationDriver_Textbox.BorderThickness = 0;
            this.IdentificationDriver_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdentificationDriver_Textbox.DefaultText = "";
            this.IdentificationDriver_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IdentificationDriver_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IdentificationDriver_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdentificationDriver_Textbox.DisabledState.Parent = this.IdentificationDriver_Textbox;
            this.IdentificationDriver_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdentificationDriver_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.IdentificationDriver_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdentificationDriver_Textbox.FocusedState.Parent = this.IdentificationDriver_Textbox;
            this.IdentificationDriver_Textbox.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.IdentificationDriver_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IdentificationDriver_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdentificationDriver_Textbox.HoverState.Parent = this.IdentificationDriver_Textbox;
            this.IdentificationDriver_Textbox.Location = new System.Drawing.Point(30, 297);
            this.IdentificationDriver_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IdentificationDriver_Textbox.MaxLength = 11;
            this.IdentificationDriver_Textbox.Name = "IdentificationDriver_Textbox";
            this.IdentificationDriver_Textbox.PasswordChar = '\0';
            this.IdentificationDriver_Textbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.IdentificationDriver_Textbox.PlaceholderText = "Cédula";
            this.IdentificationDriver_Textbox.SelectedText = "";
            this.IdentificationDriver_Textbox.ShadowDecoration.Parent = this.IdentificationDriver_Textbox;
            this.IdentificationDriver_Textbox.Size = new System.Drawing.Size(410, 43);
            this.IdentificationDriver_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.IdentificationDriver_Textbox.TabIndex = 13;
            this.IdentificationDriver_Textbox.TextChanged += new System.EventHandler(this.IdentificationDriver_Textbox_TextChanged);
            this.IdentificationDriver_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdentificationDriver_Textbox_KeyDown);
            this.IdentificationDriver_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentificationDriver_Textbox_KeyPress);
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
            this.Cancel_Button.TabIndex = 12;
            this.Cancel_Button.Text = "Limpiar / Borrar Formulario";
            this.Cancel_Button.Click += new System.EventHandler(this.BottomButtons);
            // 
            // NameDriver_Textbox
            // 
            this.NameDriver_Textbox.Animated = true;
            this.NameDriver_Textbox.BorderThickness = 0;
            this.NameDriver_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameDriver_Textbox.DefaultText = "";
            this.NameDriver_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameDriver_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameDriver_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameDriver_Textbox.DisabledState.Parent = this.NameDriver_Textbox;
            this.NameDriver_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameDriver_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.NameDriver_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameDriver_Textbox.FocusedState.Parent = this.NameDriver_Textbox;
            this.NameDriver_Textbox.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.NameDriver_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameDriver_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameDriver_Textbox.HoverState.Parent = this.NameDriver_Textbox;
            this.NameDriver_Textbox.Location = new System.Drawing.Point(30, 108);
            this.NameDriver_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameDriver_Textbox.Name = "NameDriver_Textbox";
            this.NameDriver_Textbox.PasswordChar = '\0';
            this.NameDriver_Textbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.NameDriver_Textbox.PlaceholderText = "Primer Nombre";
            this.NameDriver_Textbox.SelectedText = "";
            this.NameDriver_Textbox.ShadowDecoration.Parent = this.NameDriver_Textbox;
            this.NameDriver_Textbox.Size = new System.Drawing.Size(410, 43);
            this.NameDriver_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.NameDriver_Textbox.TabIndex = 4;
            this.NameDriver_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameDriver_Textbox_KeyPress);
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
            this.Save_Button.TabIndex = 13;
            this.Save_Button.Text = "Procesar / Guardar";
            this.Save_Button.Click += new System.EventHandler(this.BottomButtons);
            // 
            // RegisterDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 470);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.DateBornDriver_Picker);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.DateBornTitle_Label);
            this.Controls.Add(this.LastNDriver_Textbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameDriver_Textbox);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.IdentificationDriver_Textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterDriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterDriverForm_Load);
            this.Top_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel Top_Panel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Rezize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Minimize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Exit_Button;
        private System.Windows.Forms.Label Title_Form;
        private Guna.UI2.WinForms.Guna2DragControl From_Drag;
        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateBornDriver_Picker;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label DateBornTitle_Label;
        private Guna.UI2.WinForms.Guna2TextBox LastNDriver_Textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox IdentificationDriver_Textbox;
        private Guna.UI2.WinForms.Guna2GradientButton Cancel_Button;
        private Guna.UI2.WinForms.Guna2TextBox NameDriver_Textbox;
        private Guna.UI2.WinForms.Guna2GradientButton Save_Button;
    }
}