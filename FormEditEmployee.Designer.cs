namespace FatiIkhlassYoun
{
    partial class FormEditEmployee
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
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblOldPassword = new Label();
            txtOldPassword = new TextBox();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblRole = new Label();
            cbRole = new ComboBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblActive = new Label();
            chkActive = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.Location = new Point(316, 265);
            lblUsername.Margin = new Padding(10, 0, 10, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(208, 48);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(808, 265);
            txtUsername.Margin = new Padding(10, 11, 10, 11);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(657, 55);
            txtUsername.TabIndex = 2;
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOldPassword.Location = new Point(316, 376);
            lblOldPassword.Margin = new Padding(10, 0, 10, 0);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(268, 48);
            lblOldPassword.TabIndex = 3;
            lblOldPassword.Text = "Old Password :";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(808, 376);
            txtOldPassword.Margin = new Padding(10, 11, 10, 11);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(657, 55);
            txtOldPassword.TabIndex = 4;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNewPassword.Location = new Point(316, 487);
            lblNewPassword.Margin = new Padding(10, 0, 10, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(285, 48);
            lblNewPassword.TabIndex = 5;
            lblNewPassword.Text = "New Password :";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(808, 487);
            txtNewPassword.Margin = new Padding(10, 11, 10, 11);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(657, 55);
            txtNewPassword.TabIndex = 6;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConfirmPassword.Location = new Point(316, 598);
            lblConfirmPassword.Margin = new Padding(10, 0, 10, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(346, 48);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Confirm Password :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(808, 598);
            txtConfirmPassword.Margin = new Padding(10, 11, 10, 11);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(657, 55);
            txtConfirmPassword.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(316, 709);
            lblEmail.Margin = new Padding(10, 0, 10, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(121, 48);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(808, 708);
            txtEmail.Margin = new Padding(10, 11, 10, 11);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(657, 55);
            txtEmail.TabIndex = 10;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRole.Location = new Point(316, 819);
            lblRole.Margin = new Padding(10, 0, 10, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(114, 48);
            lblRole.TabIndex = 11;
            lblRole.Text = "Role :";
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "admin", "chef_projet", "chef_equipe", "membre" });
            cbRole.Location = new Point(808, 819);
            cbRole.Margin = new Padding(10, 11, 10, 11);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(657, 56);
            cbRole.TabIndex = 12;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone.Location = new Point(316, 930);
            lblPhone.Margin = new Padding(10, 0, 10, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(295, 48);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Phone Number :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(808, 930);
            txtPhone.Margin = new Padding(10, 11, 10, 11);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(657, 55);
            txtPhone.TabIndex = 14;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblActive.Location = new Point(316, 1041);
            lblActive.Margin = new Padding(10, 0, 10, 0);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(182, 48);
            lblActive.TabIndex = 15;
            lblActive.Text = "Is Active :";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(819, 1048);
            chkActive.Margin = new Padding(10, 11, 10, 11);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(42, 41);
            chkActive.TabIndex = 16;
            chkActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(1033, 1320);
            btnSave.Margin = new Padding(10, 11, 10, 11);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(333, 111);
            btnSave.TabIndex = 17;
            btnSave.Text = "Update";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(605, 1320);
            btnCancel.Margin = new Padding(10, 11, 10, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(300, 111);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(518, 70);
            label1.TabIndex = 21;
            label1.Text = "Edit Employee Info :";
            // 
            // FormEditEmployee
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1741, 1548);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkActive);
            Controls.Add(lblActive);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(cbRole);
            Controls.Add(lblRole);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(lblOldPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(10, 11, 10, 11);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Load += FormEditEmployee_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private Label label1;
    }

       

    }
