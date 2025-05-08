
namespace FatiIkhlassYoun
{
    partial class FormAddProject
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
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            label6 = new Label();
            label5 = new Label();
            Title = new Label();
            label1 = new Label();
            dateTimeEndDate = new DateTimePicker();
            dateTimeStartDate = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBoxManager = new ComboBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LimeGreen;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(1141, 1119);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(229, 96);
            buttonSave.TabIndex = 23;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(857, 275);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(549, 55);
            txtTitle.TabIndex = 20;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(857, 389);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(549, 145);
            txtDescription.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(441, 818);
            label6.Name = "label6";
            label6.Size = new Size(144, 48);
            label6.TabIndex = 17;
            label6.Text = "Status :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(441, 679);
            label5.Name = "label5";
            label5.Size = new Size(192, 48);
            label5.TabIndex = 16;
            label5.Text = "End Date :";
            label5.Click += label5_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Title.Location = new Point(441, 282);
            Title.Name = "Title";
            Title.Size = new Size(114, 48);
            Title.TabIndex = 13;
            Title.Text = "Title :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(179, 81);
            label1.Name = "label1";
            label1.Size = new Size(344, 70);
            label1.TabIndex = 12;
            label1.Text = "Project Info :";
            // 
            // dateTimeEndDate
            // 
            dateTimeEndDate.Location = new Point(857, 672);
            dateTimeEndDate.Name = "dateTimeEndDate";
            dateTimeEndDate.Size = new Size(549, 55);
            dateTimeEndDate.TabIndex = 24;
            // 
            // dateTimeStartDate
            // 
            dateTimeStartDate.Location = new Point(857, 566);
            dateTimeStartDate.Name = "dateTimeStartDate";
            dateTimeStartDate.Size = new Size(549, 55);
            dateTimeStartDate.TabIndex = 25;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(857, 810);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(549, 56);
            comboBoxStatus.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(441, 571);
            label2.Name = "label2";
            label2.Size = new Size(210, 48);
            label2.TabIndex = 27;
            label2.Text = "Start Date :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(441, 459);
            label7.Name = "label7";
            label7.Size = new Size(233, 48);
            label7.TabIndex = 28;
            label7.Text = "Description :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(441, 921);
            label8.Name = "label8";
            label8.Size = new Size(199, 48);
            label8.TabIndex = 29;
            label8.Text = " Manager :";
            // 
            // comboBoxManager
            // 
            comboBoxManager.FormattingEnabled = true;
            comboBoxManager.Location = new Point(857, 913);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(549, 56);
            comboBoxManager.TabIndex = 30;
            comboBoxManager.SelectedIndexChanged += comboBoxManager_SelectedIndexChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(809, 1119);
            btnCancel.Margin = new Padding(9, 10, 9, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(229, 96);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormAddProject
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1615, 1413);
            Controls.Add(btnCancel);
            Controls.Add(comboBoxManager);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(comboBoxStatus);
            Controls.Add(dateTimeStartDate);
            Controls.Add(dateTimeEndDate);
            Controls.Add(buttonSave);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Title);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddProject";
            Load += FormAddProject_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button buttonSave;
        private ComboBox cmbRole;
        private TextBox txtPhone;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label Title;
        private Label label1;
        private DateTimePicker dateTimeEndDate;
        private DateTimePicker dateTimeStartDate;
        private ComboBox comboBoxStatus;
        private Label label2;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxManager;
        private Button btnCancel;

        public object StartDate { get; private set; }
        public Label Description { get; private set; }
    }
}