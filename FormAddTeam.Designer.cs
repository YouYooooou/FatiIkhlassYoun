namespace FatiIkhlassYoun
{
    partial class FormAddTeam
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
            buttonSave = new Button();
            label1 = new Label();
            Title = new Label();
            txtTeamName = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label3 = new Label();
            comboBoxLeader = new ComboBox();
            comboBoxProject = new ComboBox();
            checkedListBoxMembers = new CheckedListBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LimeGreen;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(1763, 1019);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(265, 113);
            buttonSave.TabIndex = 37;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(121, 59);
            label1.Name = "label1";
            label1.Size = new Size(300, 70);
            label1.TabIndex = 31;
            label1.Text = "Team Info :";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Title.Location = new Point(364, 344);
            Title.Name = "Title";
            Title.Size = new Size(139, 48);
            Title.TabIndex = 32;
            Title.Text = "Name :";
            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(801, 337);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(360, 55);
            txtTeamName.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(364, 633);
            label2.Name = "label2";
            label2.Size = new Size(296, 48);
            label2.TabIndex = 41;
            label2.Text = "Team Members :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(364, 476);
            label7.Name = "label7";
            label7.Size = new Size(260, 48);
            label7.TabIndex = 42;
            label7.Text = "Team Leader  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(364, 800);
            label3.Name = "label3";
            label3.Size = new Size(342, 48);
            label3.TabIndex = 43;
            label3.Text = "Project associated :";
            // 
            // comboBoxLeader
            // 
            comboBoxLeader.FormattingEnabled = true;
            comboBoxLeader.Location = new Point(830, 468);
            comboBoxLeader.Name = "comboBoxLeader";
            comboBoxLeader.Size = new Size(360, 56);
            comboBoxLeader.TabIndex = 44;
            // 
            // comboBoxProject
            // 
            comboBoxProject.FormattingEnabled = true;
            comboBoxProject.Location = new Point(845, 792);
            comboBoxProject.Name = "comboBoxProject";
            comboBoxProject.Size = new Size(360, 56);
            comboBoxProject.TabIndex = 45;
            // 
            // checkedListBoxMembers
            // 
            checkedListBoxMembers.FormattingEnabled = true;
            checkedListBoxMembers.Location = new Point(833, 613);
            checkedListBoxMembers.Name = "checkedListBoxMembers";
            checkedListBoxMembers.Size = new Size(360, 112);
            checkedListBoxMembers.TabIndex = 46;
            // 
            // FormAddTeam
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(2151, 1275);
            Controls.Add(checkedListBoxMembers);
            Controls.Add(comboBoxProject);
            Controls.Add(comboBoxLeader);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(buttonSave);
            Controls.Add(txtTeamName);
            Controls.Add(Title);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddTeam";
            Text = "FormAddTeam";
            Load += FormAddTeam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSave;
        private Label label1;
        private Label Title;
        private TextBox txtTeamName;
        private Label label2;
        private Label label7;
        private Label label3;
        private ComboBox comboBoxLeader;
        private ComboBox comboBoxProject;
        private CheckedListBox checkedListBoxMembers;
    }
}