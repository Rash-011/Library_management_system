using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class PopupAddMember : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public PopupAddMember()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Grab these early so we can use them for our duplicate check
            string nic = txtNic.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // Basic validation to ensure the librarian doesn't save a blank form
            if (string.IsNullOrEmpty(nic))
            {
                MessageBox.Show("Please enter an NIC or Student ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // --- 1. THE DUPLICATE CHECK ---
                    // Checks if this NIC/Student ID or Phone Number is already in the database
                    string checkQuery = "SELECT COUNT(*) FROM members WHERE nic_student_id = @nic OR phone_number = @phone";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@nic", nic);
                        checkCmd.Parameters.AddWithValue("@phone", phone);

                        int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            // Stop the code entirely and warn the user nicely!
                            MessageBox.Show("A member with this NIC/Student ID or Phone Number already exists in the system!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }

                    // --- 2. YOUR ORIGINAL INSERT CODE ---
                    // If the code reaches here, the member is 100% unique and safe to save
                    string insertQuery = @"INSERT INTO members (
                                    full_name, gender, email, membership_date, 
                                    nic_student_id, membership_type, phone_number, 
                                    status, address, date_of_birth, description
                                  ) VALUES (
                                    @name, @gender, @email, @memDate, 
                                    @nic, @memType, @phone, 
                                    @status, @address, @dob, @description
                                  );
                                  SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@memDate", dtpMembershipDate.Value.Date);
                        cmd.Parameters.AddWithValue("@nic", nic); // Reused the variable from the top
                        cmd.Parameters.AddWithValue("@memType", cmbMembershipType.Text);
                        cmd.Parameters.AddWithValue("@phone", phone); // Reused the variable from the top
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", txtDob.Text.Trim());
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());

                        long newRowId = Convert.ToInt64(cmd.ExecuteScalar());

                        string fetchIdQuery = "SELECT member_id FROM members WHERE id = @id";
                        using (MySqlCommand fetchCmd = new MySqlCommand(fetchIdQuery, conn))
                        {
                            fetchCmd.Parameters.AddWithValue("@id", newRowId);
                            string customMemberId = fetchCmd.ExecuteScalar()?.ToString();

                            MessageBox.Show($"Member added successfully!\nMember ID: {customMemberId}",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding member: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
