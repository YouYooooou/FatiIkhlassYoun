
using System.Data;
using System.Data.SqlClient;

namespace FatiIkhlassYoun
{
    partial class FormAddTask
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
            EstimatedtimeLabel = new Label();
            desclabel = new Label();
            Startdatelabel = new Label();
            cmbStatus = new ComboBox();
            dtpStartDate = new DateTimePicker();
            dtpDueDate = new DateTimePicker();
            buttonCreateTask = new Button();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            Statuslabel = new Label();
            DueTimelabel = new Label();
            Titlelabel = new Label();
            label1 = new Label();
            TeamLeaderlabel = new Label();
            Prioritylabel = new Label();
            numEstimatedTime = new NumericUpDown();
            cmbTeamLead = new ComboBox();
            cmbPriority = new ComboBox();
            Membreasignedlabel = new Label();
            clbAssignedUsers = new CheckedListBox();
            buttonAnnuler = new Button();
            cmbProject = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numEstimatedTime).BeginInit();
            SuspendLayout();
            // 
            // EstimatedtimeLabel
            // 
            EstimatedtimeLabel.AutoSize = true;
            EstimatedtimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EstimatedtimeLabel.Location = new Point(346, 915);
            EstimatedtimeLabel.Name = "EstimatedtimeLabel";
            EstimatedtimeLabel.Size = new Size(299, 48);
            EstimatedtimeLabel.TabIndex = 43;
            EstimatedtimeLabel.Text = "Estimated Time :";
            // 
            // desclabel
            // 
            desclabel.AutoSize = true;
            desclabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            desclabel.Location = new Point(346, 395);
            desclabel.Name = "desclabel";
            desclabel.Size = new Size(233, 48);
            desclabel.TabIndex = 42;
            desclabel.Text = "Description :";
            // 
            // Startdatelabel
            // 
            Startdatelabel.AutoSize = true;
            Startdatelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Startdatelabel.Location = new Point(346, 525);
            Startdatelabel.Name = "Startdatelabel";
            Startdatelabel.Size = new Size(210, 48);
            Startdatelabel.TabIndex = 41;
            Startdatelabel.Text = "Start Date :";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(810, 785);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(528, 56);
            cmbStatus.TabIndex = 40;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(810, 579);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(528, 55);
            dtpStartDate.TabIndex = 39;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(810, 693);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(528, 55);
            dtpDueDate.TabIndex = 38;
            // 
            // buttonCreateTask
            // 
            buttonCreateTask.BackColor = Color.LimeGreen;
            buttonCreateTask.FlatStyle = FlatStyle.Flat;
            buttonCreateTask.Location = new Point(1270, 1533);
            buttonCreateTask.Name = "buttonCreateTask";
            buttonCreateTask.Size = new Size(422, 113);
            buttonCreateTask.TabIndex = 37;
            buttonCreateTask.Text = "Create Task";
            buttonCreateTask.UseVisualStyleBackColor = false;
            buttonCreateTask.Click += buttonCreateTask_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(810, 273);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(528, 55);
            txtTitle.TabIndex = 36;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(810, 387);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(528, 157);
            txtDescription.TabIndex = 35;
            // 
            // Statuslabel
            // 
            Statuslabel.AutoSize = true;
            Statuslabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Statuslabel.Location = new Point(346, 785);
            Statuslabel.Name = "Statuslabel";
            Statuslabel.Size = new Size(144, 48);
            Statuslabel.TabIndex = 34;
            Statuslabel.Text = "Status :";
            // 
            // DueTimelabel
            // 
            DueTimelabel.AutoSize = true;
            DueTimelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DueTimelabel.Location = new Point(346, 655);
            DueTimelabel.Name = "DueTimelabel";
            DueTimelabel.Size = new Size(197, 48);
            DueTimelabel.TabIndex = 33;
            DueTimelabel.Text = "Due Date :";
            // 
            // Titlelabel
            // 
            Titlelabel.AutoSize = true;
            Titlelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Titlelabel.Location = new Point(346, 265);
            Titlelabel.Name = "Titlelabel";
            Titlelabel.Size = new Size(114, 48);
            Titlelabel.TabIndex = 32;
            Titlelabel.Text = "Title :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(73, 46);
            label1.Name = "label1";
            label1.Size = new Size(277, 70);
            label1.TabIndex = 31;
            label1.Text = "Task Info :";
            // 
            // TeamLeaderlabel
            // 
            TeamLeaderlabel.AutoSize = true;
            TeamLeaderlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TeamLeaderlabel.Location = new Point(346, 1045);
            TeamLeaderlabel.Name = "TeamLeaderlabel";
            TeamLeaderlabel.Size = new Size(250, 48);
            TeamLeaderlabel.TabIndex = 45;
            TeamLeaderlabel.Text = "Team Leader :";
            // 
            // Prioritylabel
            // 
            Prioritylabel.AutoSize = true;
            Prioritylabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Prioritylabel.Location = new Point(346, 1175);
            Prioritylabel.Name = "Prioritylabel";
            Prioritylabel.Size = new Size(165, 48);
            Prioritylabel.TabIndex = 46;
            Prioritylabel.Text = "Priority :";
            // 
            // numEstimatedTime
            // 
            numEstimatedTime.Location = new Point(810, 922);
            numEstimatedTime.Name = "numEstimatedTime";
            numEstimatedTime.Size = new Size(528, 55);
            numEstimatedTime.TabIndex = 47;
            // 
            // cmbTeamLead
            // 
            cmbTeamLead.FormattingEnabled = true;
            cmbTeamLead.Location = new Point(810, 1036);
            cmbTeamLead.Name = "cmbTeamLead";
            cmbTeamLead.Size = new Size(528, 56);
            cmbTeamLead.TabIndex = 48;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(810, 1151);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(528, 56);
            cmbPriority.TabIndex = 49;
            // 
            // Membreasignedlabel
            // 
            Membreasignedlabel.AutoSize = true;
            Membreasignedlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Membreasignedlabel.Location = new Point(346, 1337);
            Membreasignedlabel.Name = "Membreasignedlabel";
            Membreasignedlabel.Size = new Size(347, 48);
            Membreasignedlabel.TabIndex = 50;
            Membreasignedlabel.Text = "Membres assignés :";
            // 
            // clbAssignedUsers
            // 
            clbAssignedUsers.FormattingEnabled = true;
            clbAssignedUsers.Location = new Point(810, 1300);
            clbAssignedUsers.Name = "clbAssignedUsers";
            clbAssignedUsers.Size = new Size(534, 166);
            clbAssignedUsers.TabIndex = 51;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.BackColor = Color.Red;
            buttonAnnuler.FlatStyle = FlatStyle.Flat;
            buttonAnnuler.Location = new Point(857, 1533);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(265, 113);
            buttonAnnuler.TabIndex = 52;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = false;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // cmbProject
            // 
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(810, 180);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(528, 56);
            cmbProject.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(346, 159);
            label2.Name = "label2";
            label2.Size = new Size(168, 48);
            label2.TabIndex = 53;
            label2.Text = " Project :";
            // 
            // FormAddTask
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1906, 1699);
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
            Controls.Add(buttonCreateTask);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(Statuslabel);
            Controls.Add(DueTimelabel);
            Controls.Add(Titlelabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddTask";
            Text = "FormAddTask";
            Load += FormAddTask_Load;
            ((System.ComponentModel.ISupportInitialize)numEstimatedTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        // Update the LoadTasks method to use the corrected type.  
        public void LoadTasks()
        {
            // Ouvre le formulaire d'ajout de tâche
            FormAddTask formAddTask = new FormAddTask();
            formAddTask.Show(); // Ouverture du formulaire sans avoir besoin de rafraîchir les tâches

            // Il n'est pas nécessaire de gérer les DataGridView ou de recharger les tâches ici
        }


        

        #endregion
        private Label EstimatedtimeLabel;
        private Label desclabel;
        private Label Startdatelabel;
        private ComboBox cmbStatus;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpDueDate;
        private Button buttonCreateTask;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Label Statuslabel;
        private Label DueTimelabel;
        private Label Titlelabel;
        private Label label1;
        private Label TeamLeaderlabel;
        private Label Prioritylabel;
        private NumericUpDown numEstimatedTime;
        private ComboBox cmbTeamLead;
        private ComboBox cmbPriority;
        private Label Membreasignedlabel;
        private CheckedListBox clbAssignedUsers;
        private Button buttonAnnuler;
        private ComboBox cmbProject;
        private Label label2;
        // Fix for CS1061: Ensure that 'dgvTasks' is properly declared as a DataGridView instead of an object.  
        private DataGridView dgvTasks;
    }
}