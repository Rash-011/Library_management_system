using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class UserLogin : Form
    {
        private string connectionString = "Server=localhost;Database=library_db;Uid=root;Pwd=;";
        public UserLogin()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string enteredUser = username.Text.Trim();
            string enteredPass = password.Text;

            //if user left any field totaly blank
            if (string.IsNullOrWhiteSpace(enteredUser) || string.IsNullOrWhiteSpace(enteredPass))
            {
                MessageBox.Show("Please enter the username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            //Check credentials
            if (ValidateLogin(enteredUser, enteredPass))
            {
                MessageBox.Show($"Login successful! Welcome, {UserSession.FullName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UserDashboard userDashboard = new UserDashboard();
                userDashboard.Show();
                this.Hide();
            }

            else 
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Clear();
                username.Clear();

                return;
            }
        }
        private bool ValidateLogin(string userIdentifier, string inputPassword)
        {
            bool isValid = false;

          

            string query = "SELECT member_id, full_name, email, membership_type FROM members WHERE (member_id = @UserIdentifier OR email = @UserIdentifier) AND password = @Password AND status = 'Active' LIMIT 1;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Parameterized inputs prevent SQL injection vulnerabilities
                    cmd.Parameters.AddWithValue("@UserIdentifier", userIdentifier);
                    cmd.Parameters.AddWithValue("@Password", inputPassword);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populating the static UserSession with record details
                                UserSession.MemberId = reader["member_id"].ToString();
                                UserSession.FullName = reader["full_name"].ToString();
                                UserSession.Email = reader["email"].ToString();
                                UserSession.MembershipType = reader["membership_type"].ToString();

                                isValid = true;
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database connection failure: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isValid = false;
                    }
                }
            }
            return isValid;
        }
        private void signupbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirecting to the sign up page.", "Sign up");
            //sign up form logic is here
            //SignUpForm signUp = new SignUpForm();
            //signUp.show();
            //this.Hide();
        }

        private void fgtpassword_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the library Administrator or reset your password", "Account Recovery", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
