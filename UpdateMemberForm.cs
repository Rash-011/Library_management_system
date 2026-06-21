using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class UpdateMemberForm : Form
    {
        private string targetMemberId;
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public UpdateMemberForm(string memberId)
        {
            InitializeComponent();
            this.targetMemberId = memberId;
            LoadExistingMemberData();
        }

        private void LoadExistingMemberData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM members WHERE member_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", targetMemberId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader["full_name"].ToString();
                                cmbGender.Text = reader["gender"].ToString();
                                txtEmail.Text = reader["email"].ToString();

                                // Safely load the date into the DatePicker
                                if (DateTime.TryParse(reader["membership_date"].ToString(), out DateTime memDate))
                                {
                                    dtpMembershipDate.Value = memDate;
                                }

                                txtNic.Text = reader["nic_student_id"].ToString();
                                cmbMembershipType.Text = reader["membership_type"].ToString();
                                txtPhone.Text = reader["phone_number"].ToString();
                                cmbStatus.Text = reader["status"].ToString();
                                txtAddress.Text = reader["address"].ToString();
                                txtDob.Text = reader["date_of_birth"].ToString();
                                txtDescription.Text = reader["description"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading member data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Double click your Update button to create this event:
        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = @"UPDATE members SET 
                                            full_name = @name, gender = @gender, email = @email, 
                                            membership_date = @memDate, nic_student_id = @nic, 
                                            membership_type = @memType, phone_number = @phone, 
                                            status = @status, address = @address, 
                                            date_of_birth = @dob, description = @description 
                                           WHERE member_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@memDate", dtpMembershipDate.Value.Date);
                        cmd.Parameters.AddWithValue("@nic", txtNic.Text.Trim());
                        cmd.Parameters.AddWithValue("@memType", cmbMembershipType.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", txtDob.Text.Trim());
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", targetMemberId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}