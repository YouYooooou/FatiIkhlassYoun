
namespace FatiIkhlassYoun
{
    partial class FormAddEmployee
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtPhone = new TextBox();
            cmbRole = new ComboBox();
            buttonSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(62, 80);
            label1.Name = "label1";
            label1.Size = new Size(409, 70);
            label1.TabIndex = 0;
            label1.Text = "Employee Info :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(342, 281);
            label2.Name = "label2";
            label2.Size = new Size(208, 48);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(342, 408);
            label3.Name = "label3";
            label3.Size = new Size(199, 48);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(342, 525);
            label4.Name = "label4";
            label4.Size = new Size(131, 48);
            label4.TabIndex = 3;
            label4.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(342, 678);
            label5.Name = "label5";
            label5.Size = new Size(94, 48);
            label5.TabIndex = 4;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(342, 817);
            label6.Name = "label6";
            label6.Size = new Size(295, 48);
            label6.TabIndex = 5;
            label6.Text = "Phone Number :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(791, 518);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(465, 55);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(791, 387);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(465, 55);
            txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(791, 274);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(465, 55);
            txtUsername.TabIndex = 8;
            txtUsername.TextChanged += textBox3_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(801, 810);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(444, 55);
            txtPhone.TabIndex = 9;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(791, 678);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(465, 56);
            cmbRole.TabIndex = 10;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LimeGreen;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(1118, 985);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(265, 113);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(692, 985);
            btnCancel.Margin = new Padding(10, 11, 10, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(267, 111);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormAddEmployee
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1515, 1175);
            Controls.Add(btnCancel);
            Controls.Add(buttonSave);
            Controls.Add(cmbRole);
            Controls.Add(txtPhone);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddEmployee";
            Text = "FormAddEmployee";
            Load += FormAddEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Le nom d'utilisateur ne peut pas être vide.");
            }
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtPhone;
        private ComboBox cmbRole;
        private Button buttonSave;
        private Button btnCancel;
    }
}