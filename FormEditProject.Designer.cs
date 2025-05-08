
namespace FatiIkhlassYoun
{
    partial class FormEditProject
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
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblStartDate = new Label();
            dateTimeStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dateTimeEndDate = new DateTimePicker();
            lblStatus = new Label();
            comboBoxStatus = new ComboBox();
            lblManager = new Label();
            comboBoxManager = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.Location = new Point(581, 208);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(114, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title :";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(980, 220);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(581, 55);
            txtTitle.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescription.Location = new Point(581, 354);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(233, 48);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(980, 367);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(581, 100);
            txtDescription.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStartDate.Location = new Point(581, 512);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(210, 48);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Start Date :";
            // 
            // dateTimeStartDate
            // 
            dateTimeStartDate.Location = new Point(980, 512);
            dateTimeStartDate.Name = "dateTimeStartDate";
            dateTimeStartDate.Size = new Size(620, 55);
            dateTimeStartDate.TabIndex = 5;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndDate.Location = new Point(581, 597);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(192, 48);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "End Date :";
            // 
            // dateTimeEndDate
            // 
            dateTimeEndDate.Location = new Point(980, 590);
            dateTimeEndDate.Name = "dateTimeEndDate";
            dateTimeEndDate.Size = new Size(621, 55);
            dateTimeEndDate.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(581, 675);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(144, 48);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status :";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Location = new Point(980, 675);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(620, 56);
            comboBoxStatus.TabIndex = 9;
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblManager.Location = new Point(581, 754);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(189, 48);
            lblManager.TabIndex = 10;
            lblManager.Text = "Manager :";
            // 
            // comboBoxManager
            // 
            comboBoxManager.Location = new Point(980, 754);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(620, 56);
            comboBoxManager.TabIndex = 11;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(0, 192, 0);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(1298, 903);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(389, 129);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Update";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Location = new Point(808, 912);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(310, 120);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(109, 55);
            label1.Name = "label1";
            label1.Size = new Size(536, 70);
            label1.TabIndex = 14;
            label1.Text = "Modify Project Info :";
            // 
            // FormEditProject
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1883, 1247);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxManager);
            Controls.Add(lblManager);
            Controls.Add(comboBoxStatus);
            Controls.Add(lblStatus);
            Controls.Add(dateTimeEndDate);
            Controls.Add(lblEndDate);
            Controls.Add(dateTimeStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(8, 9, 8, 9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modifier le Projet";
            Load += FormEditProject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dateTimeStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimeEndDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private Label label1;

        public EventHandler FormEditProject_Load { get; private set; }
    }

        #endregion
    }
