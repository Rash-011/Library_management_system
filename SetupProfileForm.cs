using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class SetupProfileForm : Form
    {
        // Holds the ID passed over from the Login screen
        private string loggedInLibrarianId;

        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public SetupProfileForm(string librarianId)
        {
            InitializeComponent();
            loggedInLibrarianId = librarianId;

            // Hide the passwords as dots for security
            textBox3.UseSystemPasswordChar = true;
            textBox4.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string newUsername = textBox2.Text.Trim();
            string newPassword = textBox3.Text.Trim();
            string confirmPassword = textBox4.Text.Trim();

            // 1. Validation Checks
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter them.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Clear();
                textBox4.Clear();
                textBox3.Focus();
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("For security, your password must be at least 6 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Update the Database (This PERMANENTLY replaces the default admin/123)
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // This query updates the exact row and turns OFF the first_login flag
                    string updateQuery = @"UPDATE librarians 
                                           SET full_name = @name, 
                                               username = @user, 
                                               password = @pass, 
                                               is_first_login = 0 
                                           WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", fullName);
                        cmd.Parameters.AddWithValue("@user", newUsername);
                        cmd.Parameters.AddWithValue("@pass", newPassword);
                        cmd.Parameters.AddWithValue("@id", loggedInLibrarianId);

                        cmd.ExecuteNonQuery();
                    }

                    // --- UPDATED ROUTING LOGIC ---
                    MessageBox.Show("Profile setup complete! Please log in with your new credentials.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 3. Send them BACK to the Login Form to prove they know the new credentials
                    Login loginForm = new Login();
                    loginForm.FormClosed += (s, args) => Application.Exit();
                    loginForm.Show();
                    this.Hide();
                }
                catch (MySqlException ex)
                {
                    // Catch duplicate usernames
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("That username is already taken. Please choose a different one.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Application Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Keep this here so the designer doesn't crash
        private void label7_Click(object sender, EventArgs e)
        {
        }

        // Left safely empty in case your designer is still looking for it!
        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}