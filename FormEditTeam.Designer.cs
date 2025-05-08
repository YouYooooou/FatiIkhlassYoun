namespace FatiIkhlassYoun
{
    partial class FormEditTeam
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
            lblTeamName = new Label();
            txtTeamName = new TextBox();
            lblProject = new Label();
            cmbProject = new ComboBox();
            lblLeader = new Label();
            cmbLeader = new ComboBox();
            lblMembers = new Label();
            clbMembers = new CheckedListBox();
            label1 = new Label();
            btnCancel = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // lblTeamName
            // 
            lblTeamName.AutoSize = true;
            lblTeamName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTeamName.Location = new Point(199, 234);
            lblTeamName.Margin = new Padding(10, 0, 10, 0);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(139, 48);
            lblTeamName.TabIndex = 1;
            lblTeamName.Text = "Name :";
            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(619, 222);
            txtTeamName.Margin = new Padding(10, 11, 10, 11);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(657, 55);
            txtTeamName.TabIndex = 2;
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProject.Location = new Point(199, 344);
            lblProject.Margin = new Padding(10, 0, 10, 0);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(348, 48);
            lblProject.TabIndex = 3;
            lblProject.Text = "Project Associated :";
            // 
            // cmbProject
            // 
            cmbProject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(619, 333);
            cmbProject.Margin = new Padding(10, 11, 10, 11);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(657, 56);
            cmbProject.TabIndex = 4;
            // 
            // lblLeader
            // 
            lblLeader.AutoSize = true;
            lblLeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLeader.Location = new Point(199, 455);
            lblLeader.Margin = new Padding(10, 0, 10, 0);
            lblLeader.Name = "lblLeader";
            lblLeader.Size = new Size(250, 48);
            lblLeader.TabIndex = 5;
            lblLeader.Text = "Team Leader :";
            // 
            // cmbLeader
            // 
            cmbLeader.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLeader.FormattingEnabled = true;
            cmbLeader.Location = new Point(619, 444);
            cmbLeader.Margin = new Padding(10, 11, 10, 11);
            cmbLeader.Name = "cmbLeader";
            cmbLeader.Size = new Size(657, 56);
            cmbLeader.TabIndex = 6;
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMembers.Location = new Point(199, 566);
            lblMembers.Margin = new Padding(10, 0, 10, 0);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(295, 48);
            lblMembers.TabIndex = 7;
            lblMembers.Text = "Team members :";
            // 
            // clbMembers
            // 
            clbMembers.FormattingEnabled = true;
            clbMembers.Location = new Point(619, 566);
            clbMembers.Margin = new Padding(10, 11, 10, 11);
            clbMembers.Name = "clbMembers";
            clbMembers.Size = new Size(657, 490);
            clbMembers.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(53, 41);
            label1.Name = "label1";
            label1.Size = new Size(492, 70);
            label1.TabIndex = 32;
            label1.Text = "Modify Team Info :";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(659, 1138);
            btnCancel.Margin = new Padding(10, 11, 10, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(267, 111);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LimeGreen;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(1018, 1137);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(265, 113);
            buttonSave.TabIndex = 48;
            buttonSave.Text = "Update ";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormEditTeam
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1667, 1292);
            Controls.Add(btnCancel);
            Controls.Add(buttonSave);
            Controls.Add(label1);
            Controls.Add(clbMembers);
            Controls.Add(lblMembers);
            Controls.Add(cmbLeader);
            Controls.Add(lblLeader);
            Controls.Add(cmbProject);
            Controls.Add(lblProject);
            Controls.Add(txtTeamName);
            Controls.Add(lblTeamName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(10, 11, 10, 11);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditTeam";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modifier l'équipe";
            Load += FormEditTeam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label lblLeader;
        private System.Windows.Forms.ComboBox cmbLeader;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.CheckedListBox clbMembers;
        private Label label1;
        private Button btnCancel;
        private Button buttonSave;
    }
}
       
