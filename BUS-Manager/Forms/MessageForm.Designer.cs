﻿
namespace BUS_Manager.Forms
{
    partial class MessageForm
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
            this.BodyMessage_Label_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.BodyMessage_Label = new System.Windows.Forms.Label();
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TitleMessage_Label = new System.Windows.Forms.Label();
            this.Yes_Button = new Guna.UI2.WinForms.Guna2Button();
            this.No_Button = new Guna.UI2.WinForms.Guna2Button();
            this.AutomaticlyCloseMessage_Timer = new System.Windows.Forms.Timer(this.components);
            this.TitleMessage_Label_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Form_Anim = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SuspendLayout();
            // 
            // BodyMessage_Label_Drag
            // 
            this.BodyMessage_Label_Drag.TargetControl = this.BodyMessage_Label;
            // 
            // BodyMessage_Label
            // 
            this.BodyMessage_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodyMessage_Label.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyMessage_Label.Location = new System.Drawing.Point(0, 58);
            this.BodyMessage_Label.Name = "BodyMessage_Label";
            this.BodyMessage_Label.Size = new System.Drawing.Size(457, 179);
            this.BodyMessage_Label.TabIndex = 1;
            this.BodyMessage_Label.Text = "BodyMessage_Label error";
            this.BodyMessage_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.BorderRadius = 30;
            this.Form_Elipse.TargetControl = this;
            // 
            // TitleMessage_Label
            // 
            this.TitleMessage_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleMessage_Label.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleMessage_Label.Location = new System.Drawing.Point(0, 2);
            this.TitleMessage_Label.Name = "TitleMessage_Label";
            this.TitleMessage_Label.Size = new System.Drawing.Size(456, 56);
            this.TitleMessage_Label.TabIndex = 0;
            this.TitleMessage_Label.Text = "TitleMessage_Label error";
            this.TitleMessage_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Yes_Button
            // 
            this.Yes_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Yes_Button.Animated = true;
            this.Yes_Button.BackColor = System.Drawing.Color.Transparent;
            this.Yes_Button.CheckedState.Parent = this.Yes_Button;
            this.Yes_Button.CustomImages.Parent = this.Yes_Button;
            this.Yes_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Yes_Button.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(233)))));
            this.Yes_Button.HoverState.Parent = this.Yes_Button;
            this.Yes_Button.Location = new System.Drawing.Point(0, 240);
            this.Yes_Button.Name = "Yes_Button";
            this.Yes_Button.ShadowDecoration.Parent = this.Yes_Button;
            this.Yes_Button.Size = new System.Drawing.Size(228, 45);
            this.Yes_Button.TabIndex = 2;
            this.Yes_Button.Text = "Si";
            this.Yes_Button.Click += new System.EventHandler(this.Yes_Button_Click);
            // 
            // No_Button
            // 
            this.No_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.No_Button.Animated = true;
            this.No_Button.CheckedState.Parent = this.No_Button;
            this.No_Button.CustomImages.Parent = this.No_Button;
            this.No_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(73)))), ((int)(((byte)(99)))));
            this.No_Button.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(233)))));
            this.No_Button.HoverState.Parent = this.No_Button;
            this.No_Button.Location = new System.Drawing.Point(228, 240);
            this.No_Button.Name = "No_Button";
            this.No_Button.ShadowDecoration.Parent = this.No_Button;
            this.No_Button.Size = new System.Drawing.Size(229, 45);
            this.No_Button.TabIndex = 3;
            this.No_Button.Text = "No";
            this.No_Button.Click += new System.EventHandler(this.No_Button_Click);
            // 
            // AutomaticlyCloseMessage_Timer
            // 
            this.AutomaticlyCloseMessage_Timer.Enabled = true;
            this.AutomaticlyCloseMessage_Timer.Interval = 1000;
            this.AutomaticlyCloseMessage_Timer.Tick += new System.EventHandler(this.AutomaticlyCloseMessage_Timer_Tick);
            // 
            // TitleMessage_Label_Drag
            // 
            this.TitleMessage_Label_Drag.TargetControl = this.TitleMessage_Label;
            // 
            // Form_Anim
            // 
            this.Form_Anim.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.Form_Anim.Interval = 800;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(458, 286);
            this.Controls.Add(this.Yes_Button);
            this.Controls.Add(this.BodyMessage_Label);
            this.Controls.Add(this.TitleMessage_Label);
            this.Controls.Add(this.No_Button);
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MessageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MessageForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl BodyMessage_Label_Drag;
        private Guna.UI2.WinForms.Guna2Button Yes_Button;
        private System.Windows.Forms.Label BodyMessage_Label;
        private System.Windows.Forms.Label TitleMessage_Label;
        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2Button No_Button;
        private System.Windows.Forms.Timer AutomaticlyCloseMessage_Timer;
        private Guna.UI2.WinForms.Guna2DragControl TitleMessage_Label_Drag;
        public Guna.UI2.WinForms.Guna2AnimateWindow Form_Anim;
    }
}