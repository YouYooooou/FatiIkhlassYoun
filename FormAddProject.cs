using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FatiIkhlassYoun
{
    public partial class FormAddProject : Form
    {
        private string connectionString;

        public FormAddProject()
        {
            InitializeComponent();
        }

        private void FormAddProject_Load(object sender, EventArgs e)
        {
            // ➔ Remplir correctement la ComboBox des Statuts
            if (comboBoxStatus.Items.Count == 0)
            {
                comboBoxStatus.Items.Add("En attente");
                comboBoxStatus.Items.Add("En cours");
                comboBoxStatus.Items.Add("Terminé");

                comboBoxStatus.SelectedIndex = 0; // Sélectionne "En attente" par défaut
            }

            // ➔ Remplir la ComboBox des Managers
            string connectionString = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserID, Username, Role FROM Users WHERE Role IN ('Chef de projet', 'Chef d''équipe', 'Admin')", con);
                SqlDataReader reader = cmd.ExecuteReader();

                var managers = new List<KeyValuePair<int, string>>();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string username = reader.GetString(1);
                    string role = reader.GetString(2);

                    managers.Add(new KeyValuePair<int, string>(id, $"{username} - {role}"));
                }

                comboBoxManager.DataSource = managers;
                comboBoxManager.DisplayMember = "Value"; // Ce qu'on affiche
                comboBoxManager.ValueMember = "Key";     // Ce qu'on récupère
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            DateTime startDate = dateTimeStartDate.Value;
            DateTime endDate = dateTimeEndDate.Value;
            string status = comboBoxStatus.SelectedItem?.ToString(); // Ici on utilise comboBoxStatus

            if (comboBoxManager.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un manager.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int managerID = (int)comboBoxManager.SelectedValue;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Projects (Title, Description, StartDate, EndDate, Status, ManagerID)
                         VALUES (@Title, @Description, @StartDate, @EndDate, @Status, @ManagerID)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@ManagerID", managerID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Projet ajouté avec succès !");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout du projet : " + ex.Message);
                }
            }
        }

        private void FormAddProject_Load_1(object sender, EventArgs e)
        {

            // ➔ Remplir correctement la ComboBox des Statuts
            if (comboBoxStatus.Items.Count == 0)
            {
                comboBoxStatus.Items.Add("En attente");
                comboBoxStatus.Items.Add("En cours");
                comboBoxStatus.Items.Add("Terminé");

                comboBoxStatus.SelectedIndex = 0; // Sélectionne "En attente" par défaut
            }

            // ➔ Remplir la ComboBox des Managers
            string connectionString = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserID, Username, Role FROM Users WHERE Role IN ('Chef de projet', 'Chef d''équipe', 'Admin')", con);
                SqlDataReader reader = cmd.ExecuteReader();

                var managers = new List<KeyValuePair<int, string>>();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string username = reader.GetString(1);
                    string role = reader.GetString(2);

                    managers.Add(new KeyValuePair<int, string>(id, $"{username} - {role}"));
                }

                comboBoxManager.DataSource = managers;
                comboBoxManager.DisplayMember = "Value"; // Ce qu'on affiche
                comboBoxManager.ValueMember = "Key";     // Ce qu'on récupère
            }
        }
    }
    }
