
namespace BUS_Manager.Forms.SubForms
{
    partial class ViewDriverForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Driver_DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirAlFormularioAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Top_Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Title_Form = new System.Windows.Forms.Label();
            this.Rezize_Button = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Minimize_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.From_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.VoidUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Driver_DataGridView)).BeginInit();
            this.ContextMenu.SuspendLayout();
            this.Top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Driver_DataGridView
            // 
            this.Driver_DataGridView.AllowUserToAddRows = false;
            this.Driver_DataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Driver_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Driver_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Driver_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Driver_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Driver_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Driver_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Driver_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Driver_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Driver_DataGridView.ColumnHeadersHeight = 4;
            this.Driver_DataGridView.ContextMenuStrip = this.ContextMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Driver_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Driver_DataGridView.EnableHeadersVisualStyles = false;
            this.Driver_DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.Driver_DataGridView.Location = new System.Drawing.Point(0, 29);
            this.Driver_DataGridView.Name = "Driver_DataGridView";
            this.Driver_DataGridView.ReadOnly = true;
            this.Driver_DataGridView.RowHeadersVisible = false;
            this.Driver_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Driver_DataGridView.Size = new System.Drawing.Size(800, 421);
            this.Driver_DataGridView.TabIndex = 0;
            this.Driver_DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.Driver_DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Driver_DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Driver_DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Driver_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Driver_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Driver_DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Driver_DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.Driver_DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Driver_DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Driver_DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Driver_DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Driver_DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Driver_DataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.Driver_DataGridView.ThemeStyle.ReadOnly = true;
            this.Driver_DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Driver_DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Driver_DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Driver_DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Driver_DataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.Driver_DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.Driver_DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.salirAlFormularioAnteriorToolStripMenuItem,
            this.toolStripMenuItem2});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(217, 54);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // salirAlFormularioAnteriorToolStripMenuItem
            // 
            this.salirAlFormularioAnteriorToolStripMenuItem.Name = "salirAlFormularioAnteriorToolStripMenuItem";
            this.salirAlFormularioAnteriorToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.salirAlFormularioAnteriorToolStripMenuItem.Text = "Salir al formulario principal";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
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
            this.Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.ShadowDecoration.Parent = this.Top_Panel;
            this.Top_Panel.Size = new System.Drawing.Size(800, 28);
            this.Top_Panel.TabIndex = 2;
            // 
            // Title_Form
            // 
            this.Title_Form.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title_Form.AutoSize = true;
            this.Title_Form.BackColor = System.Drawing.Color.Transparent;
            this.Title_Form.Enabled = false;
            this.Title_Form.Font = new System.Drawing.Font("Ubuntu Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Form.Location = new System.Drawing.Point(276, 0);
            this.Title_Form.Name = "Title_Form";
            this.Title_Form.Size = new System.Drawing.Size(261, 24);
            this.Title_Form.TabIndex = 0;
            this.Title_Form.Text = "Bus Manager - Vista Choferes";
            this.Title_Form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Rezize_Button.Location = new System.Drawing.Point(717, 4);
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
            this.Minimize_Button.Location = new System.Drawing.Point(755, 5);
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
            this.Exit_Button.Location = new System.Drawing.Point(775, 5);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(18, 18);
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.UseTransparentBackground = true;
            this.Exit_Button.Click += new System.EventHandler(this.FormControl);
            // 
            // From_Drag
            // 
            this.From_Drag.TargetControl = this.Top_Panel;
            // 
            // VoidUpdate
            // 
            this.VoidUpdate.Enabled = true;
            this.VoidUpdate.Interval = 1000;
            this.VoidUpdate.Tick += new System.EventHandler(this.VoidUpdate_Tick);
            // 
            // ViewDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Driver_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewDriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Driver_DataGridView)).EndInit();
            this.ContextMenu.ResumeLayout(false);
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Driver_DataGridView;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Top_Panel;
        private System.Windows.Forms.Label Title_Form;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Rezize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Minimize_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Exit_Button;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirAlFormularioAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private Guna.UI2.WinForms.Guna2DragControl From_Drag;
        private System.Windows.Forms.Timer VoidUpdate;
    }
}