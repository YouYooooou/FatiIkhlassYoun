namespace FatiIkhlassYoun
{
    partial class FormEditTask
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
            cmbProject = new ComboBox();
            label2 = new Label();
            buttonAnnuler = new Button();
            clbAssignedUsers = new CheckedListBox();
            Membreasignedlabel = new Label();
            cmbPriority = new ComboBox();
            cmbTeamLead = new ComboBox();
            numEstimatedTime = new NumericUpDown();
            Prioritylabel = new Label();
            TeamLeaderlabel = new Label();
            EstimatedtimeLabel = new Label();
            desclabel = new Label();
            Startdatelabel = new Label();
            cmbStatus = new ComboBox();
            dtpStartDate = new DateTimePicker();
            dtpDueDate = new DateTimePicker();
            buttonUpdateTask = new Button();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            Statuslabel = new Label();
            DueTimelabel = new Label();
            Titlelabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numEstimatedTime).BeginInit();
            SuspendLayout();
            // 
            // cmbProject
            // 
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(815, 167);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(528, 56);
            cmbProject.TabIndex = 77;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(351, 146);
            label2.Name = "label2";
            label2.Size = new Size(168, 48);
            label2.TabIndex = 76;
            label2.Text = " Project :";
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.BackColor = Color.Red;
            buttonAnnuler.FlatStyle = FlatStyle.Flat;
            buttonAnnuler.Location = new Point(989, 1519);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(265, 113);
            buttonAnnuler.TabIndex = 75;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = false;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // clbAssignedUsers
            // 
            clbAssignedUsers.FormattingEnabled = true;
            clbAssignedUsers.Location = new Point(815, 1287);
            clbAssignedUsers.Name = "clbAssignedUsers";
            clbAssignedUsers.Size = new Size(534, 166);
            clbAssignedUsers.TabIndex = 74;
            clbAssignedUsers.SelectedIndexChanged += clbAssignedUsers_SelectedIndexChanged;
            // 
            // Membreasignedlabel
            // 
            Membreasignedlabel.AutoSize = true;
            Membreasignedlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Membreasignedlabel.Location = new Point(351, 1324);
            Membreasignedlabel.Name = "Membreasignedlabel";
            Membreasignedlabel.Size = new Size(347, 48);
            Membreasignedlabel.TabIndex = 73;
            Membreasignedlabel.Text = "Membres assignés :";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(815, 1138);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(528, 56);
            cmbPriority.TabIndex = 72;
            // 
            // cmbTeamLead
            // 
            cmbTeamLead.FormattingEnabled = true;
            cmbTeamLead.Location = new Point(815, 1023);
            cmbTeamLead.Name = "cmbTeamLead";
            cmbTeamLead.Size = new Size(528, 56);
            cmbTeamLead.TabIndex = 71;
            // 
            // numEstimatedTime
            // 
            numEstimatedTime.Location = new Point(815, 909);
            numEstimatedTime.Name = "numEstimatedTime";
            numEstimatedTime.Size = new Size(528, 55);
            numEstimatedTime.TabIndex = 70;
            // 
            // Prioritylabel
            // 
            Prioritylabel.AutoSize = true;
            Prioritylabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Prioritylabel.Location = new Point(351, 1162);
            Prioritylabel.Name = "Prioritylabel";
            Prioritylabel.Size = new Size(165, 48);
            Prioritylabel.TabIndex = 69;
            Prioritylabel.Text = "Priority :";
            // 
            // TeamLeaderlabel
            // 
            TeamLeaderlabel.AutoSize = true;
            TeamLeaderlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TeamLeaderlabel.Location = new Point(351, 1032);
            TeamLeaderlabel.Name = "TeamLeaderlabel";
            TeamLeaderlabel.Size = new Size(250, 48);
            TeamLeaderlabel.TabIndex = 68;
            TeamLeaderlabel.Text = "Team Leader :";
            // 
            // EstimatedtimeLabel
            // 
            EstimatedtimeLabel.AutoSize = true;
            EstimatedtimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EstimatedtimeLabel.Location = new Point(351, 902);
            EstimatedtimeLabel.Name = "EstimatedtimeLabel";
            EstimatedtimeLabel.Size = new Size(299, 48);
            EstimatedtimeLabel.TabIndex = 67;
            EstimatedtimeLabel.Text = "Estimated Time :";
            // 
            // desclabel
            // 
            desclabel.AutoSize = true;
            desclabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            desclabel.Location = new Point(351, 382);
            desclabel.Name = "desclabel";
            desclabel.Size = new Size(233, 48);
            desclabel.TabIndex = 66;
            desclabel.Text = "Description :";
            // 
            // Startdatelabel
            // 
            Startdatelabel.AutoSize = true;
            Startdatelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Startdatelabel.Location = new Point(351, 512);
            Startdatelabel.Name = "Startdatelabel";
            Startdatelabel.Size = new Size(210, 48);
            Startdatelabel.TabIndex = 65;
            Startdatelabel.Text = "Start Date :";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(815, 772);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(528, 56);
            cmbStatus.TabIndex = 64;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(821, 585);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(528, 55);
            dtpStartDate.TabIndex = 63;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(815, 680);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(528, 55);
            dtpDueDate.TabIndex = 62;
            // 
            // buttonUpdateTask
            // 
            buttonUpdateTask.BackColor = Color.LimeGreen;
            buttonUpdateTask.FlatStyle = FlatStyle.Flat;
            buttonUpdateTask.Location = new Point(1402, 1519);
            buttonUpdateTask.Name = "buttonUpdateTask";
            buttonUpdateTask.Size = new Size(422, 113);
            buttonUpdateTask.TabIndex = 61;
            buttonUpdateTask.Text = "Update";
            buttonUpdateTask.UseVisualStyleBackColor = false;
            buttonUpdateTask.Click += buttonUpdateTask_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(815, 260);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(528, 55);
            txtTitle.TabIndex = 60;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(815, 374);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(528, 157);
            txtDescription.TabIndex = 59;
            // 
            // Statuslabel
            // 
            Statuslabel.AutoSize = true;
            Statuslabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Statuslabel.Location = new Point(351, 772);
            Statuslabel.Name = "Statuslabel";
            Statuslabel.Size = new Size(144, 48);
            Statuslabel.TabIndex = 58;
            Statuslabel.Text = "Status :";
            // 
            // DueTimelabel
            // 
            DueTimelabel.AutoSize = true;
            DueTimelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DueTimelabel.Location = new Point(351, 642);
            DueTimelabel.Name = "DueTimelabel";
            DueTimelabel.Size = new Size(197, 48);
            DueTimelabel.TabIndex = 57;
            DueTimelabel.Text = "Due Date :";
            // 
            // Titlelabel
            // 
            Titlelabel.AutoSize = true;
            Titlelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Titlelabel.Location = new Point(351, 252);
            Titlelabel.Name = "Titlelabel";
            Titlelabel.Size = new Size(114, 48);
            Titlelabel.TabIndex = 56;
            Titlelabel.Text = "Title :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(78, 33);
            label1.Name = "label1";
            label1.Size = new Size(469, 70);
            label1.TabIndex = 55;
            label1.Text = "Modify Task Info :";
            // 
            // FormEditTask
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1932, 1675);
            Controls.Add(cmbProject);
            Controls.Add(label2);
            Controls.Add(buttonAnnuler);
            Controls.Add(clbAssignedUsers);
            Controls.Add(Membreasignedlabel);
            Controls.Add(cmbPriority);
            Controls.Add(cmbTeamLead);
            Controls.Add(numEstimatedTime);
            Controls.Add(Prioritylabel);
            Controls.Add(TeamLeaderlabel);
            Controls.Add(EstimatedtimeLabel);
            Controls.Add(desclabel);
            Controls.Add(Startdatelabel);
            Controls.Add(cmbStatus);
            Controls.Add(dtpStartDate);
            Controls.Add(dtpDueDate);
            Controls.Add(buttonUpdateTask);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(Statuslabel);
            Controls.Add(DueTimelabel);
            Controls.Add(Titlelabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditTask";
            Text = "FormEditTask";
            Load += FormEditTask_Load;
            ((System.ComponentModel.ISupportInitialize)numEstimatedTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProject;
        private Label label2;
        private Button buttonAnnuler;
        private CheckedListBox clbAssignedUsers;
        private Label Membreasignedlabel;
        private ComboBox cmbPriority;
        private ComboBox cmbTeamLead;
        private NumericUpDown numEstimatedTime;
        private Label Prioritylabel;
        private Label TeamLeaderlabel;
        private Label EstimatedtimeLabel;
        private Label desclabel;
        private Label Startdatelabel;
        private ComboBox cmbStatus;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpDueDate;
        private Button buttonUpdateTask;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Label Statuslabel;
        private Label DueTimelabel;
        private Label Titlelabel;
        private Label label1;
    }
}