using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class Login : Form
    {
        // Define your database connection string here
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public Login()
        {
            InitializeComponent();

            // Keeps the password hidden as dots by default
            password.UseSystemPasswordChar = true;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string Username = username.Text.Trim();
            string Password = password.Text.Trim();

            // 1. Basic validation to ensure fields aren't blank
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter the username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Connect to the database to verify credentials
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Fetch the ID and first_login flag from the librarians table
                    string query = "SELECT id, is_first_login FROM librarians WHERE username = @user AND password = @pass LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", Username);
                        cmd.Parameters.AddWithValue("@pass", Password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // If reader.Read() is true, the credentials are correct!
                            if (reader.Read())
                            {
                                string librarianId = reader["id"].ToString();
                                bool isFirstLogin = Convert.ToBoolean(reader["is_first_login"]);

                                // --- BRANCH A: FIRST-TIME LOGIN ---
                                if (isFirstLogin)
                                {
                                    MessageBox.Show("Welcome! Since this is your first time logging in, you must securely set up your personal username and password.", "First Time Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SetupProfileForm setupForm = new SetupProfileForm(librarianId);
                                    setupForm.Show();
                                    this.Hide();
                                }
                                // --- BRANCH B: NORMAL LOGIN ---
                                else
                                {
                                    Dashboard dashboard = new Dashboard();
                                    dashboard.FormClosed += (s, args) => Application.Exit();
                                    dashboard.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                // No match found in the database
                                MessageBox.Show("Invalid username or password. Please try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                password.Clear();
                                username.Clear();
                                username.Focus(); // Puts the typing cursor back in the username box
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}