﻿namespace FatiIkhlassYoun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitre = new Label();
            tabPage2 = new TabPage();
            txtPassword = new Label();
            cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            showPassbtn = new CuoreUI.Controls.cuiCheckbox();
            btnForgotPassword = new CuoreUI.Controls.cuiButton();
            txtUsername = new Label();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            label2 = new Label();
            cuiBorder1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.BackColor = Color.WhiteSmoke;
            labelTitre.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitre.ForeColor = Color.Black;
            labelTitre.Location = new Point(78, 50);
            labelTitre.Margin = new Padding(6, 0, 6, 0);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(1246, 82);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "PROJECT MANAGEMENT SYSTEM";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(292, 100);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(96, 515);
            txtPassword.Margin = new Padding(6, 0, 6, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 74);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Password";
            txtPassword.Click += label1_Click;
            // 
            // cuiBorder1
            // 
            cuiBorder1.BackColor = Color.WhiteSmoke;
            cuiBorder1.Controls.Add(label2);
            cuiBorder1.Controls.Add(label1);
            cuiBorder1.Controls.Add(textBox2);
            cuiBorder1.Controls.Add(textBox1);
            cuiBorder1.Controls.Add(labelTitre);
            cuiBorder1.Controls.Add(button1);
            cuiBorder1.Controls.Add(showPassbtn);
            cuiBorder1.Controls.Add(btnForgotPassword);
            cuiBorder1.Controls.Add(txtUsername);
            cuiBorder1.Controls.Add(txtPassword);
            cuiBorder1.Location = new Point(404, 104);
            cuiBorder1.Margin = new Padding(6, 6, 6, 6);
            cuiBorder1.Name = "cuiBorder1";
            cuiBorder1.OutlineThickness = 1F;
            cuiBorder1.PanelColor = Color.WhiteSmoke;
            cuiBorder1.PanelOutlineColor = Color.Black;
            cuiBorder1.Rounding = new Padding(10);
            cuiBorder1.Size = new Size(1206, 970);
            cuiBorder1.TabIndex = 3;
            cuiBorder1.Paint += cuiBorder1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(510, 236);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 82);
            label1.TabIndex = 12;
            label1.Text = "LOGIN";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(510, 524);
            textBox2.Margin = new Padding(16, 15, 16, 15);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '●';
            textBox2.Size = new Size(562, 61);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(510, 396);
            textBox1.Margin = new Padding(16, 15, 16, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(562, 61);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(730, 760);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(346, 121);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // showPassbtn
            // 
            showPassbtn.Checked = false;
            showPassbtn.CheckedForeground = Color.FromArgb(30, 42, 56);
            showPassbtn.CheckedOutlineColor = Color.FromArgb(30, 42, 56);
            showPassbtn.CheckedSymbolColor = Color.White;
            showPassbtn.Content = "Show password";
            showPassbtn.Cursor = Cursors.Hand;
            showPassbtn.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPassbtn.ForeColor = SystemColors.ActiveCaptionText;
            showPassbtn.Location = new Point(754, 620);
            showPassbtn.Margin = new Padding(16, 15, 16, 15);
            showPassbtn.MinimumSize = new Size(32, 31);
            showPassbtn.Name = "showPassbtn";
            showPassbtn.OutlineStyle = true;
            showPassbtn.OutlineThickness = 1F;
            showPassbtn.Rounding = 5;
            showPassbtn.ShowSymbols = true;
            showPassbtn.Size = new Size(322, 61);
            showPassbtn.TabIndex = 8;
            showPassbtn.Text = "cuiCheckbox1";
            showPassbtn.UncheckedForeground = Color.FromArgb(34, 34, 34);
            showPassbtn.UncheckedOutlineColor = Color.FromArgb(34, 34, 34);
            showPassbtn.UncheckedSymbolColor = Color.FromArgb(64, 255, 255, 255);
            showPassbtn.Click += showPassbtn_Click;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = Color.WhiteSmoke;
            btnForgotPassword.CausesValidation = false;
            btnForgotPassword.CheckButton = false;
            btnForgotPassword.Checked = false;
            btnForgotPassword.CheckedBackground = Color.White;
            btnForgotPassword.CheckedForeColor = Color.White;
            btnForgotPassword.CheckedImageTint = Color.White;
            btnForgotPassword.CheckedOutline = Color.White;
            btnForgotPassword.Content = "Forgot password";
            btnForgotPassword.Cursor = Cursors.Hand;
            btnForgotPassword.DialogResult = DialogResult.None;
            btnForgotPassword.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnForgotPassword.ForeColor = Color.Black;
            btnForgotPassword.HoverBackground = Color.WhiteSmoke;
            btnForgotPassword.HoveredImageTint = Color.WhiteSmoke;
            btnForgotPassword.HoverForeColor = Color.Black;
            btnForgotPassword.HoverOutline = Color.Empty;
            btnForgotPassword.Image = null;
            btnForgotPassword.ImageAutoCenter = true;
            btnForgotPassword.ImageExpand = new Point(0, 0);
            btnForgotPassword.ImageOffset = new Point(0, 0);
            btnForgotPassword.ImageTint = Color.WhiteSmoke;
            btnForgotPassword.Location = new Point(46, 760);
            btnForgotPassword.Margin = new Padding(6, 6, 6, 6);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.NormalBackground = Color.WhiteSmoke;
            btnForgotPassword.NormalOutline = Color.Empty;
            btnForgotPassword.OutlineThickness = 1.6F;
            btnForgotPassword.PressedBackground = Color.WhiteSmoke;
            btnForgotPassword.PressedForeColor = Color.Black;
            btnForgotPassword.PressedImageTint = Color.WhiteSmoke;
            btnForgotPassword.PressedOutline = Color.WhiteSmoke;
            btnForgotPassword.Rounding = new Padding(8);
            btnForgotPassword.Size = new Size(322, 100);
            btnForgotPassword.TabIndex = 7;
            btnForgotPassword.TextOffset = new Point(0, 0);
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(96, 386);
            txtUsername.Margin = new Padding(6, 0, 6, 0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(288, 74);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "Username";
            // 
            // cuiButton2
            // 
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.Gray;
            cuiButton2.CheckedForeColor = Color.DimGray;
            cuiButton2.CheckedImageTint = Color.Gainsboro;
            cuiButton2.CheckedOutline = Color.Silver;
            cuiButton2.Content = "x";
            cuiButton2.Cursor = Cursors.Hand;
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = Color.Black;
            cuiButton2.HoverBackground = Color.DimGray;
            cuiButton2.HoveredImageTint = Color.DarkGray;
            cuiButton2.HoverForeColor = Color.LightGray;
            cuiButton2.HoverOutline = Color.Empty;
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.ImageTint = Color.White;
            cuiButton2.Location = new Point(1908, 23);
            cuiButton2.Margin = new Padding(6, 6, 6, 6);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.White;
            cuiButton2.NormalOutline = Color.Empty;
            cuiButton2.OutlineThickness = 1.6F;
            cuiButton2.PressedBackground = Color.FromArgb(30, 42, 56);
            cuiButton2.PressedForeColor = Color.White;
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.Empty;
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(84, 79);
            cuiButton2.TabIndex = 9;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(808, 236);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(264, 82);
            label2.TabIndex = 13;
            label2.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2048, 1183);
            Controls.Add(cuiButton2);
            Controls.Add(cuiBorder1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ikhlasse";
            Load += Form1_Load;
            cuiBorder1.ResumeLayout(false);
            cuiBorder1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelTitre;
        private TabPage tabPage2;
        private Label txtPassword;
        private CuoreUI.Controls.cuiBorder cuiBorder1;
        private Label txtUsername;
        private CuoreUI.Controls.cuiButton btnForgotPassword;
        private CuoreUI.Controls.cuiCheckbox showPassbtn;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}
