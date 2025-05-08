namespace FatiIkhlassYoun
{
    partial class WhatsAppForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblRecipients = new Label();
            clbRecipients = new CheckedListBox();
            lblMessageType = new Label();
            cbMessageType = new ComboBox();
            lblAlertType = new Label();
            cbAlertType = new ComboBox();
            lblReminderType = new Label();
            cbReminderType = new ComboBox();
            lblCustomMessage = new Label();
            txtCustomMessage = new TextBox();
            btnSend = new Button();
            btnCancel = new Button();
            panelAlert = new Panel();
            panelReminder = new Panel();
            panelCustom = new Panel();
            lblGeneratedMessage = new Label();
            txtGeneratedMessage = new TextBox();
            label1 = new Label();
            panelAlert.SuspendLayout();
            panelReminder.SuspendLayout();
            panelCustom.SuspendLayout();
            SuspendLayout();
            // 
            // lblRecipients
            // 
            lblRecipients.AutoSize = true;
            lblRecipients.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecipients.Location = new Point(35, 155);
            lblRecipients.Margin = new Padding(9, 0, 9, 0);
            lblRecipients.Name = "lblRecipients";
            lblRecipients.Size = new Size(311, 48);
            lblRecipients.TabIndex = 0;
            lblRecipients.Text = "Select Recipients:";
            // 
            // clbRecipients
            // 
            clbRecipients.BackColor = SystemColors.InactiveBorder;
            clbRecipients.FormattingEnabled = true;
            clbRecipients.Location = new Point(35, 219);
            clbRecipients.Margin = new Padding(9, 10, 9, 10);
            clbRecipients.Name = "clbRecipients";
            clbRecipients.Size = new Size(993, 382);
            clbRecipients.TabIndex = 1;
            clbRecipients.SelectedIndexChanged += clbRecipients_SelectedIndexChanged;
            // 
            // lblMessageType
            // 
            lblMessageType.AutoSize = true;
            lblMessageType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMessageType.Location = new Point(35, 699);
            lblMessageType.Margin = new Padding(9, 0, 9, 0);
            lblMessageType.Name = "lblMessageType";
            lblMessageType.Size = new Size(264, 48);
            lblMessageType.TabIndex = 2;
            lblMessageType.Text = "Message Type:";
            // 
            // cbMessageType
            // 
            cbMessageType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMessageType.FormattingEnabled = true;
            cbMessageType.Location = new Point(35, 763);
            cbMessageType.Margin = new Padding(9, 10, 9, 10);
            cbMessageType.Name = "cbMessageType";
            cbMessageType.Size = new Size(564, 56);
            cbMessageType.TabIndex = 3;
            cbMessageType.SelectedIndexChanged += cbMessageType_SelectedIndexChanged;
            // 
            // lblAlertType
            // 
            lblAlertType.AutoSize = true;
            lblAlertType.Location = new Point(9, 32);
            lblAlertType.Margin = new Padding(9, 0, 9, 0);
            lblAlertType.Name = "lblAlertType";
            lblAlertType.Size = new Size(188, 48);
            lblAlertType.TabIndex = 0;
            lblAlertType.Text = "Alert Type:";
            // 
            // cbAlertType
            // 
            cbAlertType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAlertType.FormattingEnabled = true;
            cbAlertType.Items.AddRange(new object[] { "Urgent Task", "System Maintenance", "Security Alert", "Project Deadline" });
            cbAlertType.Location = new Point(9, 96);
            cbAlertType.Margin = new Padding(9, 10, 9, 10);
            cbAlertType.Name = "cbAlertType";
            cbAlertType.Size = new Size(564, 56);
            cbAlertType.TabIndex = 1;
            cbAlertType.SelectedIndexChanged += cbAlertType_SelectedIndexChanged;
            // 
            // lblReminderType
            // 
            lblReminderType.AutoSize = true;
            lblReminderType.Location = new Point(9, 32);
            lblReminderType.Margin = new Padding(9, 0, 9, 0);
            lblReminderType.Name = "lblReminderType";
            lblReminderType.Size = new Size(265, 48);
            lblReminderType.TabIndex = 0;
            lblReminderType.Text = "Reminder Type:";
            // 
            // cbReminderType
            // 
            cbReminderType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReminderType.FormattingEnabled = true;
            cbReminderType.Items.AddRange(new object[] { "Meeting", "Task Deadline", "Project Review", "Status Update" });
            cbReminderType.Location = new Point(9, 96);
            cbReminderType.Margin = new Padding(9, 10, 9, 10);
            cbReminderType.Name = "cbReminderType";
            cbReminderType.Size = new Size(564, 56);
            cbReminderType.TabIndex = 1;
            cbReminderType.SelectedIndexChanged += cbReminderType_SelectedIndexChanged;
            // 
            // lblCustomMessage
            // 
            lblCustomMessage.AutoSize = true;
            lblCustomMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomMessage.Location = new Point(9, 32);
            lblCustomMessage.Margin = new Padding(9, 0, 9, 0);
            lblCustomMessage.Name = "lblCustomMessage";
            lblCustomMessage.Size = new Size(314, 48);
            lblCustomMessage.TabIndex = 0;
            lblCustomMessage.Text = "Custom Message:";
            // 
            // txtCustomMessage
            // 
            txtCustomMessage.BackColor = SystemColors.InactiveBorder;
            txtCustomMessage.Location = new Point(9, 96);
            txtCustomMessage.Margin = new Padding(9, 10, 9, 10);
            txtCustomMessage.Multiline = true;
            txtCustomMessage.Name = "txtCustomMessage";
            txtCustomMessage.Size = new Size(964, 343);
            txtCustomMessage.TabIndex = 1;
            txtCustomMessage.TextChanged += txtCustomMessage_TextChanged;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(0, 192, 0);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Location = new Point(467, 1907);
            btnSend.Margin = new Padding(9, 10, 9, 10);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(229, 96);
            btnSend.TabIndex = 9;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(725, 1907);
            btnCancel.Margin = new Padding(9, 10, 9, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(229, 96);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panelAlert
            // 
            panelAlert.Controls.Add(cbAlertType);
            panelAlert.Controls.Add(lblAlertType);
            panelAlert.Location = new Point(35, 880);
            panelAlert.Margin = new Padding(9, 10, 9, 10);
            panelAlert.Name = "panelAlert";
            panelAlert.Size = new Size(1000, 256);
            panelAlert.TabIndex = 4;
            panelAlert.Visible = false;
            // 
            // panelReminder
            // 
            panelReminder.Controls.Add(cbReminderType);
            panelReminder.Controls.Add(lblReminderType);
            panelReminder.Location = new Point(35, 880);
            panelReminder.Margin = new Padding(9, 10, 9, 10);
            panelReminder.Name = "panelReminder";
            panelReminder.Size = new Size(1000, 256);
            panelReminder.TabIndex = 5;
            panelReminder.Visible = false;
            // 
            // panelCustom
            // 
            panelCustom.Controls.Add(txtCustomMessage);
            panelCustom.Controls.Add(lblCustomMessage);
            panelCustom.Location = new Point(35, 880);
            panelCustom.Margin = new Padding(9, 10, 9, 10);
            panelCustom.Name = "panelCustom";
            panelCustom.Size = new Size(1000, 480);
            panelCustom.TabIndex = 6;
            panelCustom.Visible = false;
            // 
            // lblGeneratedMessage
            // 
            lblGeneratedMessage.AutoSize = true;
            lblGeneratedMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGeneratedMessage.Location = new Point(35, 1424);
            lblGeneratedMessage.Margin = new Padding(9, 0, 9, 0);
            lblGeneratedMessage.Name = "lblGeneratedMessage";
            lblGeneratedMessage.Size = new Size(359, 48);
            lblGeneratedMessage.TabIndex = 7;
            lblGeneratedMessage.Text = "Generated Message:";
            // 
            // txtGeneratedMessage
            // 
            txtGeneratedMessage.Location = new Point(35, 1488);
            txtGeneratedMessage.Margin = new Padding(9, 10, 9, 10);
            txtGeneratedMessage.Multiline = true;
            txtGeneratedMessage.Name = "txtGeneratedMessage";
            txtGeneratedMessage.ReadOnly = true;
            txtGeneratedMessage.Size = new Size(993, 311);
            txtGeneratedMessage.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(35, 29);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(682, 60);
            label1.TabIndex = 11;
            label1.Text = "Send a message via  Whatsapp :";
            // 
            // WhatsAppForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1143, 2061);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSend);
            Controls.Add(txtGeneratedMessage);
            Controls.Add(lblGeneratedMessage);
            Controls.Add(panelCustom);
            Controls.Add(panelReminder);
            Controls.Add(panelAlert);
            Controls.Add(cbMessageType);
            Controls.Add(lblMessageType);
            Controls.Add(clbRecipients);
            Controls.Add(lblRecipients);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(9, 10, 9, 10);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WhatsAppForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Send WhatsApp Message";
            Load += WhatsAppForm_Load;
            panelAlert.ResumeLayout(false);
            panelAlert.PerformLayout();
            panelReminder.ResumeLayout(false);
            panelReminder.PerformLayout();
            panelCustom.ResumeLayout(false);
            panelCustom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblRecipients;
        private System.Windows.Forms.CheckedListBox clbRecipients;
        private System.Windows.Forms.Label lblMessageType;
        private System.Windows.Forms.ComboBox cbMessageType;
        private System.Windows.Forms.Label lblAlertType;
        private System.Windows.Forms.ComboBox cbAlertType;
        private System.Windows.Forms.Label lblReminderType;
        private System.Windows.Forms.ComboBox cbReminderType;
        private System.Windows.Forms.Label lblCustomMessage;
        private System.Windows.Forms.TextBox txtCustomMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelAlert;
        private System.Windows.Forms.Panel panelReminder;
        private System.Windows.Forms.Panel panelCustom;
        private System.Windows.Forms.Label lblGeneratedMessage;
        private System.Windows.Forms.TextBox txtGeneratedMessage;
        private Label label1;
    }
}