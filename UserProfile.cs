using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class UserProfile : Form
    {
        private string loggedInMemberId = UserSession.MemberId.ToString();

        public UserProfile()
        {
            InitializeComponent();
        }

        public static string dbConn = "server=localhost;database=library_db;uid=root;pwd=;";
        MySqlDataAdapter adapter;
        DataTable dataTable;


        // This event runs automatically when the Form loads
        private void Form4_Load_1(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        // Fetch data from the database and display it in the TextBoxes
        private void LoadUserProfile()
        {


            // SQL query matching your members table column names
            string query = "SELECT full_name, member_id, gender, nic_student_id, membership_type, email, address, phone_number FROM members WHERE member_id = @MemberID";

            using (MySqlConnection conn = new MySqlConnection(dbConn))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberID", loggedInMemberId);

                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assigning data to Read-Only fields on the left side of the UI
                            txtFullName.Text = reader["full_name"].ToString();
                            txtMemberId.Text = reader["member_id"].ToString();
                            txtGender.Text = reader["gender"].ToString();
                            txtNIC.Text = reader["nic_student_id"].ToString();

                            // Assigning data to fields on the right side of the UI
                            txtMembershipType.Text = reader["membership_type"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtAddress.Text = reader["address"].ToString();
                            txtPhone.Text = reader["phone_number"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User profile not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // SQL query to update only the 3 editable fields
            string query = "UPDATE members SET email = @Email, address = @Address, phone_number = @Phone WHERE member_id = @MemberID";

            using (MySqlConnection conn = new MySqlConnection(dbConn))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Pass the new values from TextBoxes to the SQL Parameters
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@MemberID", txtMemberId.Text); // Identifies the logged-in user

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUserProfile(); // Refresh the Form with the updated data
                    }
                    else
                    {
                        MessageBox.Show("Update failed. User not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

