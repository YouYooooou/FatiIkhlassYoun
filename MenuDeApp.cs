using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ClosedXML.Excel;
using System.Diagnostics;
using iTextSharp.text;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
namespace FatiIkhlassYoun
{
    public partial class MenuDeApp : Form
    {

        private object favorites;
        private object treeViewMenu;
        private object filters;
        private Document document1;
        private string fileName;


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

            // ➤ Envoi WhatsApp à la fin
            string phone = "2126XXXXXXX"; // Numéro sans le +
            string message = "Rapports générés pour les projets suivants :\n\n" + string.Join("\n", nomsDeRapports);

            string url = "https://wa.me/" + phone + "?text=" + Uri.EscapeDataString(message);

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });

            MessageBox.Show("✅ Tous les rapports ont été générés et le message WhatsApp est prêt !");
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


        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Employees")
            {
                string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";
                string query = "SELECT UserID, Username, Email, Role, IsActive FROM Users";

                using (SqlConnection connection = new(connectionString))
                {
                    try
                    {
                        SqlDataAdapter adapter = new(query, connection);
                        DataTable dt = new();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors du chargement des utilisateurs : " + ex.Message);
                    }
                }
            }
            if (e.Node.Text == "Groups")
            {
                string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";
                string query = "SELECT TeamID,Name,LeaderID FROM Teams";

                using (SqlConnection connection = new(connectionString))
                {
                    try
                    {
                        SqlDataAdapter adapter = new(query, connection);
                        DataTable dt = new();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors du chargement des Groupes: " + ex.Message);
                    }
                }
            }
            if (e.Node.Text == "Projets")
            {
                string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";
                string query = "SELECT ProjectID,Title,Description,StartDate,EndDate,Status,ManagerID FROM Projects";

                using (SqlConnection connection = new(connectionString))
                {
                    try
                    {
                        SqlDataAdapter adapter = new(query, connection);
                        DataTable dt = new();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors du chargement des Groupes: " + ex.Message);
                    }
                }
            }
            if (e.Node.Text == "Tâches")
            {
                string connectionString = "Server=DESKTOP-78OLGDN;Database=ProjectManagementSystem;Integrated Security=True;";
                string query = "SELECT TaskID,ProjectID,Title,Description,StartDate,DueDate,Status,EstimatedTime,TeamLeadID FROM Tasks";

                using (SqlConnection connection = new(connectionString))
                {
                    try
                    {
                        SqlDataAdapter adapter = new(query, connection);
                        DataTable dt = new();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors du chargement des Groupes: " + ex.Message);
                    }
                }
            }
            treeView.Nodes.Clear();

            // ----- Catégorie "Employees"
            TreeNode employees = new("Employees");
            employees.Nodes.Add("All (30)");
            employees.Nodes.Add("On leave (5)");
            employees.Nodes.Add("Sous-Traitants (3)");

            // ----- Catégorie "Projets"
            TreeNode projets = new("Projets");
           
            projets.Nodes.Add("Chef de projets (5)");

            // ----- Catégorie "Groups"
            TreeNode groups = new("Groups");
          
            groups.Nodes.Add("Chef d'équipes (8)");

            // ----- Catégorie "Tâches"
            TreeNode taches = new("Tâches");
            taches.Nodes.Add("Tâches sous-traitants (8)");
            taches.Nodes.Add("Tâches internes (8)");
            taches.Nodes.Add("Tâches externes (5)");

            // ----- Ajout au TreeViewMenu
            treeView.Nodes.Add(employees);
            treeView.Nodes.Add(projets);
            treeView.Nodes.Add(groups);
            treeView.Nodes.Add(taches);

            treeView.ExpandAll(); // Tout déplier

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
    }
}

