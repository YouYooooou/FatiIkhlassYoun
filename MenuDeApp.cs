using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using ClosedXML.Excel;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Rectangle = System.Drawing.Rectangle;
using Font = System.Drawing.Font;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FatiIkhlassYoun
{
    public partial class MenuDeApp : Form
    {

        private object favorites;
        private object treeViewMenu;
        private object filters;
        private Document document1;
        private string fileName;
        private int selectedId;
        private string currentViewType;


        public string Title { get; private set; }
        public string ProjectID { get; private set; }

        public MenuDeApp()
        {
            InitializeComponent();
            // Si vous n'avez pas ajouté 'txtPassword' via le designer, vous pouvez l'initialiser ici
            txtPassword = new TextBox();
            txtPassword.Name = "txtPassword";
            txtPassword.Text = "";  // Initialiser le texte par défaut
            txtPassword.Location = new Point(10, 10);  // Par exemple, placez-le à une position spécifique sur le formulaire
            txtPassword.Size = new Size(200, 30);  // Définir une taille appropriée

            // Si vous devez l'ajouter à un conteneur (comme un Panel ou Form), vous pouvez le faire ici
            this.Controls.Add(txtPassword);

            UpdateTreeView();

            LoadInitialData();


        }

        private void MenuDeApp_Load(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            contextMenuAdd.Show(cuiButtonADD, new Point(0, cuiButtonADD.Height));
        }

        private void cuiDataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void cuiButton6_Click(object sender, EventArgs e)
        {
            // Lien vers WhatsApp
            string phone = "212694485667"; // Remplace par un vrai numéro sans le +
            string message = "Bonjour, voici le rapport PDF : http://localhost/rapports/" + fileName;
            string url = "https://wa.me/" + phone + "?text=" + Uri.EscapeDataString(message);

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Assure que l'URL est ouverte avec le navigateur par défaut
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ouverture de WhatsApp Web : " + ex.Message);
            }

            MessageBox.Show("✅ Rapport PDF généré et lien WhatsApp ouvert dans le navigateur !");
        }


        private void cuiButton2_Click(object sender, EventArgs e)
        {

        }

        private void cuiButtonLogout_Click(object sender, EventArgs e)
        {

        }
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private ComboBox cmbRole;
        private CheckBox chkIsActive;
        private TextBox txtPhone;
        private string connectionString;
        private object dgvTasks;


        private void cuiButtonReport_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";
            string dossierRapports = @"C:\Rapports\";

            // Vérifier si le dossier existe sinon le créer
            if (!Directory.Exists(dossierRapports))
            {
                Directory.CreateDirectory(dossierRapports);
            }

            var allProjects = GetAllProjects();

            if (allProjects == null || allProjects.Count == 0)
            {
                MessageBox.Show("Aucun projet trouvé !");
                return;
            }

            List<string> nomsDeRapports = new List<string>();

            foreach (var project in allProjects)
            {
                int projectId = project.ProjectID;

                var tasks = GetProjectTasks(projectId);
                var users = GetProjectUsers(projectId);

                string fileName = $"Rapport_Projet_{projectId}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                string filePath = Path.Combine(dossierRapports, fileName);

                var wb = new XLWorkbook();

                // ➤ Feuille Projet
                var wsProject = wb.Worksheets.Add("Projet");
                wsProject.Cell(1, 1).Value = "Nom du Projet";
                wsProject.Cell(1, 2).Value = project.Title;

                wsProject.Cell(2, 1).Value = "Description";
                wsProject.Cell(2, 2).Value = project.Description;

                wsProject.Cell(3, 1).Value = "Date Début";
                wsProject.Cell(3, 2).Value = project.StartDate.ToString("dd/MM/yyyy");

                wsProject.Cell(4, 1).Value = "Date Fin";
                wsProject.Cell(4, 2).Value = project.EndDate.ToString("dd/MM/yyyy");

                // ➤ Feuille Tâches
                var wsTasks = wb.Worksheets.Add("Tâches");
                wsTasks.Cell(1, 1).Value = "Titre";
                wsTasks.Cell(1, 2).Value = "Statut";
                wsTasks.Cell(1, 3).Value = "Échéance";

                int rowTask = 2;
                foreach (var t in tasks)
                {
                    wsTasks.Cell(rowTask, 1).Value = t.Title;
                    wsTasks.Cell(rowTask, 2).Value = t.Status;
                    wsTasks.Cell(rowTask, 3).Value = t.DueDate.ToString("dd/MM/yyyy");
                    rowTask++;
                }

                // ➤ Feuille Utilisateurs
                var wsUsers = wb.Worksheets.Add("Utilisateurs");
                wsUsers.Cell(1, 1).Value = "Nom";
                wsUsers.Cell(1, 2).Value = "Email";
                wsUsers.Cell(1, 3).Value = "Rôle";

                int rowUser = 2;
                foreach (var u in users)
                {
                    wsUsers.Cell(rowUser, 1).Value = u.Username;
                    wsUsers.Cell(rowUser, 2).Value = u.Email;
                    wsUsers.Cell(rowUser, 3).Value = u.Role;
                    rowUser++;
                }

                wb.SaveAs(filePath);

                // ➤ Insertion dans Reports
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertReport = "INSERT INTO Reports (ProjectID, DateGenerated, FilePath) VALUES (@ProjectID, @DateGenerated, @FilePath)";
                    using (SqlCommand cmd = new SqlCommand(insertReport, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectID", projectId);
                        cmd.Parameters.AddWithValue("@DateGenerated", DateTime.Now);
                        cmd.Parameters.AddWithValue("@FilePath", filePath);
                        cmd.ExecuteNonQuery();
                    }
                }

                nomsDeRapports.Add($"• {project.Title}");
            }
            MessageBox.Show("✅ Tous les rapports ont été générés  !");
        }
        private List<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>();

            string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ProjectID, Title, Description, StartDate, EndDate FROM Projects";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projects.Add(new Project
                            {
                                ProjectID = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Description = reader.GetString(2),
                                StartDate = reader.GetDateTime(3),
                                EndDate = reader.GetDateTime(4),
                                ManagerID = reader.GetInt32(0)
                            });
                        }
                    }
                }
            }

            return projects;
        }
        private dynamic GetProjectInfo(int projectId)
        {
            string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Title, Description, StartDate, EndDate FROM Projects WHERE ProjectID = @ProjectID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString(),
                                StartDate = Convert.ToDateTime(reader["StartDate"]),
                                EndDate = Convert.ToDateTime(reader["EndDate"])
                            };
                        }
                    }
                }
            }
            return null;
        }
        private List<dynamic> GetProjectTasks(int projectId)
        {
            var list = new List<dynamic>();
            string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Title, Status, DueDate FROM Tasks WHERE ProjectID = @ProjectID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new
                            {
                                Title = reader["Title"].ToString(),
                                Status = reader["Status"].ToString(),
                                DueDate = Convert.ToDateTime(reader["DueDate"])
                            });
                        }
                    }
                }
            }
            return list;
        }
        private List<dynamic> GetProjectUsers(int projectId)
        {
            var list = new List<dynamic>();
            string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT u.Username, u.Email, u.Role
            FROM Task_Assignments ta
            JOIN Tasks t ON ta.TaskID = t.TaskID
            JOIN Users u ON ta.UserID = u.UserID
            WHERE t.ProjectID = @ProjectID
            GROUP BY u.Username, u.Email, u.Role";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new
                            {
                                Username = reader["Username"].ToString(),
                                Email = reader["Email"].ToString(),
                                Role = reader["Role"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }
        private void cuiButtonTasks_Click(object sender, EventArgs e)
        {
            FormDashboardProgress dashboardProgressForm = new FormDashboardProgress();
            dashboardProgressForm.Show();
        }


        private void cuiButtonDelete_Click(object sender, EventArgs e)
        {

        }

        private void cuiButtonEdit_Click(object sender, EventArgs e)
        {

        }

        private void panelsup2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelSup_Paint(object sender, PaintEventArgs e)
        {

        }
        private void contextMenuAdd_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEmployee form = new FormAddEmployee();
            form.Show();
        }



        private class AddEmployeeControl : Control
        {
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddTeam form = new FormAddTeam();
            form.Show();

        }

        private class AddGroupControl : Control
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void RefreshCurrentView()
        {
            if (treeView.SelectedNode == null) return;

            string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";

            try
            {
                switch (treeView.SelectedNode.Text)
                {
                    case "Employees" or "Utilisateurs":
                        LoadUsersData(connectionString);
                        break;
                    case "Groups" or "Équipes":
                        LoadTeamsData(connectionString);
                        break;
                    case "Projets":
                        LoadProjectsData(connectionString);
                        break;
                    case "Tâches":
                        LoadTasksData(connectionString);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du rafraîchissement: {ex.Message}", "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        internal class FormDashboardProgress : Form
        {
            // Ajout de la classe FormDashboardProgress héritant de Form pour résoudre l'erreur CS1061.
        }



        private void LoadData()
        {
            // Logique pour charger à nouveau les données en fonction du nœud sélectionné dans le TreeView
            string selectedNode = treeView.SelectedNode.Text;

            string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";
            string query = string.Empty;

            if (selectedNode == "Projets")
            {
                query = "SELECT ProjectID, Title, Description, StartDate, EndDate, Status FROM Projects";
            }
            else if (selectedNode == "Tâches")
            {
                query = "SELECT TaskID, Title, Description, StartDate, DueDate, Status FROM Tasks";
            }
            else if (selectedNode == "Utilisateurs")
            {
                query = "SELECT UserID,Username, PasswordHash, Email, Role, PhoneNumber FROM Users";
            }

            else if (selectedNode == "équipes")
            {

                query = "SELECT TeamID ,Name,LeaderID FROM Teams";
            }


            // Ajouter d'autres conditions pour d'autres catégories comme "Users", "Teams", etc.

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
                }
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Vérification du nœud sélectionné et chargement des données
            string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";

            if (e.Node.Text == "Employees")
            {
                LoadUsersData(connectionString);
            }
            else if (e.Node.Text == "Groups")
            {
                LoadTeamsData(connectionString);
            }
            else if (e.Node.Text == "Projets")
            {
                LoadProjectsData(connectionString);
            }
            else if (e.Node.Text == "Tâches")
            {
                LoadTasksData(connectionString);
            }

            // Mise à jour de l'arborescence du TreeView
            UpdateTreeView();
        }

        private void LoadUsersData(string connectionString)
        {
            string query = "SELECT UserID, Username, Email, Role, IsActive FROM Users";
            FillDataGridView(query, connectionString);
        }

        private void LoadTeamsData(string connectionString)
        {
            string query = "SELECT TeamID, Name, LeaderID FROM Teams";
            FillDataGridView(query, connectionString);
        }

        private void LoadProjectsData(string connectionString)
        {
            string query = "SELECT ProjectID, Title, Description, StartDate, EndDate, Status, ManagerID FROM Projects";
            FillDataGridView(query, connectionString);
        }

        private void LoadTasksData(string connectionString)
        {
            string query = "SELECT TaskID, ProjectID, Title, Description, StartDate, DueDate, Status, EstimatedTime, TeamLeadID FROM Tasks";
            FillDataGridView(query, connectionString);
        }

        private void FillDataGridView(string query, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données: " + ex.Message);
                }
            }
        }

        private void UpdateTreeView()
        {
            // Effacer les anciens nœuds du TreeView
            treeView.Nodes.Clear();

            // Ajouter des catégories au TreeView
            TreeNode employees = new TreeNode("Employees");
            employees.Nodes.Add("All (30)");
            employees.Nodes.Add("On leave (5)");
            employees.Nodes.Add("Sous-Traitants (3)");

            TreeNode projets = new TreeNode("Projets");
            projets.Nodes.Add("Chef de projets (5)");

            TreeNode groups = new TreeNode("Groups");
            groups.Nodes.Add("Chef d'équipes (8)");

            TreeNode taches = new TreeNode("Tâches");
            taches.Nodes.Add("Tâches sous-traitants (8)");
            taches.Nodes.Add("Tâches internes (8)");
            taches.Nodes.Add("Tâches externes (5)");

            // Ajout des nœuds au TreeView
            treeView.Nodes.Add(employees);
            treeView.Nodes.Add(projets);
            treeView.Nodes.Add(groups);
            treeView.Nodes.Add(taches);

            // Déplier tous les nœuds
            treeView.ExpandAll();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddProjettoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddProject formAddProject = new FormAddProject();
            formAddProject.Show(); // Ouvre le formulaire en mode non-bloquant
        }

        private void AddTasktoolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvre le formulaire d'ajout de tâche
            FormAddTask formAddTask = new FormAddTask();
            formAddTask.Show(); // Ouverture du formulaire sans avoir besoin de rafraîchir les tâches

            // Il n'est pas nécessaire de gérer les DataGridView ou de recharger les tâches ici
        }
        internal class EditformControl : Control
        {
        }

        private void LoadInitialData()
        {
            string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";
            LoadUsersData(connectionString);
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cuiButtonEdit_Click_1(object sender, EventArgs e)
        {

        }

        private void contextMenuEdit_Opening(object sender, CancelEventArgs e)
        {
            contextMenuEdit.Show(cuiButtonEdit, new Point(0, cuiButtonEdit.Height));
        }

        private void editTaskInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditTask form = new FormEditTask();
            form.Show();
        }
    }


}


      

    



       
           
       



        




    