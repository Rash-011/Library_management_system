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
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

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
                        cmd.Parameters.AddWithValue("@nic", txtNic.Text.Trim());
                        cmd.Parameters.AddWithValue("@memType", cmbMembershipType.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
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
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("A member with this NIC/Student ID already exists.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
