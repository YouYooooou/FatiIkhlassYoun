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
            checkedListBoxMembers = new CheckedListBox();
            comboBoxProject = new ComboBox();
            comboBoxLeader = new ComboBox();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            txtTeamName = new TextBox();
            Title = new Label();
            label1 = new Label();
            buttonAnnuler = new Button();
            buttonCreateTask = new Button();
            SuspendLayout();
            // 
            // checkedListBoxMembers
            // 
            checkedListBoxMembers.FormattingEnabled = true;
            checkedListBoxMembers.Location = new Point(716, 478);
            checkedListBoxMembers.Name = "checkedListBoxMembers";
            checkedListBoxMembers.Size = new Size(360, 112);
            checkedListBoxMembers.TabIndex = 55;
            // 
            // comboBoxProject
            // 
            comboBoxProject.FormattingEnabled = true;
            comboBoxProject.Location = new Point(728, 657);
            comboBoxProject.Name = "comboBoxProject";
            comboBoxProject.Size = new Size(360, 56);
            comboBoxProject.TabIndex = 54;
            // 
            // comboBoxLeader
            // 
            comboBoxLeader.FormattingEnabled = true;
            comboBoxLeader.Location = new Point(713, 333);
            comboBoxLeader.Name = "comboBoxLeader";
            comboBoxLeader.Size = new Size(360, 56);
            comboBoxLeader.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(247, 665);
            label3.Name = "label3";
            label3.Size = new Size(342, 48);
            label3.TabIndex = 52;
            label3.Text = "Project associated :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(247, 341);
            label7.Name = "label7";
            label7.Size = new Size(260, 48);
            label7.TabIndex = 51;
            label7.Text = "Team Leader  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(247, 498);
            label2.Name = "label2";
            label2.Size = new Size(296, 48);
            label2.TabIndex = 50;
            label2.Text = "Team Members :";
            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(684, 202);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(360, 55);
            txtTeamName.TabIndex = 49;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Title.Location = new Point(247, 209);
            Title.Name = "Title";
            Title.Size = new Size(225, 48);
            Title.TabIndex = 48;
            Title.Text = "New Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(68, 24);
            label1.Name = "label1";
            label1.Size = new Size(492, 70);
            label1.TabIndex = 47;
            label1.Text = "Modify Team Info :";
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.BackColor = Color.Red;
            buttonAnnuler.FlatStyle = FlatStyle.Flat;
            buttonAnnuler.Location = new Point(446, 864);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(265, 113);
            buttonAnnuler.TabIndex = 77;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = false;
            // 
            // buttonCreateTask
            // 
            buttonCreateTask.BackColor = Color.LimeGreen;
            buttonCreateTask.FlatStyle = FlatStyle.Flat;
            buttonCreateTask.Location = new Point(859, 864);
            buttonCreateTask.Name = "buttonCreateTask";
            buttonCreateTask.Size = new Size(422, 113);
            buttonCreateTask.TabIndex = 76;
            buttonCreateTask.Text = "Update";
            buttonCreateTask.UseVisualStyleBackColor = false;
            // 
            // FormEditTeam
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1432, 1108);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonCreateTask);
            Controls.Add(checkedListBoxMembers);
            Controls.Add(comboBoxProject);
            Controls.Add(comboBoxLeader);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(txtTeamName);
            Controls.Add(Title);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditTeam";
            Text = "FormEditTeam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxMembers;
        private ComboBox comboBoxProject;
        private ComboBox comboBoxLeader;
        private Label label3;
        private Label label7;
        private Label label2;
        private TextBox txtTeamName;
        private Label Title;
        private Label label1;
        private Button buttonAnnuler;
        private Button buttonCreateTask;
    }
}