namespace FatiIkhlassYoun
{
    partial class ReportGeneratorForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            gbProjects = new GroupBox();
            chkSelectAllProjects = new CheckBox();
            clbProjects = new CheckedListBox();
            gbTeams = new GroupBox();
            chkSelectAllTeams = new CheckBox();
            clbTeams = new CheckedListBox();
            gbStatus = new GroupBox();
            chkSelectAllStatus = new CheckBox();
            clbStatus = new CheckedListBox();
            gbDateRange = new GroupBox();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            btnGenerate = new Button();
            btnCancel = new Button();
            gbReportType = new GroupBox();
            rbDetailed = new RadioButton();
            rbSummary = new RadioButton();
            panelSup = new Panel();
            gbPerformance = new GroupBox();
            numTopTeams = new NumericUpDown();
            chkIncludeTopTeam = new CheckBox();
            gbProjects.SuspendLayout();
            gbTeams.SuspendLayout();
            gbStatus.SuspendLayout();
            gbDateRange.SuspendLayout();
            gbReportType.SuspendLayout();
            panelSup.SuspendLayout();
            gbPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTopTeams).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(53, 9);
            lblTitle.Margin = new Padding(10, 0, 10, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(542, 64);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Générer un Rapport";
            // 
            // gbProjects
            // 
            gbProjects.Controls.Add(chkSelectAllProjects);
            gbProjects.Controls.Add(clbProjects);
            gbProjects.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbProjects.Location = new Point(53, 185);
            gbProjects.Margin = new Padding(10, 11, 10, 11);
            gbProjects.Name = "gbProjects";
            gbProjects.Padding = new Padding(10, 11, 10, 11);
            gbProjects.Size = new Size(833, 738);
            gbProjects.TabIndex = 1;
            gbProjects.TabStop = false;
            gbProjects.Text = "1. Sélection des Projets";
            // 
            // chkSelectAllProjects
            // 
            chkSelectAllProjects.AutoSize = true;
            chkSelectAllProjects.Location = new Point(33, 74);
            chkSelectAllProjects.Margin = new Padding(10, 11, 10, 11);
            chkSelectAllProjects.Name = "chkSelectAllProjects";
            chkSelectAllProjects.Size = new Size(358, 52);
            chkSelectAllProjects.TabIndex = 1;
            chkSelectAllProjects.Text = "Sélectionner tous";
            chkSelectAllProjects.UseVisualStyleBackColor = true;
            chkSelectAllProjects.CheckedChanged += chkSelectAllProjects_CheckedChanged;
            // 
            // clbProjects
            // 
            clbProjects.BackColor = SystemColors.InactiveBorder;
            clbProjects.FormattingEnabled = true;
            clbProjects.Location = new Point(33, 166);
            clbProjects.Margin = new Padding(10, 11, 10, 11);
            clbProjects.Name = "clbProjects";
            clbProjects.Size = new Size(757, 490);
            clbProjects.TabIndex = 0;
            clbProjects.ItemCheck += clbProjects_ItemCheck;
            // 
            // gbTeams
            // 
            gbTeams.Controls.Add(chkSelectAllTeams);
            gbTeams.Controls.Add(clbTeams);
            gbTeams.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbTeams.Location = new Point(933, 185);
            gbTeams.Margin = new Padding(10, 11, 10, 11);
            gbTeams.Name = "gbTeams";
            gbTeams.Padding = new Padding(10, 11, 10, 11);
            gbTeams.Size = new Size(833, 738);
            gbTeams.TabIndex = 2;
            gbTeams.TabStop = false;
            gbTeams.Text = "2. Sélection des Équipes";
            // 
            // chkSelectAllTeams
            // 
            chkSelectAllTeams.AutoSize = true;
            chkSelectAllTeams.Location = new Point(33, 74);
            chkSelectAllTeams.Margin = new Padding(10, 11, 10, 11);
            chkSelectAllTeams.Name = "chkSelectAllTeams";
            chkSelectAllTeams.Size = new Size(358, 52);
            chkSelectAllTeams.TabIndex = 1;
            chkSelectAllTeams.Text = "Sélectionner tous";
            chkSelectAllTeams.UseVisualStyleBackColor = true;
            chkSelectAllTeams.CheckedChanged += chkSelectAllTeams_CheckedChanged;
            // 
            // clbTeams
            // 
            clbTeams.BackColor = SystemColors.InactiveBorder;
            clbTeams.FormattingEnabled = true;
            clbTeams.Location = new Point(33, 166);
            clbTeams.Margin = new Padding(10, 11, 10, 11);
            clbTeams.Name = "clbTeams";
            clbTeams.Size = new Size(757, 490);
            clbTeams.TabIndex = 0;
            // 
            // gbStatus
            // 
            gbStatus.Controls.Add(chkSelectAllStatus);
            gbStatus.Controls.Add(clbStatus);
            gbStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbStatus.Location = new Point(1813, 185);
            gbStatus.Margin = new Padding(10, 11, 10, 11);
            gbStatus.Name = "gbStatus";
            gbStatus.Padding = new Padding(10, 11, 10, 11);
            gbStatus.Size = new Size(833, 738);
            gbStatus.TabIndex = 3;
            gbStatus.TabStop = false;
            gbStatus.Text = "3. Statut des Tâches";
            // 
            // chkSelectAllStatus
            // 
            chkSelectAllStatus.AutoSize = true;
            chkSelectAllStatus.Location = new Point(33, 74);
            chkSelectAllStatus.Margin = new Padding(10, 11, 10, 11);
            chkSelectAllStatus.Name = "chkSelectAllStatus";
            chkSelectAllStatus.Size = new Size(358, 52);
            chkSelectAllStatus.TabIndex = 1;
            chkSelectAllStatus.Text = "Sélectionner tous";
            chkSelectAllStatus.UseVisualStyleBackColor = true;
            chkSelectAllStatus.CheckedChanged += chkSelectAllStatus_CheckedChanged;
            // 
            // clbStatus
            // 
            clbStatus.BackColor = SystemColors.InactiveBorder;
            clbStatus.FormattingEnabled = true;
            clbStatus.Items.AddRange(new object[] { "En attente", "En cours", "Terminée" });
            clbStatus.Location = new Point(33, 166);
            clbStatus.Margin = new Padding(10, 11, 10, 11);
            clbStatus.Name = "clbStatus";
            clbStatus.Size = new Size(757, 490);
            clbStatus.TabIndex = 0;
            // 
            // gbDateRange
            // 
            gbDateRange.Controls.Add(dtpEndDate);
            gbDateRange.Controls.Add(dtpStartDate);
            gbDateRange.Controls.Add(label2);
            gbDateRange.Controls.Add(label1);
            gbDateRange.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbDateRange.Location = new Point(53, 978);
            gbDateRange.Margin = new Padding(10, 11, 10, 11);
            gbDateRange.Name = "gbDateRange";
            gbDateRange.Padding = new Padding(10, 11, 10, 11);
            gbDateRange.Size = new Size(833, 369);
            gbDateRange.TabIndex = 4;
            gbDateRange.TabStop = false;
            gbDateRange.Text = "4. Période du Rapport";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(267, 222);
            dtpEndDate.Margin = new Padding(10, 11, 10, 11);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(524, 55);
            dtpEndDate.TabIndex = 3;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(267, 92);
            dtpStartDate.Margin = new Padding(10, 11, 10, 11);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(524, 55);
            dtpStartDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 240);
            label2.Margin = new Padding(10, 0, 10, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 48);
            label2.TabIndex = 1;
            label2.Text = "Date Fin :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 111);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 48);
            label1.TabIndex = 0;
            label1.Text = "Date Début :";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(0, 192, 0);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Location = new Point(2147, 1182);
            btnGenerate.Margin = new Padding(10, 11, 10, 11);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(500, 148);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Générer le Rapport";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(2147, 1001);
            btnCancel.Margin = new Padding(10, 11, 10, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(500, 148);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // gbReportType
            // 
            gbReportType.Controls.Add(rbDetailed);
            gbReportType.Controls.Add(rbSummary);
            gbReportType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbReportType.Location = new Point(933, 978);
            gbReportType.Margin = new Padding(10, 11, 10, 11);
            gbReportType.Name = "gbReportType";
            gbReportType.Padding = new Padding(10, 11, 10, 11);
            gbReportType.Size = new Size(667, 369);
            gbReportType.TabIndex = 7;
            gbReportType.TabStop = false;
            gbReportType.Text = "5. Type de Rapport";
            gbReportType.Enter += gbReportType_Enter;
            // 
            // rbDetailed
            // 
            rbDetailed.AutoSize = true;
            rbDetailed.Location = new Point(33, 185);
            rbDetailed.Margin = new Padding(10, 11, 10, 11);
            rbDetailed.Name = "rbDetailed";
            rbDetailed.Size = new Size(296, 52);
            rbDetailed.TabIndex = 1;
            rbDetailed.Text = "Détaillé (PDF)";
            rbDetailed.UseVisualStyleBackColor = true;
            // 
            // rbSummary
            // 
            rbSummary.AutoSize = true;
            rbSummary.Checked = true;
            rbSummary.Location = new Point(33, 92);
            rbSummary.Margin = new Padding(10, 11, 10, 11);
            rbSummary.Name = "rbSummary";
            rbSummary.Size = new Size(334, 52);
            rbSummary.TabIndex = 0;
            rbSummary.TabStop = true;
            rbSummary.Text = "Synthèse (Excel)";
            rbSummary.UseVisualStyleBackColor = true;
            // 
            // panelSup
            // 
            panelSup.BackColor = SystemColors.HotTrack;
            panelSup.Controls.Add(lblTitle);
            panelSup.Dock = DockStyle.Top;
            panelSup.Location = new Point(0, 0);
            panelSup.Name = "panelSup";
            panelSup.Size = new Size(2713, 92);
            panelSup.TabIndex = 8;
            // 
            // gbPerformance
            // 
            gbPerformance.Controls.Add(numTopTeams);
            gbPerformance.Controls.Add(chkIncludeTopTeam);
            gbPerformance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbPerformance.Location = new Point(1620, 1001);
            gbPerformance.Margin = new Padding(10, 11, 10, 11);
            gbPerformance.Name = "gbPerformance";
            gbPerformance.Padding = new Padding(10, 11, 10, 11);
            gbPerformance.Size = new Size(500, 369);
            gbPerformance.TabIndex = 9;
            gbPerformance.TabStop = false;
            gbPerformance.Text = "6. Performance des Équipes";
            // 
            // numTopTeams
            // 
            numTopTeams.Location = new Point(33, 185);
            numTopTeams.Margin = new Padding(10, 11, 10, 11);
            numTopTeams.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTopTeams.Name = "numTopTeams";
            numTopTeams.Size = new Size(100, 55);
            numTopTeams.TabIndex = 1;
            numTopTeams.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // chkIncludeTopTeam
            // 
            chkIncludeTopTeam.AutoSize = true;
            chkIncludeTopTeam.Location = new Point(33, 92);
            chkIncludeTopTeam.Margin = new Padding(10, 11, 10, 11);
            chkIncludeTopTeam.Name = "chkIncludeTopTeam";
            chkIncludeTopTeam.Size = new Size(615, 52);
            chkIncludeTopTeam.TabIndex = 0;
            chkIncludeTopTeam.Text = "Inclure les équipes performantes";
            chkIncludeTopTeam.UseVisualStyleBackColor = true;
            // 
            // ReportGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(2713, 1407);
            Controls.Add(gbPerformance);
            Controls.Add(panelSup);
            Controls.Add(gbReportType);
            Controls.Add(btnCancel);
            Controls.Add(btnGenerate);
            Controls.Add(gbDateRange);
            Controls.Add(gbStatus);
            Controls.Add(gbTeams);
            Controls.Add(gbProjects);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(10, 11, 10, 11);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportGeneratorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Générateur de Rapports";
            Load += ReportGeneratorForm_Load;
            gbProjects.ResumeLayout(false);
            gbProjects.PerformLayout();
            gbTeams.ResumeLayout(false);
            gbTeams.PerformLayout();
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            gbDateRange.ResumeLayout(false);
            gbDateRange.PerformLayout();
            gbReportType.ResumeLayout(false);
            gbReportType.PerformLayout();
            panelSup.ResumeLayout(false);
            panelSup.PerformLayout();
            gbPerformance.ResumeLayout(false);
            gbPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTopTeams).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbProjects;
        private System.Windows.Forms.CheckedListBox clbProjects;
        private System.Windows.Forms.GroupBox gbTeams;
        private System.Windows.Forms.CheckedListBox clbTeams;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.CheckedListBox clbStatus;
        private System.Windows.Forms.GroupBox gbDateRange;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkSelectAllProjects;
        private System.Windows.Forms.CheckBox chkSelectAllTeams;
        private System.Windows.Forms.CheckBox chkSelectAllStatus;
        private System.Windows.Forms.GroupBox gbReportType;
        private System.Windows.Forms.RadioButton rbDetailed;
        private System.Windows.Forms.RadioButton rbSummary;
        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.GroupBox gbPerformance;
        private System.Windows.Forms.NumericUpDown numTopTeams;
        private System.Windows.Forms.CheckBox chkIncludeTopTeam;
    }
}