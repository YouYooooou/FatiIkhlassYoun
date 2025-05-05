using System.Configuration;
using System.Data.SqlClient;

namespace FatiIkhlassYoun
{
    public partial class FormEditTask : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;
        public int TaskId { get; set; }
      

        public FormEditTask(int selectedId)
        {
            InitializeComponent();
            this.TaskId = selectedId;
        }

        public FormEditTask()
        {
        }

        private void FormEditTask_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStatus.Items.AddRange(new string[] { "En attente", "En cours", "Terminée" });
                cmbPriority.Items.AddRange(new string[] { "Basse", "Moyenne", "Haute" });

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Chargement des projets
                    SqlCommand cmdProjects = new SqlCommand("SELECT ProjectID, Title FROM Projects", conn);
                    using (SqlDataReader reader = cmdProjects.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbProject.Items.Add(new ComboboxItem(reader["Title"].ToString(), reader["ProjectID"]));
                        }
                    }

                    // Chargement des chefs d’équipe
                    SqlCommand cmdLeads = new SqlCommand("SELECT UserID, Username FROM Users WHERE Role = 'chef_equipe'", conn);
                    using (SqlDataReader reader = cmdLeads.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbTeamLead.Items.Add(new ComboboxItem(reader["Username"].ToString(), reader["UserID"]));
                        }
                    }

                    // Chargement des utilisateurs
                    SqlCommand cmdUsers = new SqlCommand("SELECT UserID, Username FROM Users", conn);
                    using (SqlDataReader reader = cmdUsers.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clbAssignedUsers.Items.Add(new ComboboxItem(reader["Username"].ToString(), reader["UserID"]));
                        }
                    }

                    // Charger les détails de la tâche
                    SqlCommand cmdTask = new SqlCommand("SELECT * FROM Tasks WHERE TaskID = @TaskID", conn);
                    cmdTask.Parameters.AddWithValue("@TaskID", TaskId);
                    using (SqlDataReader reader = cmdTask.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtTitle.Text = reader["Title"].ToString();
                            txtDescription.Text = reader["Description"].ToString();
                            dtpDueDate.Value = Convert.ToDateTime(reader["StartDate"]);
                            dtpDueDate.Value = Convert.ToDateTime(reader["DueDate"]);
                            cmbStatus.SelectedItem = reader["Status"].ToString();
                            cmbPriority.SelectedItem = reader["Priority"].ToString();
                            numEstimatedTime.Value = Convert.ToDecimal(reader["EstimatedTime"]);

                            int projectId = Convert.ToInt32(reader["ProjectID"]);
                            int teamLeadId = Convert.ToInt32(reader["TeamLeadID"]);

                            // Sélection projet et chef d'équipe
                            foreach (ComboboxItem item in cmbProject.Items)
                                if ((int)item.Value == projectId) cmbProject.SelectedItem = item;

                            foreach (ComboboxItem item in cmbTeamLead.Items)
                                if ((int)item.Value == teamLeadId) cmbTeamLead.SelectedItem = item;
                        }
                    }

                    // Cocher les utilisateurs déjà assignés
                    SqlCommand cmdAssigned = new SqlCommand("SELECT UserID FROM Task_Assignments WHERE TaskID = @TaskID", conn);
                    cmdAssigned.Parameters.AddWithValue("@TaskID", TaskId);
                    List<int> assignedUsers = new List<int>();
                    using (SqlDataReader reader = cmdAssigned.ExecuteReader())
                    {
                        while (reader.Read())
                            assignedUsers.Add((int)reader["UserID"]);
                    }

                    for (int i = 0; i < clbAssignedUsers.Items.Count; i++)
                    {
                        var item = clbAssignedUsers.Items[i] as ComboboxItem;
                        if (assignedUsers.Contains((int)item.Value))
                            clbAssignedUsers.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement : " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbProject.SelectedItem == null || cmbTeamLead.SelectedItem == null || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Champs obligatoires manquants.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Mise à jour de la tâche
                    SqlCommand cmd = new SqlCommand(@"
                        UPDATE Tasks SET 
                            ProjectID = @ProjectID,
                            Title = @Title,
                            Description = @Description,
                            StartDate = @StartDate,
                            DueDate = @DueDate,
                            Status = @Status,
                            EstimatedTime = @EstimatedTime,
                            TeamLeadID = @TeamLeadID,
                            Priority = @Priority
                        WHERE TaskID = @TaskID", conn);

                    cmd.Parameters.AddWithValue("@ProjectID", ((ComboboxItem)cmbProject.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@StartDate", dtpDueDate.Value);
                    cmd.Parameters.AddWithValue("@DueDate", dtpDueDate.Value);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EstimatedTime", (int)numEstimatedTime.Value);
                    cmd.Parameters.AddWithValue("@TeamLeadID", ((ComboboxItem)cmbTeamLead.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@Priority", cmbPriority.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TaskID", TaskId);

                    cmd.ExecuteNonQuery();

                    // Suppression des affectations existantes
                    SqlCommand delCmd = new SqlCommand("DELETE FROM Task_Assignments WHERE TaskID = @TaskID", conn);
                    delCmd.Parameters.AddWithValue("@TaskID", TaskId);
                    delCmd.ExecuteNonQuery();

                    // Réassignation
                    foreach (var item in clbAssignedUsers.CheckedItems)
                    {
                        var user = item as ComboboxItem;
                        SqlCommand assignCmd = new SqlCommand("INSERT INTO Task_Assignments (TaskID, UserID) VALUES (@TaskID, @UserID)", conn);
                        assignCmd.Parameters.AddWithValue("@TaskID", TaskId);
                        assignCmd.Parameters.AddWithValue("@UserID", user.Value);
                        assignCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tâche mise à jour avec succès !");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
