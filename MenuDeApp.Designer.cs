
namespace FatiIkhlassYoun
{
    partial class MenuDeApp

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDeApp));
            TreeNode treeNode1 = new TreeNode("All ");
            TreeNode treeNode2 = new TreeNode("On leave");
            TreeNode treeNode3 = new TreeNode("Employees", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Chef de projets ");
            TreeNode treeNode5 = new TreeNode("Projets", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Chef d'équipes");
            TreeNode treeNode7 = new TreeNode("Groups", new TreeNode[] { treeNode6 });
            TreeNode treeNode8 = new TreeNode("Tâches sous-traitants");
            TreeNode treeNode9 = new TreeNode("Tâches internes ");
            TreeNode treeNode10 = new TreeNode("Tâches externes");
            TreeNode treeNode11 = new TreeNode("Tâches", new TreeNode[] { treeNode8, treeNode9, treeNode10 });
            panelSup = new Panel();
            button1 = new Button();
            label1 = new Label();
            panelsup2 = new Panel();
            cuiButtonProgress = new CuoreUI.Controls.cuiButton();
            cuiButtonDelete = new CuoreUI.Controls.cuiButton();
            cuiButtonEdit = new CuoreUI.Controls.cuiButton();
            panelwelcome = new Panel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            pictureBoxAdmin = new PictureBox();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiButtonWtsp = new CuoreUI.Controls.cuiButton();
            cuiButtonGenerateReport = new CuoreUI.Controls.cuiButton();
            cuiButtonADD = new CuoreUI.Controls.cuiButton();
            panelleft = new Panel();
            treeView = new TreeView();
            panelRight = new Panel();
            dataGridView1 = new DataGridView();
            contextMenuAdd = new ContextMenuStrip(components);
            addEmployeeToolStripMenuItem = new ToolStripMenuItem();
            addTeamToolStripMenuItem = new ToolStripMenuItem();
            AddTasktoolStripMenuItem = new ToolStripMenuItem();
            AddProjettoolStripMenuItem = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            textDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuEdit = new ContextMenuStrip(components);
            editTaskInfoToolStripMenuItem = new ToolStripMenuItem();
            editTeamInfoToolStripMenuItem = new ToolStripMenuItem();
            panelSup.SuspendLayout();
            panelsup2.SuspendLayout();
            panelwelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdmin).BeginInit();
            panelleft.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            contextMenuEdit.SuspendLayout();
            SuspendLayout();
            // 
            // panelSup
            // 
            panelSup.BackColor = SystemColors.HotTrack;
            panelSup.Controls.Add(button1);
            panelSup.Controls.Add(label1);
            panelSup.Dock = DockStyle.Top;
            panelSup.Location = new Point(0, 0);
            panelSup.Name = "panelSup";
            panelSup.Size = new Size(3046, 92);
            panelSup.TabIndex = 0;
            panelSup.Paint += panelSup_Paint;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(489, 25);
            button1.Name = "button1";
            button1.Size = new Size(56, 56);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label1.Location = new Point(71, 19);
            label1.Name = "label1";
            label1.Size = new Size(412, 65);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashbord";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panelsup2
            // 
            panelsup2.BackColor = Color.WhiteSmoke;
            panelsup2.Controls.Add(cuiButtonProgress);
            panelsup2.Controls.Add(cuiButtonDelete);
            panelsup2.Controls.Add(cuiButtonEdit);
            panelsup2.Controls.Add(panelwelcome);
            panelsup2.Controls.Add(cuiButton1);
            panelsup2.Controls.Add(cuiButtonWtsp);
            panelsup2.Controls.Add(cuiButtonGenerateReport);
            panelsup2.Controls.Add(cuiButtonADD);
            panelsup2.Location = new Point(0, 89);
            panelsup2.Name = "panelsup2";
            panelsup2.Size = new Size(3046, 275);
            panelsup2.TabIndex = 1;
            // 
            // cuiButtonProgress
            // 
            cuiButtonProgress.CheckButton = false;
            cuiButtonProgress.Checked = false;
            cuiButtonProgress.CheckedBackground = Color.DarkSlateBlue;
            cuiButtonProgress.CheckedForeColor = Color.White;
            cuiButtonProgress.CheckedImageTint = Color.White;
            cuiButtonProgress.CheckedOutline = Color.CornflowerBlue;
            cuiButtonProgress.Content = "Progress";
            cuiButtonProgress.DialogResult = DialogResult.None;
            cuiButtonProgress.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonProgress.ForeColor = Color.Black;
            cuiButtonProgress.HoverBackground = Color.PowderBlue;
            cuiButtonProgress.HoveredImageTint = Color.White;
            cuiButtonProgress.HoverForeColor = Color.White;
            cuiButtonProgress.HoverOutline = Color.Empty;
            cuiButtonProgress.Image = (Image)resources.GetObject("cuiButtonProgress.Image");
            cuiButtonProgress.ImageAutoCenter = true;
            cuiButtonProgress.ImageExpand = new Point(10, 10);
            cuiButtonProgress.ImageOffset = new Point(90, 0);
            cuiButtonProgress.ImageTint = Color.WhiteSmoke;
            cuiButtonProgress.Location = new Point(1018, -6);
            cuiButtonProgress.Name = "cuiButtonProgress";
            cuiButtonProgress.NormalBackground = Color.WhiteSmoke;
            cuiButtonProgress.NormalOutline = Color.Empty;
            cuiButtonProgress.OutlineThickness = 1.6F;
            cuiButtonProgress.PressedBackground = Color.Silver;
            cuiButtonProgress.PressedForeColor = Color.White;
            cuiButtonProgress.PressedImageTint = Color.White;
            cuiButtonProgress.PressedOutline = Color.Empty;
            cuiButtonProgress.Rounding = new Padding(8);
            cuiButtonProgress.Size = new Size(342, 277);
            cuiButtonProgress.TabIndex = 17;
            cuiButtonProgress.TextOffset = new Point(-25, 60);
            // 
            // cuiButtonDelete
            // 
            cuiButtonDelete.CheckButton = false;
            cuiButtonDelete.Checked = false;
            cuiButtonDelete.CheckedBackground = Color.DarkSlateBlue;
            cuiButtonDelete.CheckedForeColor = Color.White;
            cuiButtonDelete.CheckedImageTint = Color.White;
            cuiButtonDelete.CheckedOutline = Color.CornflowerBlue;
            cuiButtonDelete.Content = "Add ";
            cuiButtonDelete.DialogResult = DialogResult.None;
            cuiButtonDelete.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonDelete.ForeColor = Color.Black;
            cuiButtonDelete.HoverBackground = Color.PowderBlue;
            cuiButtonDelete.HoveredImageTint = Color.White;
            cuiButtonDelete.HoverForeColor = Color.White;
            cuiButtonDelete.HoverOutline = Color.Empty;
            cuiButtonDelete.Image = (Image)resources.GetObject("cuiButtonDelete.Image");
            cuiButtonDelete.ImageAutoCenter = true;
            cuiButtonDelete.ImageExpand = new Point(10, 10);
            cuiButtonDelete.ImageOffset = new Point(50, 0);
            cuiButtonDelete.ImageTint = Color.WhiteSmoke;
            cuiButtonDelete.Location = new Point(681, 0);
            cuiButtonDelete.Name = "cuiButtonDelete";
            cuiButtonDelete.NormalBackground = Color.WhiteSmoke;
            cuiButtonDelete.NormalOutline = Color.Empty;
            cuiButtonDelete.OutlineThickness = 1.6F;
            cuiButtonDelete.PressedBackground = Color.Silver;
            cuiButtonDelete.PressedForeColor = Color.White;
            cuiButtonDelete.PressedImageTint = Color.White;
            cuiButtonDelete.PressedOutline = Color.Empty;
            cuiButtonDelete.Rounding = new Padding(8);
            cuiButtonDelete.Size = new Size(342, 277);
            cuiButtonDelete.TabIndex = 15;
            cuiButtonDelete.TextOffset = new Point(-25, 60);
            // 
            // cuiButtonEdit
            // 
            cuiButtonEdit.CheckButton = false;
            cuiButtonEdit.Checked = false;
            cuiButtonEdit.CheckedBackground = Color.DarkSlateBlue;
            cuiButtonEdit.CheckedForeColor = Color.White;
            cuiButtonEdit.CheckedImageTint = Color.White;
            cuiButtonEdit.CheckedOutline = Color.CornflowerBlue;
            cuiButtonEdit.Content = "Edit";
            cuiButtonEdit.DialogResult = DialogResult.None;
            cuiButtonEdit.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonEdit.ForeColor = Color.Black;
            cuiButtonEdit.HoverBackground = Color.PowderBlue;
            cuiButtonEdit.HoveredImageTint = Color.White;
            cuiButtonEdit.HoverForeColor = Color.White;
            cuiButtonEdit.HoverOutline = Color.Empty;
            cuiButtonEdit.Image = (Image)resources.GetObject("cuiButtonEdit.Image");
            cuiButtonEdit.ImageAutoCenter = true;
            cuiButtonEdit.ImageExpand = new Point(10, 10);
            cuiButtonEdit.ImageOffset = new Point(50, 0);
            cuiButtonEdit.ImageTint = Color.WhiteSmoke;
            cuiButtonEdit.Location = new Point(333, 3);
            cuiButtonEdit.Name = "cuiButtonEdit";
            cuiButtonEdit.NormalBackground = Color.WhiteSmoke;
            cuiButtonEdit.NormalOutline = Color.Empty;
            cuiButtonEdit.OutlineThickness = 1.6F;
            cuiButtonEdit.PressedBackground = Color.Silver;
            cuiButtonEdit.PressedForeColor = Color.White;
            cuiButtonEdit.PressedImageTint = Color.White;
            cuiButtonEdit.PressedOutline = Color.Empty;
            cuiButtonEdit.Rounding = new Padding(8);
            cuiButtonEdit.Size = new Size(342, 277);
            cuiButtonEdit.TabIndex = 16;
            cuiButtonEdit.TextOffset = new Point(-25, 60);
            cuiButtonEdit.Click += cuiButtonEdit_Click_1;
            // 
            // panelwelcome
            // 
            panelwelcome.BackColor = Color.White;
            panelwelcome.Controls.Add(cuiLabel1);
            panelwelcome.Controls.Add(pictureBoxAdmin);
            panelwelcome.Location = new Point(2481, 274);
            panelwelcome.Name = "panelwelcome";
            panelwelcome.Size = new Size(562, 508);
            panelwelcome.TabIndex = 4;
            panelwelcome.Paint += panel1_Paint_1;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Admin";
            cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            cuiLabel1.Location = new Point(131, 174);
            cuiLabel1.Margin = new Padding(10, 11, 10, 11);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(316, 59);
            cuiLabel1.TabIndex = 1;
            // 
            // pictureBoxAdmin
            // 
            pictureBoxAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxAdmin.ErrorImage = (Image)resources.GetObject("pictureBoxAdmin.ErrorImage");
            pictureBoxAdmin.Image = Properties.Resources.icons8_admin_100;
            pictureBoxAdmin.InitialImage = (Image)resources.GetObject("pictureBoxAdmin.InitialImage");
            pictureBoxAdmin.Location = new Point(185, 28);
            pictureBoxAdmin.Name = "pictureBoxAdmin";
            pictureBoxAdmin.Size = new Size(160, 132);
            pictureBoxAdmin.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxAdmin.TabIndex = 0;
            pictureBoxAdmin.TabStop = false;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.WhiteSmoke;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "LogOut";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.PowderBlue;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.White;
            cuiButton1.HoverOutline = Color.Empty;
            cuiButton1.Image = (Image)resources.GetObject("cuiButton1.Image");
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(10, 10);
            cuiButton1.ImageOffset = new Point(70, 0);
            cuiButton1.ImageTint = Color.White;
            cuiButton1.Location = new Point(2141, 3);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.WhiteSmoke;
            cuiButton1.NormalOutline = Color.Empty;
            cuiButton1.OutlineThickness = 1.6F;
            cuiButton1.PressedBackground = Color.LightSkyBlue;
            cuiButton1.PressedForeColor = Color.White;
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.Empty;
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(233, 277);
            cuiButton1.TabIndex = 14;
            cuiButton1.TextOffset = new Point(-30, 60);
            // 
            // cuiButtonWtsp
            // 
            cuiButtonWtsp.CheckButton = false;
            cuiButtonWtsp.Checked = false;
            cuiButtonWtsp.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonWtsp.CheckedForeColor = Color.White;
            cuiButtonWtsp.CheckedImageTint = Color.White;
            cuiButtonWtsp.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonWtsp.Content = "WhatsApp";
            cuiButtonWtsp.DialogResult = DialogResult.None;
            cuiButtonWtsp.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonWtsp.ForeColor = Color.Black;
            cuiButtonWtsp.HoverBackground = Color.PowderBlue;
            cuiButtonWtsp.HoveredImageTint = Color.White;
            cuiButtonWtsp.HoverForeColor = Color.WhiteSmoke;
            cuiButtonWtsp.HoverOutline = Color.Empty;
            cuiButtonWtsp.Image = (Image)resources.GetObject("cuiButtonWtsp.Image");
            cuiButtonWtsp.ImageAutoCenter = true;
            cuiButtonWtsp.ImageExpand = new Point(10, 10);
            cuiButtonWtsp.ImageOffset = new Point(100, 0);
            cuiButtonWtsp.ImageTint = Color.White;
            cuiButtonWtsp.Location = new Point(1812, -2);
            cuiButtonWtsp.Name = "cuiButtonWtsp";
            cuiButtonWtsp.NormalBackground = Color.WhiteSmoke;
            cuiButtonWtsp.NormalOutline = Color.Empty;
            cuiButtonWtsp.OutlineThickness = 1.6F;
            cuiButtonWtsp.PressedBackground = Color.LightSkyBlue;
            cuiButtonWtsp.PressedForeColor = Color.White;
            cuiButtonWtsp.PressedImageTint = Color.White;
            cuiButtonWtsp.PressedOutline = Color.Empty;
            cuiButtonWtsp.Rounding = new Padding(8);
            cuiButtonWtsp.Size = new Size(286, 277);
            cuiButtonWtsp.TabIndex = 12;
            cuiButtonWtsp.TextOffset = new Point(-30, 60);
            cuiButtonWtsp.Click += cuiButton6_Click;
            // 
            // cuiButtonGenerateReport
            // 
            cuiButtonGenerateReport.CheckButton = false;
            cuiButtonGenerateReport.Checked = false;
            cuiButtonGenerateReport.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonGenerateReport.CheckedForeColor = Color.White;
            cuiButtonGenerateReport.CheckedImageTint = Color.White;
            cuiButtonGenerateReport.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButtonGenerateReport.Content = "Generate report";
            cuiButtonGenerateReport.DialogResult = DialogResult.None;
            cuiButtonGenerateReport.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonGenerateReport.ForeColor = Color.Black;
            cuiButtonGenerateReport.HoverBackground = Color.PowderBlue;
            cuiButtonGenerateReport.HoveredImageTint = Color.Transparent;
            cuiButtonGenerateReport.HoverForeColor = Color.White;
            cuiButtonGenerateReport.HoverOutline = Color.Empty;
            cuiButtonGenerateReport.Image = (Image)resources.GetObject("cuiButtonGenerateReport.Image");
            cuiButtonGenerateReport.ImageAutoCenter = true;
            cuiButtonGenerateReport.ImageExpand = new Point(10, 10);
            cuiButtonGenerateReport.ImageOffset = new Point(140, 0);
            cuiButtonGenerateReport.ImageTint = Color.Azure;
            cuiButtonGenerateReport.Location = new Point(1419, 0);
            cuiButtonGenerateReport.Name = "cuiButtonGenerateReport";
            cuiButtonGenerateReport.NormalBackground = Color.WhiteSmoke;
            cuiButtonGenerateReport.NormalOutline = Color.Empty;
            cuiButtonGenerateReport.OutlineThickness = 1.6F;
            cuiButtonGenerateReport.PressedBackground = Color.FromArgb(255, 106, 0);
            cuiButtonGenerateReport.PressedForeColor = Color.White;
            cuiButtonGenerateReport.PressedImageTint = Color.White;
            cuiButtonGenerateReport.PressedOutline = Color.Empty;
            cuiButtonGenerateReport.Rounding = new Padding(8);
            cuiButtonGenerateReport.Size = new Size(387, 277);
            cuiButtonGenerateReport.TabIndex = 10;
            cuiButtonGenerateReport.TextOffset = new Point(-35, 60);
            cuiButtonGenerateReport.Click += cuiButtonReport_Click;
            // 
            // cuiButtonADD
            // 
            cuiButtonADD.CheckButton = false;
            cuiButtonADD.Checked = false;
            cuiButtonADD.CheckedBackground = Color.DarkSlateBlue;
            cuiButtonADD.CheckedForeColor = Color.White;
            cuiButtonADD.CheckedImageTint = Color.White;
            cuiButtonADD.CheckedOutline = Color.CornflowerBlue;
            cuiButtonADD.Content = "Add ";
            cuiButtonADD.DialogResult = DialogResult.None;
            cuiButtonADD.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButtonADD.ForeColor = Color.Black;
            cuiButtonADD.HoverBackground = Color.PowderBlue;
            cuiButtonADD.HoveredImageTint = Color.White;
            cuiButtonADD.HoverForeColor = Color.White;
            cuiButtonADD.HoverOutline = Color.Empty;
            cuiButtonADD.Image = Properties.Resources.icons8_add;
            cuiButtonADD.ImageAutoCenter = true;
            cuiButtonADD.ImageExpand = new Point(10, 10);
            cuiButtonADD.ImageOffset = new Point(50, 0);
            cuiButtonADD.ImageTint = Color.WhiteSmoke;
            cuiButtonADD.Location = new Point(0, -6);
            cuiButtonADD.Name = "cuiButtonADD";
            cuiButtonADD.NormalBackground = Color.WhiteSmoke;
            cuiButtonADD.NormalOutline = Color.Empty;
            cuiButtonADD.OutlineThickness = 1.6F;
            cuiButtonADD.PressedBackground = Color.Silver;
            cuiButtonADD.PressedForeColor = Color.White;
            cuiButtonADD.PressedImageTint = Color.White;
            cuiButtonADD.PressedOutline = Color.Empty;
            cuiButtonADD.Rounding = new Padding(8);
            cuiButtonADD.Size = new Size(342, 277);
            cuiButtonADD.TabIndex = 6;
            cuiButtonADD.TextOffset = new Point(-25, 60);
            cuiButtonADD.Click += cuiButton1_Click;
            // 
            // panelleft
            // 
            panelleft.BackColor = Color.WhiteSmoke;
            panelleft.Controls.Add(treeView);
            panelleft.Location = new Point(0, 363);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(507, 1634);
            panelleft.TabIndex = 2;
            // 
            // treeView
            // 
            treeView.Anchor = AnchorStyles.Left;
            treeView.Cursor = Cursors.Cross;
            treeView.Location = new Point(3, 3);
            treeView.Name = "treeView";
            treeNode1.Name = "All ";
            treeNode1.Text = "All ";
            treeNode2.Name = "On leave";
            treeNode2.Text = "On leave";
            treeNode3.Name = "Employees";
            treeNode3.Text = "Employees";
            treeNode4.Name = "Chef de projets ";
            treeNode4.Text = "Chef de projets ";
            treeNode5.Name = "Projets";
            treeNode5.Text = "Projets";
            treeNode6.Name = "Chef d'équipes";
            treeNode6.Text = "Chef d'équipes";
            treeNode7.Name = "Teams";
            treeNode7.Text = "Groups";
            treeNode8.Name = "Tâches sous-traitants";
            treeNode8.Text = "Tâches sous-traitants";
            treeNode9.Name = "Tâches internes ";
            treeNode9.Text = "Tâches internes ";
            treeNode10.Name = "Tâches externes";
            treeNode10.Text = "Tâches externes";
            treeNode11.Name = "Tâches";
            treeNode11.Text = "Tâches";
            treeView.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode5, treeNode7, treeNode11 });
            treeView.Size = new Size(515, 1637);
            treeView.TabIndex = 0;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.WhiteSmoke;
            panelRight.Controls.Add(dataGridView1);
            panelRight.Location = new Point(2481, 363);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(565, 1634);
            panelRight.TabIndex = 0;
            panelRight.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1356, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 123;
            dataGridView1.Size = new Size(0, 1634);
            dataGridView1.TabIndex = 3;
            // 
            // contextMenuAdd
            // 
            contextMenuAdd.BackColor = Color.LightSteelBlue;
            contextMenuAdd.ImageScalingSize = new Size(48, 48);
            contextMenuAdd.Items.AddRange(new ToolStripItem[] { addEmployeeToolStripMenuItem, addTeamToolStripMenuItem, AddTasktoolStripMenuItem, AddProjettoolStripMenuItem });
            contextMenuAdd.Name = "contextMenuAdd";
            contextMenuAdd.ShowCheckMargin = true;
            contextMenuAdd.Size = new Size(353, 228);
            contextMenuAdd.Opening += contextMenuAdd_Opening;
            // 
            // addEmployeeToolStripMenuItem
            // 
            addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            addEmployeeToolStripMenuItem.Size = new Size(352, 56);
            addEmployeeToolStripMenuItem.Text = "Add Employee";
            addEmployeeToolStripMenuItem.Click += addEmployeeToolStripMenuItem_Click;
            // 
            // addTeamToolStripMenuItem
            // 
            addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            addTeamToolStripMenuItem.Size = new Size(352, 56);
            addTeamToolStripMenuItem.Text = "Add Team";
            addTeamToolStripMenuItem.Click += addGroupToolStripMenuItem_Click;
            // 
            // AddTasktoolStripMenuItem
            // 
            AddTasktoolStripMenuItem.Name = "AddTasktoolStripMenuItem";
            AddTasktoolStripMenuItem.Size = new Size(352, 56);
            AddTasktoolStripMenuItem.Text = "Add Task";
            AddTasktoolStripMenuItem.Click += AddTasktoolStripMenuItem_Click;
            // 
            // AddProjettoolStripMenuItem
            // 
            AddProjettoolStripMenuItem.Name = "AddProjettoolStripMenuItem";
            AddProjettoolStripMenuItem.Size = new Size(352, 56);
            AddProjettoolStripMenuItem.Text = "Add Project";
            AddProjettoolStripMenuItem.Click += AddProjettoolStripMenuItem_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeight = 69;
            dataGridView.Location = new Point(513, 366);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 123;
            dataGridView.Size = new Size(1962, 1150);
            dataGridView.TabIndex = 1;
            // 
            // textDataGridViewTextBoxColumn
            // 
            textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            textDataGridViewTextBoxColumn.HeaderText = "Text";
            textDataGridViewTextBoxColumn.MinimumWidth = 15;
            textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            textDataGridViewTextBoxColumn.Width = 300;
            // 
            // contextMenuEdit
            // 
            contextMenuEdit.ImageScalingSize = new Size(48, 48);
            contextMenuEdit.Items.AddRange(new ToolStripItem[] { editTaskInfoToolStripMenuItem, editTeamInfoToolStripMenuItem });
            contextMenuEdit.Name = "contextMenuEdit";
            contextMenuEdit.Size = new Size(421, 182);
            contextMenuEdit.Opening += contextMenuEdit_Opening;
            // 
            // editTaskInfoToolStripMenuItem
            // 
            editTaskInfoToolStripMenuItem.Name = "editTaskInfoToolStripMenuItem";
            editTaskInfoToolStripMenuItem.Size = new Size(420, 56);
            editTaskInfoToolStripMenuItem.Text = "Edit Task Info";
            editTaskInfoToolStripMenuItem.Click += editTaskInfoToolStripMenuItem_Click;
            // 
            // editTeamInfoToolStripMenuItem
            // 
            editTeamInfoToolStripMenuItem.Name = "editTeamInfoToolStripMenuItem";
            editTeamInfoToolStripMenuItem.Size = new Size(420, 56);
            editTeamInfoToolStripMenuItem.Text = "Edit Team Info";
            // 
            // MenuDeApp
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3046, 2000);
            Controls.Add(dataGridView);
            Controls.Add(panelRight);
            Controls.Add(panelleft);
            Controls.Add(panelsup2);
            Controls.Add(panelSup);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1200, 800);
            Name = "MenuDeApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            Load += MenuDeApp_Load;
            panelSup.ResumeLayout(false);
            panelSup.PerformLayout();
            panelsup2.ResumeLayout(false);
            panelwelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdmin).EndInit();
            panelleft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            contextMenuEdit.ResumeLayout(false);
            ResumeLayout(false);
        }



        private void treeViewEmployee_AfterSelect(object sender, TreeViewEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelSup;
        private Panel panelsup2;
        private Panel panelleft;
        private Panel panelRight;
        private Label label1;
        private Button button1;
        public CuoreUI.Controls.cuiButton cuiButtonADD;
        private CuoreUI.Controls.cuiButton cuiButtonGenerateReport;
        private CuoreUI.Controls.cuiButton cuiButtonWtsp;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuAdd;
        private ToolStripMenuItem addEmployeeToolStripMenuItem;
        private ToolStripMenuItem addTeamToolStripMenuItem;
        private Panel panelwelcome;
        private PictureBox pictureBoxAdmin;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private TreeView treeView;
        private DataGridView dataGridView;
        private ToolStripMenuItem AddTasktoolStripMenuItem;
        private ToolStripMenuItem AddProjettoolStripMenuItem;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        public CuoreUI.Controls.cuiButton cuiButtonDelete;
        public CuoreUI.Controls.cuiButton cuiButtonEdit;
        public CuoreUI.Controls.cuiButton cuiButtonProgress;
        private ContextMenuStrip contextMenuEdit;
        private ToolStripMenuItem editTaskInfoToolStripMenuItem;
        private ToolStripMenuItem editTeamInfoToolStripMenuItem;
    }
}